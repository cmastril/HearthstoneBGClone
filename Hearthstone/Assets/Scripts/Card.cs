using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //Fields
    public enum Location { Hand, Board };
    public Location location = Location.Hand;

    public int currentHealth;
    public int maxHealth;

    public int attack;
}
