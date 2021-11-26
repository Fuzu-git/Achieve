using System;
using UnityEngine;

public class fire : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private bool hasAlreadyShot = false; 

    public static Action playerHasShot;
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            if (!hasAlreadyShot)
            {
                playerHasShot?.Invoke();

                hasAlreadyShot = true; 
            }
        }
    }
}
