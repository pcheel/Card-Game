using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralFactory : MonoBehaviour, IFactory
{
    public ICard CreateCard(GameObject cardPrefab, Transform parent)
    {
        GameObject cardGO = Instantiate(cardPrefab, parent);
        ICard card = cardGO.GetComponent<ICard>();
        return card;
    }
    public ICharacter CreateCharacter()
    {
        return null;
    }
}
