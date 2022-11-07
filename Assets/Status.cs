using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    public Text namaPartai;
    public Text pertap;
    public Text persec;
    public Image logo;

    private void OnEnable()
    {
        //namaPartai.text = Player._player.name;
        //pertap.text = Player._player.podium.perClickIncrease.ToString();
        //persec.text = Player._player.costume.bonusPerSecond.ToString();
        //logo.sprite = Collection._collection.logo_collection[PlayerPrefs.GetInt("Logo") - 1];
    }

}
