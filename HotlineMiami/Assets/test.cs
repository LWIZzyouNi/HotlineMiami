using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Ennemy ennemyChoose;
    public string itemName;
    public EnnemyType itemType;
    public string itemDescription;
    public bool isInLife;
    public bool isKnocked;
    public int maxLife;
    public int actualLife;

    // Start is called before the first frame update
    void Start()
    {
        actualLife = maxLife;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int a)
    {
        actualLife -= a;
    }
}
