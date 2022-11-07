using UnityEngine;
using System.Collections;

public class PlaySoundAtInterval : MonoBehaviour
{

    AudioSource myAudio;
     void Start()
    {
        myAudio = GetComponent<AudioSource>();
        InvokeRepeating("playAudio", 5.0f, 6.0f);
    }

    void playAudio()
    {
        myAudio.Play();
    }

}