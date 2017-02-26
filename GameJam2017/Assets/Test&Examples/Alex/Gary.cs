using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gary : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(-1, WayPoint.getWaypoint("InformaticienInsideDesk").position,personnage));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(30, SendCourrielToAnn));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(75, SendCourrielToSteven));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(125, SendCourrielToEnrique));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(250, TelephoneEnrique));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(320, SendCourrielTStephen));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(420, SendCourrielToStephen2));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(480, SendCourrielToAnn2));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(510, TelephoneEnrique2));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(570, SendCourrielToStephen3));
    }

    public void SendCourrielToAnn()
    {

    }

    public void SendCourrielToSteven()
    {

    }

    public void SendCourrielToEnrique()
    {

    }

    public void TelephoneEnrique()
    {

    }

    public void SendCourrielTStephen()
    {

    }

    public void SendCourrielToStephen2()
    {

    }

    public void SendCourrielToAnn2()
    {

    }

    public void TelephoneEnrique2()
    {

    }

    public void SendCourrielToStephen3()
    {

    }
}
