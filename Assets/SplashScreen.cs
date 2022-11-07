using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public void ChangeSceneAfterSplash(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
