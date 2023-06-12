using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private CardManager _cardManager;
    [SerializeField] private CharacterManager _characterManager;
    [SerializeField] private CardGameLoader _cardGameLoader;

    [Header("Prefabs")]
    [SerializeField] private GameObject _cardFactoryPrefab;

    private IFactory _factory;

    public void StartNextGameMove()
    {
        _cardManager.AddCardsToHand(_factory, 5);
    }
    public void StartFirstGameMove()
    {
        _cardManager.SetTakingDeck(_cardGameLoader.LoadPlayerDeck());
        _cardManager.AddCardsToHand(_factory, 5);
        _characterManager.SpawnPlayer(_factory, _cardGameLoader.LoadPlayerData());
        _characterManager.SpawnEnemies(_factory, _cardGameLoader.LoadEnemiesData());
    }

    private void CreateCardFactory()
    {
        GameObject cardFactoryGO = Instantiate(_cardFactoryPrefab, transform.parent);
        _factory = cardFactoryGO.GetComponent<IFactory>();
    }
    private void Start()
    {
        StartFirstGameMove();
    }
    private void Awake() 
    {
        CreateCardFactory();
    }
}
