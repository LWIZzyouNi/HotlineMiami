using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : Ennemy
{
    public Ennemy ennemyChoose;

    // Start is called before the first frame update
    void Start()
    {
        ennemyChoose.actualLife = ennemyChoose.maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int a)
    {
        ennemyChoose.actualLife -= a;
    }
}
