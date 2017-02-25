using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

    public Ordinateur computer1;

    public Registre registre1;

    public Personne roger;

	void Awake ()
    {
        ActionScenarioEvent registreEvent1 = new ActionScenarioEvent(5,AjoutDuRegistre1);
        ScenarioEventManager.AddEvent(registreEvent1);
	}

    void AjoutDuRegistre1()
    {
        registre1.AddEntry("Bob","16h05");
    }
}
