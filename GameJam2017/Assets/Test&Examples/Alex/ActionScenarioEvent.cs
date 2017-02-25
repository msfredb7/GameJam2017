using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionScenarioEvent : ScenarioEvent
{
    private float startTime;
    private UnityAction action;

    public ActionScenarioEvent(float startTime, UnityAction action)
    {
        this.action = action;
        this.startTime = startTime;
    }

    public void Execute()
    {
        action.Invoke();
    }

    public void FastExecute()
    {
        action.Invoke();
    }

    public float Time()
    {
        return startTime;
    }
}
