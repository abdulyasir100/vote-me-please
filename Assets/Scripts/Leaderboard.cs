using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Leaderboard : MonoBehaviour
{
    public string[] usernames;
    public static Leaderboard board;
    public Text[] leads;
    public GameObject blocker;
    public Image[] images;

    public Text myRank;
    public Text myName;
    public Image myLogo;

    private int maxView = 5;

    private void Awake()
    {
        if (board == null)
        {
            board = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public IEnumerator LoadLeaderboard(string url,GameObject objectToActivate, bool toogle)
    {
        blocker.SetActive(true);
        yield return new WaitForEndOfFrame();
        StartCoroutine(InsertToLeaderBoard("https://leaderboardgame.000webhostapp.com/insertLeaderboard.php?follower="+Player._player.followers+"&username="+Player._player.name
            +"&logo="+PlayerPrefs.GetInt("Logo")));
        WWW getter = new WWW(url);
        yield return getter;
        
        usernames = getter.text.Split(',');
        
        for (int i = 0; i < usernames.Length; i++)
        {
            var r_name = usernames[i].Split('+');
            if (i <= maxView - 1)
            {
                leads[i].text = r_name[1];
                int id = Int32.Parse(r_name[2]);
                images[i].sprite = Collection._collection.logo_collection[id - 1];
            }
            if (r_name[1].Equals(Player._player.name))
            {
                int rank = Int32.Parse(r_name[0]);
                int id = Int32.Parse(r_name[2]);
                UpdatePlayer(rank,id);
            }
        }
        blocker.SetActive(false);
        objectToActivate.SetActive(toogle);
    }

    public IEnumerator InsertToLeaderBoard(string url)
    {
        yield return new WaitForEndOfFrame();
        //WWWForm form = new WWWForm();

        //byte[] bytes = null;

        //form.AddBinaryData("image", bytes, name, "image/png");

        WWW uploader = new WWW(url);
        yield return uploader;
    }

    private void UpdatePlayer(int rank, int id)
    {
        myName.text = Player._player.name;
        myRank.text = rank.ToString();
        myLogo.sprite = Collection._collection.logo_collection[id - 1];
    }

}
