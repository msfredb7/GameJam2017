using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

// Classe abstraite pour definir le comportement d'un personnage
public abstract class Brain : MonoBehaviour {

    public Personne personnage;

    public Ordinateur monOrdi;

    void Awake()
    {
        personnage = GetComponent<Personne>();
    }

    public abstract void ToDo();

    public void ClavierAnimation()
    {
        if(ScenarioManager.instance.GetPC(personnage.nom) != null)
        {
            Vector3 position = ScenarioManager.instance.GetPC(personnage.nom).transform.position;
            Instantiate(ScenarioManager.instance.particleClavier, position, ScenarioManager.instance.particleClavier.transform.rotation);
        }
    }
}
