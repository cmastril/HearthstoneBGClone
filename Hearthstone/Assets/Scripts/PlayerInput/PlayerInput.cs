using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public UnityEvent mouseClick1;

    private void Update()
    {
        InputHandle();
    }

    private void InputHandle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseClick1.Invoke();
        }
        
    }

}
