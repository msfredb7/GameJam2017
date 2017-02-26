using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

// Exemple de personnages
public class Personne : Character
{

    private string nom;
    private string myDescription;
    public Sprite apparence;
    public Personne focus = null;
    public Brain myBrain;
    private Cell myCell;

    public void SetFocusIn(Personne focus, float time)
    {
        if (time <= 0)
        {
            this.focus = focus;
        }
        else
            DelayManager.CallTo(delegate ()
            {
                this.focus = focus;
            }, time);
    }

    public void SetPersonne(string nom, string myDescription, Cell myCell)
    {
        this.myDescription = myDescription;
        this.nom = nom;
        this.myCell = myCell;
    }

    public string GetNom()
    {
        return nom;
    }

    public string GetDescription()
    {
        return myDescription;
    }

    public Cell GetCell()
    {
        return myCell;
    }

    public Brain GetBrain()
    {
        return myBrain;
    }

    public void SetMyCall(AppelTéléphonique myCall)
    {
        myCell.SetMyCall(myCall);
    }
}
