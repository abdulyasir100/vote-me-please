using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Podium", menuName = "Object/Podium", order = 1)]
public class Podiums : ScriptableObject
{
    public string Name;
    public Sprite podium_sprite;
    public int cost;
    public int perClickIncrease;
    public Vector2 position;
    public Vector3 size;
    public bool frontPlayer;
}
