using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject goCustom, goPondium, goPlace;
    
    public void openCostume()
    {
        goPondium.SetActive(false);
        goPlace.SetActive(false);
        goCustom.SetActive(true);
    }

    public void openPodium()
    {
        goCustom.SetActive(false);
        goPlace.SetActive(false);
        goPondium.SetActive(true);
    }

    public void openPlace()
    {
        goCustom.SetActive(false);
        goPlace.SetActive(true);
        goPondium.SetActive(false);
    }

    public void Buy(Pakaian pakaian)
    {
        if (Player._player.hasMoney(pakaian.cost))
        {
            Player._player.costume = pakaian;
            Player._player.UpdateSprite();
            Player._player.DecreaseFollower(pakaian.cost);
        }
        
    }

    public void Buy(Backgrounds backgrounds)
    {
        if (Player._player.hasMoney(backgrounds.cost))
        {
            Player._player.background = backgrounds;
            Player._player.UpdateSprite();
            Player._player.DecreaseFollower(backgrounds.cost);
        }
            
    }

    public void Buy(Podiums podiums)
    {
        if (Player._player.hasMoney(podiums.cost))
        {
            Player._player.podium = podiums;
            Player._player.UpdateSprite();
            Player._player.DecreaseFollower(podiums.cost);
        }
            
    }
}
