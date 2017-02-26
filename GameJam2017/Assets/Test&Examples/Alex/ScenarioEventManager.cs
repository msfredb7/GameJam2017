using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioEventManager : Singleton<ScenarioEventManager> {

	private static List<ScenarioEvent> events = new List<ScenarioEvent>();

    public float startTime = 0;
    public bool isIntro = false;

    private static float start;

    public bool executeEarlyActionEvent = true;

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
                if(events[i] is ActionScenarioEvent)
                {
                    if(executeEarlyActionEvent)
                        events[i].FastExecute();
                }
                else
                    events[i].FastExecute();

                events.Remove(events[i]);
            }
        }
    }

    public void ClearAll()
    {
        events.Clear();
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

    public static void AddEvent(ScenarioEvent newEvent, bool isIntro = false)
    {
        if (instance != null && instance.isIntro && !isIntro)
            return;
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

    public static float GetSeconds()
    {
        return (Time.time - start);
    }
}
