using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    //Events
    public UnityEvent damageTaken;

    //Fields
    public enum Owner {Player, Enemy};
    public Owner owner;

    public enum Location { Hand, Board };
    public Location location = Location.Hand;

    public int currentHealth;
    public int maxHealth;

    public int attack;

    //Functions
    public void DealDamage(int damageValue)
    {
        currentHealth -= damageValue;
        damageTaken.Invoke();
    }

}
