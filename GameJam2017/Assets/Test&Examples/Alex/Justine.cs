using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Justine : Brain {

    public override void ToDo()
    {
        //8H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(25, WayPoint.getWaypoint("StevenDesk_Visiteur").position, personnage));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(27, TurnTop));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(27, ConversationSteven));

        //9H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(62, AppelMari));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(98, TravailPersonnel));
        //10H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(140, WayPoint.getWaypoint("BossDesk_Visiteur2").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(142, TurnTop));
        //11H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(180, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(195, TravailPersonnel));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(230, WayPoint.getWaypoint("SalleDesEmployes_Justine").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(232, TurnRight));
        //12H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("WCRed_Miroir").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(275, Maquillage));
        //13H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("PlacardConsierge_Visiteur").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(301, TurnTop));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(310, ConversationGaetan));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(330, WayPoint.getWaypoint("WCRed").position, personnage));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(340, WayPoint.getWaypoint("JustineDesk").position, personnage));
        //14H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(360, WayPoint.getWaypoint("SamanthaDesk_Visiteur").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(361, TurnTop));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(368, ConversationSamantha));
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(390, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(395, AppelMari2));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(400, TravailPersonnel1));
        //15H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(435, WayPoint.getWaypoint("BossDesk_Visiteur2").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(440, TurnTop));
        //16H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(475, WayPoint.getWaypoint("JustineDesk").position, personnage));
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(490, TravailPersonnel3));
        //17H

        //18H
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(615, WayPoint.getWaypoint("SalleReunionJustine").position, personnage));

    }

    public void TravailPersonnel3()
    {
        ClavierAnimation(125);
    }

    public void TravailPersonnel2()
    {
        ClavierAnimation(25);
    }

    public void TravailPersonnel1()
    {
        ClavierAnimation(35);
    }

    public void TravailPersonnel()
    {
        ClavierAnimation(42);
    }



    public void TurnRight()
    {
        personnage.defaultDirection = Character.Direction.Right;
        personnage.SetDirectionIn(Character.Direction.Down, 40);
    }


    public void TurnTop()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 40);
    }

    public void Maquillage()
    {
        personnage.defaultDirection = Character.Direction.Up;
        personnage.SetDirectionIn(Character.Direction.Down, 30);
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
        AppelTéléphonique newCall = new AppelTéléphonique("Justine", "Mari");
        personnage.SetMyCall(newCall);

        Cell telephone = personnage.GetCell();

        BulleManager.instance.StartCall(personnage,34);

        telephone.SayInTelephone("Allo?", "Inconue");
        telephone.SayInTelephone("Bonjour c'est ta petite choupinette! J'ai une surprise pour toi.f", "Justine",2);
        telephone.SayInTelephone("Mais voyons mon amour, c’est la 3ième en 1 mois, t’as-tu eu une promotion?", "Inconue", 4);
        telephone.SayInTelephone("Non du tout, j’ai juste envie de te gâter et je reçois mon bonus de fin de contrat aujourd’hui", "Justine", 6);
        telephone.SayInTelephone("C’est quoi le cadeau que tu m’achetes?", "Inconue", 8);
        telephone.SayInTelephone("C’est une surprise", "Justine", 10);
        telephone.SayInTelephone("Allez dit le moi", "Inconue", 12);
        telephone.SayInTelephone("Non", "Justine", 14);
        telephone.SayInTelephone("Un indice allez", "Inconue", 16);
        telephone.SayInTelephone("Non j’veux pas que tu devines", "Justine", 18);
        telephone.SayInTelephone("Je vais pas deviner avec un ptit indice", "Inconue", 20);
        telephone.SayInTelephone("C’est ca que tu as dis la dernière fois aussi", "Justine", 22);
        telephone.SayInTelephone("Ohhhh t’es plate", "Inconue", 24);
        telephone.SayInTelephone("Bon raccroche, je dois retourner travailler", "Justine", 26);
        telephone.SayInTelephone("Pourquoi je raccrocherais? C’est à ton tour", "Inconue", 28);
        telephone.SayInTelephone("Non raccroche s’il te plait", "Justine", 30);
        telephone.SayInTelephone("Non toi raccroche", "Inconue", 32);
        telephone.SayInTelephone("Non toi raccroche", "Justine", 34);

        telephone.EndCall(34);
    }

    public void ConversationGaetan()
    {
        Personne gaet = ScenarioManager.instance.Gaetan;
        personnage.focus = gaet;
        gaet.focus = personnage;

        BulleManager.instance.Say("C'est vraiment malaisant,\n mais j'ai bouché la \n toilette des femmes", personnage, 3 ,0);
        BulleManager.instance.Say("Ben voyons,\n y'a pas de problème\n, on va aller voir ca\n ensemble", ScenarioManager.instance.Gaetan, 4, 3);
        BulleManager.instance.Say("Ensemble?", personnage, 1 , 7);
        BulleManager.instance.Say("Oui oui,\n ensemble!", ScenarioManager.instance.Gaetan, 3 , 8);
        BulleManager.instance.Say("Savais-tu que\nla ventilation de la\ntoilette des dames\n menait directement\nau bureau de Enrique?", ScenarioManager.instance.Gaetan, 4,11);
        BulleManager.instance.Say("OMG c'est horrible,\n est-ce qu'il le sait?", personnage, 3,15);
        BulleManager.instance.Say("Surement pas,\ncar ca pourrait \nêtre dangereux", ScenarioManager.instance.Gaetan, 4,18);
        BulleManager.instance.Say("Comment ca\ndangereux?", personnage, 2, 22);
        BulleManager.instance.Say("Quelqu'un de malintentionné\npourrait lancer une\nbombe par ce conduit.", ScenarioManager.instance.Gaetan, 3, 24);
        BulleManager.instance.Say("Hmm okay, tu fais\nparfois peur Gaetan.\nAnyway j'dois retourner travailler.", personnage, 3, 27);

        gaet.SetFocusIn(null, 30);
        personnage.SetFocusIn(null, 30);
    }

    public void ConversationSamantha()
    {
        Personne sam = ScenarioManager.instance.Samantha;
        personnage.focus = sam;
        sam.focus = personnage;

        BulleManager.instance.Say("Hey! Ca te tenterais-tu\nd'aller magasiner demain?", personnage,3,0);
        BulleManager.instance.Say("Ca serait super!\nOn pourrait aller\nse faire les ongles aussi.", ScenarioManager.instance.Samantha, 4,3);
        BulleManager.instance.Say("Ah mais attend,\nla soirée risque d'être\ntrop explosive.Je\npense pas qu'on sera en\n mesure de s'en remettre", ScenarioManager.instance.Samantha, 6,7);
        BulleManager.instance.Say("De quoi tu parles?", personnage, 3 , 13);
        BulleManager.instance.Say("Bah la fête pour\ntondé...Euh pour\nle deal de Enrique!", ScenarioManager.instance.Samantha, 4, 16);
        BulleManager.instance.Say("Hmm okay...\nTu m'en reparleras\nplus tard", personnage,3, 20);

        sam.SetFocusIn(null, 23);
        personnage.SetFocusIn(null, 23);
    }

    public void AppelMari2()
    {
        AppelTéléphonique newCall = new AppelTéléphonique("Justine", "Mari");
        personnage.SetMyCall(newCall);

        Cell telephone = personnage.GetCell();

        BulleManager.instance.StartCall(personnage, 12);

        telephone.SayInTelephone("Allo?", "Justine");
        telephone.SayInTelephone("Salut chérie, je me demandais tu rentrais à quelle heure ce soir?", "Inconue", 2);
        telephone.SayInTelephone("Euh je sais pas honnêtement", "Justine", 4);
        telephone.SayInTelephone("Comment ça?", "Inconue", 6);
        telephone.SayInTelephone("Bah je crois que Samantha vient de m’avouer que Enrique a organisé un party pour mon départ.", "Justine", 8);
        telephone.SayInTelephone("Amuses-toi bien alors, je t’aime!", "Inconue", 10);
        telephone.SayInTelephone("Moi aussi mon petit minou chou d’amour adoré que j’aime plus que tout au monde et de l’univers tout entier", "Justine", 12);

        telephone.EndCall(12);
    }
}
