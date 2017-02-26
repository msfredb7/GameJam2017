using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using CCC.Manager;
using UnityEditor.SceneManagement;

public class EndGame : MonoBehaviour {

    public AudioSource winMusic;
    public GameObject button;

    void Start()
    {
        MasterManager.Sync();

        if(EditorSceneManager.GetActiveScene().name == "GameWin")
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
