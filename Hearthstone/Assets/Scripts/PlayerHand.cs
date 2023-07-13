using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    //References
    [SerializeField] private GameObject leftMostPlayerHandReferenceObject;
    [SerializeField] private Vector3 cardOffsetOnHand;

    //Fields
    public List<GameObject> cards = new List<GameObject>();

    private void AddCard(GameObject cardObject)
    {
        //Get Card Reference
        Card card = cardObject.GetComponent<Card>();

        //Add card to list
        cards.Add(cardObject);
        //Change cards location
        card.location = Card.Location.Hand;
        //Physically change location
        MoveCardToBoardPosition(cardObject);
    }

    private void MoveCardToBoardPosition(GameObject cardObject)
    {
        int totalCards = cards.Count;
        Vector3 leftMost = leftMostPlayerHandReferenceObject.transform.position;

        Vector3 newPosition = (cardOffsetOnHand * totalCards) + leftMost;

        //Move to new position
        cardObject.transform.position = newPosition;
    }
}
