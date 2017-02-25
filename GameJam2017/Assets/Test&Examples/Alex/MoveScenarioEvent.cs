using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveScenarioEvent : ScenarioEvent {

    private float startTime;
    private Personne personnage;
    private Vector3 position;

    public MoveScenarioEvent(float startTime, Vector3 position, Personne personnage)
    {
        this.startTime = startTime;
        this.position = position;
        this.personnage = personnage;
    }

    public void Execute()
    {
        personnage.MoveTo(position);
    }

    public void FastExecute()
    {
        personnage.Teleport(position);
    }

    public float Time()
    {
        return startTime;
    }
}
