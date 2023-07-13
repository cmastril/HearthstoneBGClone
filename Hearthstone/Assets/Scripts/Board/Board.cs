using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //References
    [SerializeField] private GameObject leftMostPlayerBoardReferenceObject;
    [SerializeField] private Vector3 cardOffsetOnBoard;

    //Fields
    public List<GameObject> aliveCards = new List<GameObject>();
    public List<GameObject> deadCards = new List<GameObject>();

    public void AddCard(GameObject cardObject)
    {
        //Add card to list
        aliveCards.Add(cardObject);

        //Update Card Data
        Card card = cardObject.GetComponent<Card>();
        card.location = Card.Location.Board;

        MoveCard(cardObject);
    }

    private void MoveCard(GameObject cardObject)
    {
        int totalCards = aliveCards.Count;
        Vector3 leftMost = leftMostPlayerBoardReferenceObject.transform.position;

        Vector3 newPosition = (cardOffsetOnBoard * totalCards) + leftMost;

        //Move to new position
        cardObject.transform.position = newPosition;
    }
}
