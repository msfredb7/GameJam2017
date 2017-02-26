using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class GameManager : Singleton<GameManager> {

    

	protected override void Awake () {
        base.Awake();
        MasterManager.Sync();

        
    }

    public static void EndGame(bool Win)
    {
        if (Win)
        {
            DelayManager.StopAll();
            // Autres animations
            Scenes.Load("GameWin");
        } else
        {
            DelayManager.StopAll();
            // Autres animations
            Scenes.Load("GameOver");
        }
    }
}
