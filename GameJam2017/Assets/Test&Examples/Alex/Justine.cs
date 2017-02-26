using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Justine : Brain {

    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(25, WayPoint.getWaypoint("StevenDesk_Visiteur").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(27, ConversationSteven));
        //9H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(62, AppelMari));

        //10H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(150, WayPoint.getWaypoint("BossDesk").position, personnage));
        //11H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(195, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes").position, personnage));
        //12H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("WCRed").position, personnage));
        //13H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("PlacardConsierge").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(310, ConversationGaetan));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(330, WayPoint.getWaypoint("WCRed").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(340, WayPoint.getWaypoint("JustineDesk").position, personnage));
        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(360, WayPoint.getWaypoint("SamanthaDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(365, ConversationSamantha));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(390, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(395, AppelMari2));
        //15H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(435, WayPoint.getWaypoint("BossDesk").position, personnage));

        //16H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(480, WayPoint.getWaypoint("JustineDesk").position, personnage));

        //17H

        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(615, WayPoint.getWaypoint("SalleReunionJustine").position, personnage));

    }

    public void ConversationSteven()
    {
        Personne steph = ScenarioManager.instance.Steven;
        personnage.focus = steph;
        steph.focus = personnage;

        BulleManager.instance.Say("Salut Steven", personnage,2);
        BulleManager.instance.Say("Bon alors, comme j'avais \n commencé  à t'expliquer \n hier...", ScenarioManager.instance.Steven, 3, delay: 2);
        BulleManager.instance.Say("J'ai un appel important,\n Désolé je reviens.", ScenarioManager.instance.Steven,3,delay:5);

        steph.SetFocusIn(null, 7);
        personnage.SetFocusIn(null, 7);
    }

    public void AppelMari()
    {
        // TODO 
        AppelTéléphonique newCall = new AppelTéléphonique("Justine", "Mari");
        personnage.SetMyCall(newCall);

        Cell telephone = personnage.GetCell();

        telephone.SayInTelephone("Allo?", false);
        telephone.SayInTelephone("Salut", true,3);
        telephone.SayInTelephone("Mais voyons", false, 5);

        telephone.EndCall(10);
    }

    public void ConversationGaetan()
    {
        Personne gaet = ScenarioManager.instance.Gaetan;
        personnage.focus = gaet;
        gaet.focus = personnage;

        BulleManager.instance.Say("C'est vraiment malaisant,\n mais j'ai bouché la \n toilette des femmes", personnage);
        BulleManager.instance.Say("Ben voyons,\n y'a pas de problème\n, on va aller voir ca\n ensemble", ScenarioManager.instance.Gaetan, delay:5);
        BulleManager.instance.Say("Ensemble?", personnage, 2 , 10);
        BulleManager.instance.Say("Oui oui,\n ensemble!", ScenarioManager.instance.Gaetan, 3 , delay:12);
        BulleManager.instance.Say("Savais-tu que\nla ventilation de la\ntoilette des dames\n menait directement\nau bureau de Enrique?", ScenarioManager.instance.Gaetan, delay:20);
        BulleManager.instance.Say("OMG c'est horrible,\n est-ce qu'il le sait?", personnage, delay:25);
        BulleManager.instance.Say("Surement pas,\ncar ca pourrait être dangereux", ScenarioManager.instance.Gaetan, delay: 30);
        BulleManager.instance.Say("Comment ca\ndangereux?", personnage, 3 , delay: 35);
        BulleManager.instance.Say("Quelqu'un de malintentionné\npourrait lancer une\nbombe par ce conduit?", ScenarioManager.instance.Gaetan, delay: 38);
        BulleManager.instance.Say("Hmm okay, tu fais\nparfois peur Gaetan.\nAnyway j'dois retourner travailler.", personnage, delay: 42);

        gaet.SetFocusIn(null, 43);
        personnage.SetFocusIn(null, 43);
    }

    public void ConversationSamantha()
    {
        Personne sam = ScenarioManager.instance.Samantha;
        personnage.focus = sam;
        sam.focus = personnage;

        BulleManager.instance.Say("Hey! Ca te tenterais-tu\nd'aller magasiner demain?", personnage);
        BulleManager.instance.Say("Ca serait super!\nOn pourrait aller\nse faire les ongles aussi.", ScenarioManager.instance.Samantha, 5);
        BulleManager.instance.Say("Ah mais attend,\nla soirée risque d'être\ntrop explosive.Je\npense pas qu'on sera en\n mesure de s'en remettre", ScenarioManager.instance.Samantha, 10);
        BulleManager.instance.Say("De quoi tu parles?", personnage, 2 , 15);
        BulleManager.instance.Say("Bah la fête pour\ntondé...Euh pour\nle deal de Enrique!", ScenarioManager.instance.Samantha , 17);
        BulleManager.instance.Say("Hmm okay...\nTu m'en reparleras\nplus tard", personnage, 22);

        sam.SetFocusIn(null, 23);
        personnage.SetFocusIn(null, 23);
    }

    public void AppelMari2()
    {
        // TODO
    }
}
