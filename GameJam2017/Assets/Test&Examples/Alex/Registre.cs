using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public struct Entry
{
    public string name;
    public string hour;
}

public class Registre : MonoBehaviour {

    private List<Entry> entries = new List<Entry>();

    public Registre(List<Entry> entries)
    {
        this.entries = entries;
    }

	public List<Entry> GetEntries()
    {
        return entries;
    }

    public void AddEntry(string name, string hour, float time = 0)
    {
        Entry nouveauEntry = new Entry();
        nouveauEntry.name = name;
        nouveauEntry.hour = hour;
        if (time == 0)
        {
            entries.Add(nouveauEntry);
        } else
        {
            DelayManager.CallTo(delegate()
            {
                entries.Add(nouveauEntry);
            }, time);
        }
    }
}
