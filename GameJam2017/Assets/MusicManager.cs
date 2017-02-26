using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class MusicManager : MonoBehaviour {

    public AudioSource audio;
    public float delay;

    void Start()
    {
        DelayManager.CallTo(delegate()
        {
            audio.Play();
        },delay);
        
    }
}
