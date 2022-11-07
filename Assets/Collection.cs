using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public static Collection _collection;
    
    public Sprite[] logo_collection;

    public Sprite[] follower_collection;

    private void Awake()
    {
        if (_collection == null)
        {
            _collection = this;
        }
        else
        {
            Destroy(_collection);
        } 
    }
}
