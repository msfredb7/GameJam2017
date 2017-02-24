using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class GameManager : Singleton<GameManager> {

	protected override void Awake () {
        base.Awake();
        MasterManager.Sync();
	}
}
