using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

[System.Serializable]
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

    public void AddEntry(string name, string hour)
    {
        Entry nouveauEntry = new Entry();
        nouveauEntry.name = name;
        nouveauEntry.hour = hour;
        entries.Add(nouveauEntry);
    }
}
