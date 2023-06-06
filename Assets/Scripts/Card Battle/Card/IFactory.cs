using UnityEngine;

public interface IFactory
{
    public ICard CreateCard(GameObject cardPrefab, Transform parent);
    public ICharacter CreateCharacter();
}
