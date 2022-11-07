using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public GameObject leaderboardMenu;
    public GameObject statusMenu;
    public GameObject creditMenu;
    private bool openMenu = false;

    public void toogleLeaderBoard(bool toogle)
    {
        if (!openMenu)
        {
            StartCoroutine(Leaderboard.board.LoadLeaderboard("https://leaderboardgame.000webhostapp.com/loadLeaderBoard.php", leaderboardMenu, toogle));
            openMenu = true;
        }
        
    }

    public void ExitGame()
    {
        Application.Quit(0);
    }

    public void CloseLeaderboard()
    {
        if (openMenu)
        {
            leaderboardMenu.SetActive(false);
            openMenu = false;
        }
    }

    public void VolumeButton()
    {
        if (!openMenu)
        {

        }
    }

    public void OpenStatus()
    {
        if (!openMenu)
        {
            statusMenu.SetActive(true);
            openMenu = true;
        }
    }

    public void CloseStatus()
    {
        if (openMenu)
        {
            statusMenu.SetActive(false);
            openMenu = false;
        }
    }

    public void OpenCredit()
    {
        if (openMenu)
        {
            creditMenu.SetActive(true);
            openMenu = true;
        }
    }

    public void CloseCredit()
    {
        if (openMenu)
        {
            creditMenu.SetActive(false);
        }
    }

}
