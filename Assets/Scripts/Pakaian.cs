using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Kostum", menuName = "Object/Kostum", order = 1)]
public class Pakaian : ScriptableObject
{
    public Sprite baju_bg;
    public Sprite celana_bg;
    public Sprite footwear;
    public string Name;
    public int cost;
    public int bonusPerSecond;
}
