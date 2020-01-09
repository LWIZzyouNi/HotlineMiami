using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnnemyType { Basic, Advanced, BadAss }

[CreateAssetMenu(fileName = "Ennemy_", menuName = "Ennemy", order = 1)]

public class Ennemy : ScriptableObject
{
    public string itemName;
    public EnnemyType itemType;
    public string itemDescription;
    public bool isInLife;
    public bool isKnocked;
    public int maxLife;
    public int actualLife;
}
    