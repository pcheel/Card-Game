using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard
{
    public CardView cardView{get;}
    public void UseCard();
    public void Inizialize(IFactory factory, GameObject cardPrefab, Transform parent, CardData data);
}
