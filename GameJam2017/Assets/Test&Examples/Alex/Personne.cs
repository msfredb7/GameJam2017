using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

// Exemple de personnages
public class Personne : Character {

    private string nom;
    private string myDescription;
    public Sprite apparence;
    public Brain myBrain;
    private Cell myCell;

    public void SetPersonne(string nom, string myDescription, Cell myCell)
    {
        this.myDescription = myDescription;
        this.nom = nom;
        this.myCell = myCell;
    }

    public string GetDescription()
    {
        return myDescription;
    }

    public Cell GetCell()
    {
        return myCell;
    }

    public string GetNom()
    {
        return nom;
    }

    public Brain GetBrain()
    {
        return myBrain;
    }

}
