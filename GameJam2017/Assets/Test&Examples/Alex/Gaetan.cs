using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gaetan : Brain
{
    public Sprite coeur;
    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("WCBlue_Janitor2").position, personnage));
        //9H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(57, WayPoint.getWaypoint("WCRed_Janitor1").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(110, WayPoint.getWaypoint("PlacardConsierge").position, personnage));

        //10H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(130, WayPoint.getWaypoint("BossDesk_Visiteur2").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(139, NoteDamour_BossDesk));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(140, WayPoint.getWaypoint("StephenDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(155, StephenOrdinateurUse));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(168, WayPoint.getWaypoint("AnnushkaDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(175, AnnushkaOrdiUse));

        //11H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(190, WayPoint.getWaypoint("WCBlue_Janitor2").position, personnage));
        //ScenarioEventManager.AddEvent(new ActionScenarioEvent(195, GaetanSoloConv));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(205, WayPoint.getWaypoint("SalleReunionSud").position, personnage));

        //12H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(275, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(290, WayPoint.getWaypoint("PlacardConsierge").position, personnage));

        //13h
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(300, GaetanPogneCul));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(330, WayPoint.getWaypoint("WCRed").position, personnage));

        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(360, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(405, WayPoint.getWaypoint("SalleEntrainement").position, personnage));

        //15H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(465, WayPoint.getWaypoint("InformaticienDesk").position, personnage));

        //16H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(480, tocGary));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(490, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(530, WayPoint.getWaypoint("SalleReunionStephen").position, personnage));


        //17H
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(555, ParleASteven));

        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(574, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(610, EmbrasseEnrique));

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(620, WayPoint.getWaypoint("SalleReunionGaetan").position, personnage));
    }

    public void NoteDamour_BossDesk()
    {
        ScenarioManager.instance.FeuilleAmourGaetan.gameObject.SetActive(true);
    }

    //10h45 Utilise le bureau de stephen
    public void StephenOrdinateurUse()
    {
        ScenarioManager.instance.StephenOrdi.AddSiteInternet(new SiteInternet("www.Généalogie.com", "30/02/2017 10.45"));
        ScenarioManager.instance.StephenOrdi.AddFichierActif("Genealogie Enrique Rodriguez", "Enrique Rodriguez, aucune naissance de Enrique entre 1965 et 1985");
        ClavierAnimation(15);
    }

    //10h52 Stephen le surprend et lui dis d’utiliser l’ordinateur de la stagiaire ? TODO
    public void StephenSuprise()
    {

    }

    //10h55 à 11h05 : Utilise l’ordinateur de Annushka
    public void AnnushkaOrdiUse()
    {
        ScenarioManager.instance.StephenOrdi.AddSiteInternet(new SiteInternet("www.Généalogie.com", "30/02/2017 10.45"));
        ScenarioManager.instance.AnnushkaOrdi.AddFichierActif("Genealogie Enrique", " Enrique Rojo \n Enrique Lopez \n Enrique Picaso\n Enrique Florez");
        ClavierAnimation(15);
    }

    //11h15 à 11h30 : Se parle seul dans la toilette des hommes
    public void GaetanSoloConv()
    {

    }

    //13h00 à 13h10 : Se pogne le cul dans son placard
    public void GaetanPogneCul()
    {

    }

    //16h00 à 16h10 : Cogne sans réponse +Gaétan dit à Gary qu’il faudrait bien qu’il le laisse nettoyer son bureau un jour
    public void tocGary()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 11);
    }

    //17h15 à 17h30 : Croise Steven et lui précise qu’il est allergique au chocolat. Steven il lui assure qu’il n’y en a pas dans le gâteau de ce soir
    public void ParleASteven()
    {
        Personne stev = ScenarioManager.instance.Steven;
        personnage.focus = stev;
        stev.focus = personnage;

        BulleManager.instance.Say("Hey Steven!\nJ'avais oublié de te\ndire, mais je suis allergique\nau chocolat.", personnage, 5, 0);
        BulleManager.instance.Say("T'es chanceux Gaétan,\nj'ai choisi un gâteau\nà la vanille.", ScenarioManager.instance.Steven, 5, 5);
        BulleManager.instance.Say("Ouff! C'est\nmon jour de chance \nen effet", personnage, 3, 10);

        stev.SetFocusIn(null, 13);
        personnage.SetFocusIn(null, 12);
    }

    //18h10 à 18h20 : Embrasse Enrique
    public void EmbrasseEnrique()
    {
        Vector3 pos = (transform.position + ScenarioManager.instance.Enrique.transform.position) / 2;
        pos += Vector3.forward;
        SpriteSpawner.instance.SpawnSprite(coeur, pos);
    }

}
