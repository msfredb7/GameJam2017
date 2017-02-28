using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class GameManager : Singleton<GameManager> {

    

	protected override void Awake () {
        base.Awake();
        MasterManager.Sync();

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(630,FinDuJeu));
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

    public void FinDuJeu()
    {
        EndGame(false);
    }
}
