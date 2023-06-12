using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralFactory : MonoBehaviour, IFactory
{
    public ICard CreateCardModel()
    {
        Card card = new Card();
        return card;
    }
    public CardView CreateCardView(GameObject cardPrefab, Transform parent)
    {
        GameObject cardGO = Instantiate(cardPrefab, parent);
        CardView cardView = cardGO.GetComponent<CardView>();
        return cardView;
    }
    public ICharacter CreateCharacterModel()
    {
        Character character = new Character();
        return character;
    }
    public CharacterView CreateCharacterView(GameObject characterPrefab, Transform parent)
    {
        GameObject characterGO = Instantiate(characterPrefab, parent);
        return characterGO.GetComponent<CharacterView>();
    }
}
