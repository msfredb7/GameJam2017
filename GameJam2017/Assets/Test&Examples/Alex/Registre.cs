using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using CCC.Manager;




public struct Entry
{
    public string name;
    public string hour;
}

public class Registre : MonoBehaviour {
    public UnityEvent contentUpdate = new UnityEvent();


private List<Entry> entries = new List<Entry>();

    public Registre(List<Entry> entries)
    {
        this.entries = entries;
    }

	public List<Entry> GetEntries()
    {
        return entries;
    }

    public void AddEntry(string name, string hour)
    {
        Entry nouveauEntry = new Entry();
        nouveauEntry.name = name;
        nouveauEntry.hour = hour;
        entries.Add(nouveauEntry);

        contentUpdate.Invoke();
    }
}
