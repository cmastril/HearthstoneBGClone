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
        AddCard(newCard);
    }

}
