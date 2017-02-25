using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

// Classe abstraite pour definir le comportement d'un personnage
public abstract class Brain : MonoBehaviour {

    public enum BaseAction { Idle, Goto, Work }

    public BaseAction currentAction;

    public Personne personnage;

    protected Brain(Personne personne)
    {
        this.personnage = personne;
        ChangeCurrentAction(BaseAction.Idle);
    }

    // Update is called once per frame
    /* A ajouter dans votre classe
    void Update()
    {
        DelayManager.CallTo(Etape1, 5); // Le personnage fait l'etape 1 apres 5 secondes
                                        // Ajouter dautres etapes avec d'autres Unity Action
    }
    */

    public abstract void ChangeCurrentAction(BaseAction action);
}
