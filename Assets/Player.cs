using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player _player;

    public Podiums podium;
    public Backgrounds background;
    public Pakaian costume;

    public Image myLogo;
    public Text myName;

    public string name;
    public int followers;
    public int idLogo;

    public SpriteRenderer podium_sprite;
    public SpriteRenderer background_sprite;
    public SpriteRenderer costume_sprite;
    public SpriteRenderer footwear_sprite;
    public SpriteRenderer underwear_sprite;

    private void Awake()
    {
        if (_player == null)
        {
            _player = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void UpdateSprite()
    {
        podium_sprite.sprite = podium.podium_sprite;
        UpdatePodium();
        background_sprite.sprite = background.sprite;
        costume_sprite.sprite = costume.baju_bg;
        footwear_sprite.sprite = costume.footwear;
        underwear_sprite.sprite = costume.celana_bg;
    }
    
    private void UpdatePodium()
    {
        if (podium.frontPlayer)
        {
            podium_sprite.sortingLayerName = "Penonton";
        }
        else
        {
            podium_sprite.sortingLayerName = "GameCharacters";
        }
        GameObject move = podium_sprite.gameObject;
        move.transform.position = podium.position;
        move.transform.localScale = podium.size;

    }

    public void DecreaseFollower(int cost)
    {
        followers -= cost;
        PlayerPrefs.SetInt("Follower", followers);
        UpdateUI();
    }

    public void UpdateUI()
    {
        int idLogo = PlayerPrefs.GetInt("Logo");
        myLogo.sprite = Collection._collection.logo_collection[idLogo - 1];
        myName.text = name;
        GameManager.manager.UpdateFollower();
    }

    public bool hasMoney(int cost)
    {
        return followers - cost >= 0;
    }

}
