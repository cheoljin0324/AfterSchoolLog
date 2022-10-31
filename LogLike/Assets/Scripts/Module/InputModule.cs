using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputModule : MonoBehaviour
{

    MainModule mainModule;

    private void Awake()
    {
        mainModule = GetComponent<MainModule>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftClick();
        }

        if (Input.GetMouseButtonDown(1))
        {
            RightClick();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            InputSpace();
        }

        if (0 != Input.GetAxis("Vertical") || 0 != Input.GetAxis("Horizontal"))
        {
            InputKeyBoard();
        }
        
    }

    void LeftClick()
    {

    }

    void RightClick()
    {

    }

    void InputKeyBoard()
    {
        mainModule.MoveTo();
    }

    void InputSpace()
    {

    }
}
