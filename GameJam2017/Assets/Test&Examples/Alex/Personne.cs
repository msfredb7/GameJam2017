using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

// Exemple de personnages
public class Personne : Character {

    private string nom;
    private string myDescription;
    private Sprite apparence;
    private Brain myBrain;
    private Cell myCell;

    public Personne(string myDescription, Brain myBrain, Cell myCell)
    {
        this.myDescription = myDescription;
        this.myBrain = myBrain;
        this.myCell = myCell;
    }

    public Brain GetBrain()
    {
        return myBrain;
    }
}
