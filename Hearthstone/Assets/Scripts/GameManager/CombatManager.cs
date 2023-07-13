using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    //References
    GameManager gameManager;
    PlayerBoard playerBoard;
    PlayerBoard enemyBoard;

    private void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        playerBoard = Object.FindObjectOfType<PlayerBoard>();
        enemyBoard = Object.FindObjectOfType<PlayerBoard>();

        //Add listeners
        gameManager.combatPhaseStart.AddListener(CombatProcedure);
    }

    //TEMPORARY
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("test code running here");
            CombatProcedure();
        }
    }

    //Fields

    //Functions
    private void CombatProcedure()
    {
        //Go through each side fo the field and fight
        GameObject tempCard1 = playerBoard.cards.ToArray()[0];
        GameObject tempCard2 = enemyBoard.cards.ToArray()[0];

        Fight(tempCard1, tempCard2);
    }

    private void Fight(GameObject card1, GameObject card2)
    {

    }
}
