using System;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public bool bulletHasAlreadyHit = false; 

    public static Action bulletHasHit;
    
    void Start()
    {
        rb.velocity = transform.forward * speed; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!bulletHasAlreadyHit)
        {
            bulletHasHit?.Invoke();
            bulletHasAlreadyHit = true; 
        }
        
        Destroy(gameObject);
    }
}
