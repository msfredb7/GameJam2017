using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class GameManager : Singleton<GameManager> {

    public List<Personne> staffs = new List<Personne>();

	protected override void Awake () {
        base.Awake();
        MasterManager.Sync();

        // Spawn Personnage
        //staffs.Add(new Personne()); // Exemple bidon
	}
}
