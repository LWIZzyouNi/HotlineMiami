using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float fireRate = 0.0f;
    public float bulletForce = 0f;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SetGun();
    }



    void SetGun()
    {
        PlayerController.s_Singleton.actualFireRate = fireRate;
        Shooting.s_Singleton.actualBulletForce = bulletForce;

    }
}
