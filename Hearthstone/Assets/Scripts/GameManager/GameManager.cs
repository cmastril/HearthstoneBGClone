using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class GameManager : MonoBehaviour
{
    //Fields
    public UnityEvent combatPhaseStart;
    public UnityEvent buyPhaseStart;

    public enum GameState {Buy, Combat};
    public GameState gameState = GameState.Combat;

    public void NextPhase()
    {
        if (gameState == GameState.Buy)
        {
            GoToCombatPhase();
        }
        else if (gameState == GameState.Combat)
        {
            GoToBuyPhase();
        }

    }

    private void GoToCombatPhase()
    {
        gameState = GameState.Combat;
        combatPhaseStart.Invoke();
    }

    private void GoToBuyPhase()
    {
        gameState = GameState.Buy;
        buyPhaseStart.Invoke();
    }

}
