using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

// Classe abstraite pour definir le comportement d'un personnage
public abstract class Brain : MonoBehaviour {

    public Personne personnage;

    public abstract void ToDo();
}
