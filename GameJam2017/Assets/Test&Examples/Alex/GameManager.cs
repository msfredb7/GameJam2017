using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class GameManager : Singleton<GameManager> {

    public ScenarioManager scenario;

	protected override void Awake () {
        base.Awake();
        MasterManager.Sync();

        // Spawn Personnage
        //staffs.Add(new Personne()); // Exemple bidon
        scenario.roger.SetPersonne("Roger","lolilol",new Cell());
	}
}
