using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ScenarioEvent {

    float time();

    void Execute();

    void FastExecute();
}
