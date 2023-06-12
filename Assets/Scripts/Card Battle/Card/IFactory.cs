using UnityEngine;

public interface IFactory
{
    public ICard CreateCardModel();
    public CardView CreateCardView(GameObject cardPrefab, Transform parent);
    public ICharacter CreateCharacterModel();
    public CharacterView CreateCharacterView(GameObject characterPrefab, Transform parent);
}
