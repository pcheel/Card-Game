using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGameLoader : MonoBehaviour
{
    public List<CardData> LoadPlayerDeck()
    {
        return new List<CardData>(){new CardData(),new CardData(),new CardData(),new CardData(),new CardData()};
    }
    public CharacterData LoadPlayerData()
    {
        return new CharacterData();
    }
    public List<CharacterData> LoadEnemiesData()
    {
        return new List<CharacterData>(){new CharacterData(), new CharacterData()};
    }
}
