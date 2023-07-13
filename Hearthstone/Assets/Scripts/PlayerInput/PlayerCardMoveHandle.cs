using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCardMoveHandle : MonoBehaviour
{
    //References
    private PlayerInput playerInput;
    private GameManager gameManager;

    private void Start()
    {
        //Get References
        playerInput = Object.FindObjectOfType<PlayerInput>();
        gameManager = Object.FindObjectOfType<GameManager>();

        //Initialize Listeners
        playerInput.mouseClick1.AddListener(PlayerMoveHandle);
    }

    private void PlayerMoveHandle()
    {
        //Raycast to object
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.Log(hit.transform.name);
        }
    }

}
