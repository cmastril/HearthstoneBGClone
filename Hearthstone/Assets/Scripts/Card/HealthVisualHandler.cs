using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthVisualHandler : MonoBehaviour
{
    //References
    private Card card;
    [SerializeField] private TextMeshProUGUI healthText;

    private void Start()
    {
        card = this.gameObject.GetComponent<Card>();

        //Listeners
        card.damageTaken.AddListener(CardVisualHealthUpdate);
    }

    //Functions
    private void CardVisualHealthUpdate()
    {
        healthText.text = $"{card.currentHealth}";
    }
    
}
