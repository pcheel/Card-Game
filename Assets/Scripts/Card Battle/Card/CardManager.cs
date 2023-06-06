using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{   
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
            ICard card = factory.CreateCard(_cardPrefab, transform);
            card.Inizialize(cardDatas[i]);
            _playerCardsInHand.Add(card);
        }
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
