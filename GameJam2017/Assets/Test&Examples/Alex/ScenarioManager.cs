using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

    public Ordinateur computer1;

    public Registre registre1;

    public Personne roger;


    void Awake ()
    {
        // Exemples action dans le monde
        
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(5, AjoutDuRegistre1));

        // Exemple liste event Personne Roger

        roger.GetBrain().ToDo();
	}

    void AjoutDuRegistre1()
    {
        registre1.AddEntry("Bob","16h05");
    }
}
