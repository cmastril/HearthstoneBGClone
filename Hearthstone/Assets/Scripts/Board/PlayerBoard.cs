using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoard : Board
{
    private void Start()
    {
        TestUnitLoad();
    }

    [SerializeField] private GameObject referenceCard;
    private void TestUnitLoad()
    {
        GameObject newCard = Object.Instantiate(referenceCard);

        //Set owner
        Card cardComponent = newCard.GetComponent<Card>();
        cardComponent.owner = Card.Owner.Player;

        AddCard(newCard);
    }

}
