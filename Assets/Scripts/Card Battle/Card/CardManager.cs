using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{   
    [Header("Dependencies")]
    [SerializeField] private CardsPositionController _cardsPositionController;
    
    [Header("Prefabs")]
    [SerializeField] private GameObject _cardPrefab;

    private List<ICard> _playerCardsInHand;
    private List<CardData> _takingDeck;
    private List<CardData> _discardDeck;
    private const int MAX_CARDS_IN_HAND = 10;

    public void AddCardsToHand(IFactory factory, int cardsCount)
    {
        if (_takingDeck.Count >= cardsCount)
        {
            AddConcreteCardsToHand(factory, _takingDeck.GetRange(0, cardsCount));
        }
        else
        {
            SuffleCardsFromDiscardDeckToTakingDeck();
            if (_takingDeck.Count >= cardsCount)
            {
                AddConcreteCardsToHand(factory, _takingDeck.GetRange(0, cardsCount));
            }
            else
            {
                AddConcreteCardsToHand(factory, _takingDeck);
            }
        }
    }
    public void AddConcreteCardsToHand(IFactory factory, List<CardData> cardDatas)
    {
        for (int i = 0; i < cardDatas.Count; i++)
        {
            if (_playerCardsInHand.Count < MAX_CARDS_IN_HAND)
            {
                ICard card = factory.CreateCardModel();
                card.Inizialize(factory, _cardPrefab, transform, cardDatas[i]);
                _playerCardsInHand.Add(card);
            }
            else
            {
                _discardDeck.Add(cardDatas[i]);
            }
        }
        _cardsPositionController.RefreshCardsInHand(_playerCardsInHand);
    }
    public void SetTakingDeck(List<CardData> newTakingDeck)
    {
        _takingDeck = new List<CardData>(newTakingDeck);
    }

    private void SuffleCardsFromDiscardDeckToTakingDeck()
    {

    }
    private void Awake()
    {
        _playerCardsInHand = new List<ICard>();
        _takingDeck = new List<CardData>();
        _discardDeck = new List<CardData>();
    }
}
