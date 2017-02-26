using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class EndGame : MonoBehaviour {

    public AudioSource winMusic;

    void Update()
    {
        if (!winMusic.isPlaying)
        {
            Application.Quit();
        }
    }
}
