using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioEventManager : Singleton<ScenarioEventManager> {

	private static List<ScenarioEvent> events = new List<ScenarioEvent>();

    public float startTime = 0;

    private static float start;

    protected void Start()
    {
        start = Time.time;
        start -= startTime;

        if (events.Count <= 0) return;

        events.Sort(new Comparer());

        for(int i = events.Count - 1; i >= 0; i--)
        {
            if (events[i].Time() < startTime)
            {
                events[i].FastExecute();
                events.Remove(events[i]);
            }
        }
    }

    void Update()
    {
        float currentTime = Time.time;

        

        if (events.Count <= 0) return;

        events.Sort(new Comparer());

        for (int i = events.Count - 1; i >= 0; i--)
        {
            if (events[i].Time() <= (currentTime - start))
            {
                events[i].Execute();
                events.Remove(events[i]);
            }
            else
            {
                break;
            }
        }
    }

    public static void AddEvent(ScenarioEvent newEvent)
    {
        events.Add(newEvent);
    }

    void PrintTest()
    {
        print("test");
    }


    private class Comparer : IComparer<ScenarioEvent>
    {
        public int Compare(ScenarioEvent x, ScenarioEvent y)
        {
            if (x.Time() < y.Time())
                return 1;
            if (x.Time() > y.Time())
                return -1;
            return 0;
        }
    }

    public float GetSeconds()
    {
        return (Time.time - start);
    }
}
