using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioEventManager : Singleton<ScenarioEvent> {

	private List<ScenarioEvent> events = new List<ScenarioEvent>();

    public float startTime = 0;

    private float start;

    protected override void Awake()
    {
        base.Awake();
        start = Time.time;

        for(int i = events.Count - 1; i < 0; i--)
        {
            if (events[i].time() < startTime)
            {
                events[i].FastExecute();
                events.Remove(events[i]);
            } else if (events[i].time() == startTime)
            {
                events[i].Execute();
                events.Remove(events[i]);
            }
        }
    }

    public void AddEvent(ScenarioEvent newEvent)
    {
        events.Add(newEvent);
    }
}
