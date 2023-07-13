using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoard : Board
{
    private void Start()
    {
        TestLoadUnitsFunction();
    }

    [SerializeField] private GameObject referenceCard;

    private void TestLoadUnitsFunction()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject newCard = Object.Instantiate(referenceCard);
            AddCard(newCard);
        }

    }

}
