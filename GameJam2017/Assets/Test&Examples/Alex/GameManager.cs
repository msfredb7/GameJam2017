using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class GameManager : Singleton<GameManager> {

    public ScenarioManager scenario;

	protected override void Awake () {
        base.Awake();
        MasterManager.Sync();

        scenario.Enrique.SetPersonne("Enrique", "Whore", new Cell());
        scenario.Samantha.SetPersonne("Samantha", "Whore", new Cell());
        scenario.Steven.SetPersonne("Steven", "Whore", new Cell());
        scenario.Stephen.SetPersonne("Stephen", "Whore", new Cell());
        scenario.Justine.SetPersonne("Justine", "Whore", new Cell());
        scenario.Annushka.SetPersonne("Annushka", "Whore", new Cell());
        scenario.Gary.SetPersonne("Gary", "Whore", new Cell());
        scenario.Gaetan.SetPersonne("Gaetan", "Whore", new Cell());
        scenario.MonsieurX.SetPersonne("MonsieurX", "Whore", new Cell());
    }

    public static void EndGame(bool Win)
    {
        if (Win)
        {
            DelayManager.StopAll();
            Scenes.Load("GameWin");
        } else
        {
            DelayManager.StopAll();
            Scenes.Load("GameOver");
        }
    }
}
