﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(15,new Vector3(0,0,0),personnage));
    }
}
