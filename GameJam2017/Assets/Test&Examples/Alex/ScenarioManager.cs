using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

    public static ScenarioManager instance;

    //public Ordinateur computer1;
    public Ordinateur StephenOrdi;
    public Ordinateur StevenOrdi;
    public Ordinateur EnriqueOrdi;
    public Ordinateur SamanthaOrdi;
    public Ordinateur GaryOrdi;
    public Ordinateur AnnushkaOrdi;
    public Ordinateur JustineOrdi;


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

        //Trouve les référence des ordinateurs et les initialises.
        StephenOrdi = GameObject.Find("StephenOrdi").GetComponent<Ordinateur>();
        StevenOrdi = GameObject.Find("StevenOrdi").GetComponent<Ordinateur>();
        EnriqueOrdi = GameObject.Find("EnriqueOrdi").GetComponent<Ordinateur>();
        SamanthaOrdi = GameObject.Find("SamanthaOrdi").GetComponent<Ordinateur>();
        GaryOrdi = GameObject.Find("GaryOrdi").GetComponent<Ordinateur>();
        AnnushkaOrdi = GameObject.Find("AnnushkaOrdi").GetComponent<Ordinateur>();
        JustineOrdi = GameObject.Find("JustineOrdi").GetComponent<Ordinateur>();


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
