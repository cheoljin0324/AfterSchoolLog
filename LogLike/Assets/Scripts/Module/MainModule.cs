using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainModule : MonoBehaviour
{
    InputModule inputModule;
    CharacterController characterController;
    public float movespd;

    private void Awake()
    {
        inputModule = GetComponent<InputModule>();
        characterController = GetComponent<CharacterController>();
    }

    public void MoveTo()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, y).normalized;
        direction *= movespd;
        if(x!=0 || y!= 0)
        {
            characterController.SimpleMove(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * 3);
        }
    }
}
