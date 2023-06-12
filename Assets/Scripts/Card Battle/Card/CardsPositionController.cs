using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsPositionController : MonoBehaviour
{
    [SerializeField] private List<Transform> _cardPositions;

    public void RefreshCardsInHand(List<ICard> cardsInHand)
    {
        CalculatePositionPoints();
        for (int i = 0; i < cardsInHand.Count; i++)
        {
            cardsInHand[i].cardView.transform.parent = _cardPositions[i];
            cardsInHand[i].cardView.transform.localPosition = Vector3.zero;
            cardsInHand[i].cardView.transform.localRotation = Quaternion.Euler(Vector3.zero);
        }
    }

    private void CalculatePositionPoints()
    {

    }
}
