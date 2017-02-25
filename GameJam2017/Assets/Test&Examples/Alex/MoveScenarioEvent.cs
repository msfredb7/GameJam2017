using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveScenarioEvent : ScenarioEvent {

    private float startTime;
    private Personne personnage;
    private Vector2 position;

    public MoveScenarioEvent(float startTime, Vector2 position, Personne personnage)
    {
        this.startTime = startTime;
        this.position = position;
        this.personnage = personnage;
    }

    public void Execute()
    {
        // Deplacement normal
    }

    public void FastExecute()
    {
        // Teleport
    }

    public float Time()
    {
        return startTime;
    }
}
