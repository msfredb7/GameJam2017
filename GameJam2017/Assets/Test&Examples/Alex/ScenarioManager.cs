using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

    public static ScenarioManager instance;

    //public Ordinateur computer1;

    //public Registre registre1;

    public Personne Enrique;
    public Personne Samantha;
    public Personne Steven;
    public Personne Stephen;
    public Personne Justine;
    public Personne Annushka;
    public Personne Gary;
    public Personne Gaetan;
    public Personne MonsieurX;


    void Awake ()
    {
        if (instance == null)
            instance = this;

        Enrique.GetBrain().ToDo();
        Samantha.GetBrain().ToDo();
        Steven.GetBrain().ToDo();
        Stephen.GetBrain().ToDo();
        Justine.GetBrain().ToDo();
        Annushka.GetBrain().ToDo();
        Gary.GetBrain().ToDo();
        Gaetan.GetBrain().ToDo();
        MonsieurX.GetBrain().ToDo();
	}
}
