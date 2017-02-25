using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ScenarioEvent {

    float Time();

    void Execute();

    void FastExecute();
}
