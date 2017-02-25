using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

    public Ordinateur computer1;

    public Registre registre1;

    public Personne roger;

	void Awake ()
    {
        // Exemples

        ActionScenarioEvent registreEvent1 = new ActionScenarioEvent(5,AjoutDuRegistre1);
        ScenarioEventManager.AddEvent(registreEvent1);

        ActionScenarioEvent registreEvent2 = new ActionScenarioEvent(5, ChangerMissionRoger);
        ScenarioEventManager.AddEvent(registreEvent2);
	}

    void AjoutDuRegistre1()
    {
        registre1.AddEntry("Bob","16h05");
    }

    void ChangerMissionRoger()
    {
        roger.GetBrain().ChangeCurrentAction(Brain.BaseAction.Idle);
    }
}
