using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class RestartButton : MonoBehaviour {

    public void OnClick()
    {
        Scenes.Load("Intro");
    }
}
