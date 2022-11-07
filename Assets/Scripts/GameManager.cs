using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text follower_Text;
    public static GameManager manager;
    private float timer;

    public GameObject[] followerPhase_1;
    public GameObject[] followerPhase_2;
    public GameObject[] followerPhase_3;
    public GameObject[] followerPhase_4;

    public GameObject[] fullPhase;

    private int[] hasInstantiated;
    private GameObject[][] followerPhases;

    public GameObject follower;
    public int phaseNow = 0;

    private Leaderboard leaderboard;

    public void UpdateFollower()
    {
        follower_Text.text = Player._player.followers.ToString();
        PlayerPrefs.SetInt("Followers", Player._player.followers);
    }

    private void Awake()
    {
        if (manager == null)
        {
            manager = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void Start()
    {
        hasInstantiated = new int[] { 0,0,0,0};
        followerPhases = new GameObject[][] { followerPhase_1, followerPhase_2, followerPhase_3, followerPhase_4 };
        PlayerPrefs.DeleteAll();
        if (!PlayerPrefs.HasKey("Followers"))
        {
            PlayerPrefs.SetInt("Followers",9999);
            PlayerPrefs.SetString("Username","Anonim");
            PlayerPrefs.SetInt("Logo",5);
            Player._player.UpdateSprite();
            Player._player.UpdateUI();
        }
        Player._player.followers = PlayerPrefs.GetInt("Followers");
        UpdateFollower();
        CheckFollower();
    }
    
    public void IncreaseFollower(int count)
    {
        Player._player.followers += count;
        UpdateFollower();
        CheckFollower();
    }

    public void CheckFollower()
    {
        int multiplier = Player._player.background.multiplier;
        if (Player._player.followers >= 50 * multiplier)
        {
            ActiveCoverFollowers(3);
        }
        else if (Player._player.followers >= 20 * multiplier)
        {
            ActiveCoverFollowers(2);
        }
        else if (Player._player.followers >= 10 * multiplier)
        {
            ActiveCoverFollowers(1);
        }
        else if (Player._player.followers >= 1)
        {
            ActiveCoverFollowers(0);
        }
        else
        {
            ActiveCoverFollowers(-1);
        }
    }

    private void PerSecondUpdate()
    {
        if (timer <= 0)
        {
            int bonus = Player._player.costume.bonusPerSecond;
            if(bonus > 0)
            {
                IncreaseFollower(bonus);
            }
            timer = 1f;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void Update()
    {
        PerSecondUpdate();
    }

    void ActiveCoverFollowers(int active_follower)
    {
        if (active_follower >= 0 && (active_follower + 1) != phaseNow)
        {
            for (int i = active_follower; i >= 0; i--)
            {
                for (int j = 0; j < followerPhases[i].Length; j++)
                {
                    if (hasInstantiated[i] < followerPhases[i].Length)
                    {
                        var child = Instantiate(follower, followerPhases[i][j].transform);
                        child.transform.parent = followerPhases[i][j].transform;
                        hasInstantiated[i]++;
                    }
                    followerPhases[i][j].SetActive(true);
                }
                fullPhase[i].SetActive(true);
            }
        }
        for (int i = active_follower+1; i < followerPhase_1.Length; i++)
        {
            followerPhase_1[i].SetActive(false);
        }
        phaseNow = active_follower + 1;
    }

}
