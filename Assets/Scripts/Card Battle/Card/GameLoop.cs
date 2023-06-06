using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [SerializeField] private CardManager _cardManager;
    [SerializeField] private CharacterManager _characterManager;
    [SerializeField] private GameObject _cardFactoryPrefab;

    private IFactory _cardFactory;

    public void StartNextGameMove()
    {
        _cardManager.AddCardsToHand(_cardFactory, 5);
    }
    public void StartFirstGameMove()
    {
        _cardManager.AddCardsToHand(_cardFactory, 5);
        _characterManager.SpawnPlayer();
        _characterManager.SpawnEnemies();
    }

    private void CreateCardFactory()
    {
        GameObject cardFactoryGO = Instantiate(_cardFactoryPrefab, transform.parent);
        _cardFactory = cardFactoryGO.GetComponent<IFactory>();
    }
    private void Start()
    {
        StartNextGameMove();
    }
    private void Awake() 
    {
        CreateCardFactory();
    }
}
