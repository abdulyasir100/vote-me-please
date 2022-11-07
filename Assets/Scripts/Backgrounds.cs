using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Background", menuName = "Object/Background", order = 2)]
public class Backgrounds : ScriptableObject
{
    public string Name;
    public int cost;
    public Sprite sprite;
    public int multiplier;
}
