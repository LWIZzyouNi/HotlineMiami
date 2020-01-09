using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOfBullet : MonoBehaviour
{

    public GameObject hitEffect;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if ( other.gameObject.tag == "Ennemy")
        {
            other.gameObject.GetComponent<EnnemyScript>().TakeDamage(damage);
            
        }
        
        Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
