using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CCC.Manager;
using DG.Tweening;

public class IntroControls : MonoBehaviour {

    public Image fade;

    private bool canQuit = false;

    void Start()
    {
        fade.DOFade(0, 1).OnComplete(delegate()
        {
            canQuit = true;
        });
    }
    
	void Update () {
        if (Input.anyKeyDown && canQuit)
        {
            SoundManager.StopMusic(true);
            canQuit = false;
            fade.DOFade(1, 1).OnComplete(delegate ()
            {
                Scenes.Load("Main");
            });
        }
	}
}
