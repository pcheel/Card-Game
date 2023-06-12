using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ICard
{
    private CardView _cardView;

    public CardView cardView => _cardView;

    public void Inizialize(IFactory factory, GameObject cardPrefab, Transform parent, CardData data)
    {
        _cardView = factory.CreateCardView(cardPrefab, parent);
    }
    public void UseCard(){}
}
