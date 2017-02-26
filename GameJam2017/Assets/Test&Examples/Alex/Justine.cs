using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Justine : Brain {

    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(25, WayPoint.getWaypoint("StevenDesk_Visiteur").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(25, ConversationSteven));
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
        BulleManager.instance.Say("Bon alors, comme j'avais commencé à t'expliquer hier...", ScenarioManager.instance.Steven, delay: 2);
        BulleManager.instance.Say("J'ai un appel important,\n Désolé je reviens.", ScenarioManager.instance.Steven, delay:5);

        steph.SetFocusIn(null, 7);
        personnage.SetFocusIn(null, 7);
    }

    public void AppelMari()
    {
        AppelTéléphonique newCall = new AppelTéléphonique("Justine", "Mari");
        personnage.SetMyCall(newCall);

        Cell telephone = personnage.GetCell();

        BulleManager.instance.StartCall(personnage,34);

        telephone.SayInTelephone("Allo?", false);
        telephone.SayInTelephone("Bonjour c'est ta petite choupinette!", true,2);
        telephone.SayInTelephone("Mais voyons mon amour, c’est la 3ième en 1 mois, t’as-tu eu une promotion?", false, 4);
        telephone.SayInTelephone("Non du tout, j’ai juste envie de te gâter et je reçois mon bonus de fin de contrat aujourd’hui", true, 6);
        telephone.SayInTelephone("C’est quoi le cadeau que tu m’achetes?", false, 8);
        telephone.SayInTelephone("C’est une surprise", true, 10);
        telephone.SayInTelephone("Allez dit le moi", false, 12);
        telephone.SayInTelephone("Non", true, 14);
        telephone.SayInTelephone("Un indice allez", false, 16);
        telephone.SayInTelephone("Non j’veux pas que tu devines", true, 18);
        telephone.SayInTelephone("Je vais pas deviner avec un ptit indice", false, 20);
        telephone.SayInTelephone("C’est ca que tu as dis la dernière fois aussi", true, 22);
        telephone.SayInTelephone("Ohhhh t’es plate", false, 24);
        telephone.SayInTelephone("Bon raccroche, je dois retourner travailler", true, 26);
        telephone.SayInTelephone("Pourquoi je raccrocherais? C’est à ton tour", false, 28);
        telephone.SayInTelephone("Non raccroche s’il te plait", true, 30);
        telephone.SayInTelephone("Non toi raccroche", false, 32);
        telephone.SayInTelephone("Non toi raccroche", true, 34);

        telephone.EndCall(34);
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
        AppelTéléphonique newCall = new AppelTéléphonique("Justine", "Mari");
        personnage.SetMyCall(newCall);

        Cell telephone = personnage.GetCell();

        BulleManager.instance.StartCall(personnage, 12);

        telephone.SayInTelephone("Allo?", true);
        telephone.SayInTelephone("Salut chérie, je me demandais tu rentrais à quelle heure ce soir?", false, 2);
        telephone.SayInTelephone("Euh je sais pas honnêtement", true, 4);
        telephone.SayInTelephone("Comment ça?", false, 6);
        telephone.SayInTelephone("Bah je crois que Samantha vient de m’avouer que Enrique a organisé un party pour mon départ.", true, 8);
        telephone.SayInTelephone("Amuses-toi bien alors, je t’aime!", false, 10);
        telephone.SayInTelephone("Moi aussi mon petit minou chou d’amour adoré que j’aime plus que tout au monde et de l’univers tout entier", true, 12);

        telephone.EndCall(12);
    }
}
