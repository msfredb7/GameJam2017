using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class MusicManager : MonoBehaviour {

    public AudioSource audio;

    void Start()
    {
        DelayManager.CallTo(delegate()
        {
            audio.Play();
        },9);
        
    }
}
