using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class EndGame : MonoBehaviour {

    public AudioSource winMusic;
    public GameObject button;

    void Start()
    {
        MasterManager.Sync();

        if(Scenes.Exists("GameWin"))
        {
            DelayManager.CallTo(delegate ()
            {
                Application.Quit();
            }, 10);
        } else
        {
            DelayManager.CallTo(delegate ()
            {
                button.SetActive(true);
            }, 5);
        }
    }
}
