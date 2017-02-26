using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Samantha : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 8h00 a 8h10
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(10, MakeTexto1));                                             // 8h10 a 8h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("BossDesk").position, personnage)); // 8h30 a 8h40
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(40, Drague1));                                           // 8h40 a 9h00

        //ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("SamanthaDesk").position, personnage)); // 9h00
        
    }

    public void MakeTexto1()
    {
        personnage.GetCell().AddTexto("T'en reviendras pas Natasha, Enrique porte sa cravate rouge aujourd'hui. Y sait clairement que c'est ma préférée en plus", "8h10", "Enrique");
        personnage.GetCell().AddTexto("Oops lis pas le dernier message, c'était pas pour toi !", "8h10", "Enrique");
        personnage.GetCell().AddTexto("T'en reviendras pas Natasha, Enrique porte sa cravate rouge aujourd'hui. Y sait clairement que c'est ma préférée en plus", "8h10", "Natasha");
    }

    public void Drague1()
    {
        BulleManager.instance.Say("\nSalut mon beau! \n Grosse journée en vue? \n Belle cravate en passant \n ;)",personnage,10);
    }
}
