using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class MusicManager : MonoBehaviour {

    public AudioSource mouseSound;
    public AudioSource audio;
    public float delay;

    public AudioSource lastsong;

    void Start()
    {
        DelayManager.CallTo(delegate()
        {
            audio.Play();
        },delay);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseSound.Play();
        }
    }

    public void PlayLastMinuteSong()
    {
        audio.Stop();
        lastsong.Play();
    }
}
