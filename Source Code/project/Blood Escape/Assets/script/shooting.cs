using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    int check = 0;
    public static shooting instance;
    private void Update()
    {
        instance = this;
        if (check >= 1)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                Shoot();
            }
        }
        
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void checkSW(int sw)
    {
        check = sw;
        print(check);

    }
}
