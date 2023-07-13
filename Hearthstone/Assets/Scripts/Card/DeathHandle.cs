using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandle : MonoBehaviour
{
    //References
    [SerializeField] private GameObject canvasObject;
    private Card card;

    private void Start()
    {
        card = this.gameObject.GetComponent<Card>();

        //Listeners
        card.damageTaken.AddListener(DeathCheck);
    }

    private void DeathCheck()
    {
        if (card.currentHealth <= 0)
        {
            //Dead
            DeathHandleProcedure();
        }
    }

    private void DeathHandleProcedure()
    {
        //Move card to invisible dead area of board

        //Move this card to its dead board list
        if (card.owner == Card.Owner.Player)
        {
            PlayerBoard playerBoard = Object.FindObjectOfType<PlayerBoard>();
            playerBoard.aliveCards.Remove(this.gameObject);
            playerBoard.deadCards.Add(this.gameObject);
        }
        else if (card.owner == Card.Owner.Enemy)
        {
            EnemyBoard enemyBoard = Object.FindObjectOfType<EnemyBoard>();
            enemyBoard.aliveCards.Remove(this.gameObject);
            enemyBoard.deadCards.Add(this.gameObject);
        }

        //Turn this card invisible (making the canvas inactive)
        canvasObject.SetActive(false);

        //Temporary garbage
        string objectName = card.gameObject.name;
        Debug.Log($"{objectName} has died");
    }

}
