using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : Brain {

    public enum BobAction {  }

    Bob(Personne personne) : base(personne)
    {

    }

    public override void ChangeCurrentAction(BaseAction action)
    {
        switch (action)
        {
            case BaseAction.Idle:
                // On fait levennement pour que braintest idle
                personnage.Stop();
                break;
            case BaseAction.Goto:
                // On fait levennement pour que braintest goto
                break;
            case BaseAction.Balayer:
                break;
            default:
                break;
        }
    }
}
