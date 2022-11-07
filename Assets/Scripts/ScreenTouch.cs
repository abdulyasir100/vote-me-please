using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTouch : MonoBehaviour
{
    private bool canTouch = true;

    public void touchEvent()
    {
        GameManager.manager.IncreaseFollower(Player._player.podium.perClickIncrease);
    }

}
