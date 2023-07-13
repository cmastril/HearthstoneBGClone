using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    //References
    GameManager gameManager;
    PlayerBoard playerBoard;
    EnemyBoard enemyBoard;

    private void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        playerBoard = Object.FindObjectOfType<PlayerBoard>();
        enemyBoard = Object.FindObjectOfType<EnemyBoard>();

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
        else if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("test code running here");
            Debug.Log(IsBattleContinuing());
        }
    }

    //Fields

    //Functions
    private void CombatProcedure()
    {
        if (IsBattleContinuing() == false) return;

        //Testing area
        GameObject tempCard1 = playerBoard.aliveCards.ToArray()[0];
        GameObject tempCard2 = enemyBoard.aliveCards.ToArray()[0];

        Fight(tempCard1, tempCard2);
    }

    private void Fight(GameObject card1, GameObject card2)
    {
        //Get Card Data
        Card card1Data = card1.GetComponent<Card>();
        Card card2Data = card2.GetComponent<Card>();

        //Deal damage
        int card1ATK = card1Data.attack;
        int card2ATK = card2Data.attack;
        card1Data.DealDamage(card2ATK);
        card2Data.DealDamage(card1ATK);
    }

    private bool IsBattleContinuing()
    {
        //No player cards left
        if (playerBoard.aliveCards.Count == 0) return false;

        //No enemy cards left
        if (enemyBoard.aliveCards.Count == 0) return false;

        //No conditions for cancelling have been met
        return true;
    }

}
