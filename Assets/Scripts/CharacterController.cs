using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float playerSpeed;
    
    public static Action MoveForward;
    public static Action MoveBackward; 
    public static Action MoveLeft; 
    public static Action MoveRight;

    private bool hasAlreadyMovedForward = false;
    private bool hasAlreadyMovedBackward = false;
    private bool hasAlreadyMovedLeft = false;
    private bool hasAlreadyMovedRight = false;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
            if (!hasAlreadyMovedForward)
            {
                MoveForward?.Invoke();
                hasAlreadyMovedForward = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * playerSpeed * Time.deltaTime);
            if (!hasAlreadyMovedBackward)
            {
                MoveBackward?.Invoke();
                hasAlreadyMovedBackward = true;
            }
            
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
            if (!hasAlreadyMovedLeft)
            {
                MoveLeft?.Invoke();
                hasAlreadyMovedLeft = true; 
            }
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
            if (!hasAlreadyMovedRight)
            {
                MoveRight?.Invoke();
                hasAlreadyMovedRight = true;
            }
        }
    }
}
