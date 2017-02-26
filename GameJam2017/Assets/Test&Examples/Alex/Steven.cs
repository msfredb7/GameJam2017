using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steven : Brain {

    public override void ToDo()
    {
       

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(0, WayPoint.getWaypoint("StevenDesk").position, personnage)); // 8h00 a 8h10
         
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(10, TravailPersonnel)); // 8h10 a 8h30
                                                                                      //voir temps! 4 action 30 minutes
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(30, WayPoint.getWaypoint("StevenPhoneCall").position, personnage)); // 8h30 a 8h37

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(37, phoneCall1)); // 8h30 a 8h37

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(45, WayPoint.getWaypoint("StevenDesk").position, personnage)); // 8h45 a 8h52
                                                                                                                           //Discussion avec Justinne (instigateur)
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(52, DiscussionJustine)); // 8h52 a 9h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(60, WayPoint.getWaypoint("InformaticienDesk").position, personnage)); // 9h00 a 9h15

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(75, CognePorte)); // 9h15 a 9h20

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(80, WayPoint.getWaypoint("WCBlue").position, personnage)); // 9h20 a 9h35

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(95, CouleUnBronze)); // 9h35 a 9h40

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(100, WayPoint.getWaypoint("SalleDesEmployes").position, personnage)); // 9h40 a 9h50

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(110, RelaxSalleManger)); // 9h50 a 10h10
        
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(130, DiscussionStephen)); // 10h10 a 10h20

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(140, WayPoint.getWaypoint("StevenDesk").position, personnage)); // 10h20 a 10h30
                                                                                                                            // voir temps! Second à parler Donc doit timer Avec Annushka (Le temps est surement PAS BON de base)
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(165, DiscussionJustine)); // 10h30 a 11h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(180, RelaxBureau)); // 11h00 a 11h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(195, WayPoint.getWaypoint("WCBlue").position, personnage)); // 11h15 a 11h20
                                                                                                                        //Discussion avec Enriquer (Instigateur -> ? )
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(200, DiscussionEnrique)); // 11h20 a 11h40

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(220, WayPoint.getWaypoint("SalleDesEmployes").position, personnage)); // 11h40 a 11h50

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(230, RelaxSalleManger)); // 11h50 a 12h00

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(240, Mange)); // 12h00 a 12h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(270, WayPoint.getWaypoint("StevenDesk").position, personnage)); // 12h30 a 12h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(280, phoneCallAnnushka)); // 12h40 a 13h00

        //voir temps! 2 action 20 minutes
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(300, WayPoint.getWaypoint("StevenPhoneCall").position, personnage)); // 13h00 a 13h05

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(305, phoneCall2)); // 13h05 a 13h20

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(320, WayPoint.getWaypoint("StephenDesk").position, personnage)); // 12h20 a 12h30
                                                                                                                             //Discussion avec stephen (instigateur)
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(330, DiscussionStephen2)); // 13h30 a 14h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(360, WayPoint.getWaypoint("SalleDesEmployes").position, personnage)); // 14h00 a 14h10                                                                                                                               //Discussion avec stephen (instigateur -> ?)                                                                                                                                  //Discussion avec stephen (instigateur)                                                                                                                                
                                                                                                                                  //2ieme Discussion avec stephen (instigateur)
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(370, DiscussionStephen3)); // 14h10 a 14h45

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(405, WayPoint.getWaypoint("BossDesk").position, personnage)); // 14h45 a 15h00
                                                                                                                          //Discussion avec Enrique (Instigateur -> ?)
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(420, DiscussionEnrique2)); // 15h00 a 15h30

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(450, WayPoint.getWaypoint("SalleEntrainement").position, personnage)); // 15h30 a 15h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(460, Entrainer)); // 15h40 a 16h15

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(495, WayPoint.getWaypoint("WCBlue").position, personnage)); // 16h15 a 16h25

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(505, CouleUnBronze)); // 16h25 a 16h35

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(515, WayPoint.getWaypoint("StephenDesk").position, personnage)); // 16h35 a 16h45

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(525, DiscussionAnnushka)); // 16h45 a 17h00

        ScenarioEventManager.AddEvent(new MoveScenarioEvent(540, WayPoint.getWaypoint("SalleReunionSud").position, personnage)); // 17h00 a 17h15

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(555, DiscussionGaétan)); // 17h15 a 17h30
                                                                                       //DÉBUT ZONE VIDE, J'AI PATCHER
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(570, WayPoint.getWaypoint("StevenDesk").position, personnage)); // 17h30 a 17h40

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(580, RelaxBureau)); // 17h40 a 18h20
                                                                                  //DÉBUT ZONE VIDE
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(620, WayPoint.getWaypoint("SalleReunionSteven").position, personnage)); // 18h20 a 18h30
                                                                                                                                 //Discussion avec stephen (instigateur)                                                                                                                               
                                                                                                                   //The End
    }

    //Discussions
    public void DiscussionJustine()
    {
        Personne just = ScenarioManager.instance.Justine;
        personnage.focus = just;
        just.focus = personnage;

        BulleManager.instance.Say("Désolé, c'était un\nappel important.", personnage);
        BulleManager.instance.Say("Pas de problème", ScenarioManager.instance.Justine,2,5);
        BulleManager.instance.Say("Les projets de l’entreprise\ndoivent rester confidentiels,\nà partir de ce soir, tu perdras\ntes accès et devra remettre\nton téléphone de compagnie.", personnage,7,7);
        BulleManager.instance.Say("Signe ici et\ntu peux retourner travailler", personnage,4,14);

        just.SetFocusIn(null, 15);
        personnage.SetFocusIn(null, 15);
    }

    public void DiscussionStephen()
    {
        Personne steph = ScenarioManager.instance.Stephen;
        personnage.focus = steph;
        steph.focus = personnage;

        BulleManager.instance.Say("Écoute ca!\nJ'suis tellement tanné d'Enrique", ScenarioManager.instance.Stephen);
        BulleManager.instance.Say("Qu'est ce qu'il\n a fait encore?", personnage, 3, 5);
        BulleManager.instance.Say("Au lieu de me donner\nmon bonus, il a modifié\n sa Civic", ScenarioManager.instance.Stephen, 8);
        BulleManager.instance.Say("Urghh, ca me\nsurprend même pas...", personnage, 3, 13);

        steph.SetFocusIn(null, 14);
        personnage.SetFocusIn(null, 14);
    }

    public void DiscussionEnrique()
    { }

    public void DiscussionStephen2()
    {
        Personne steph = ScenarioManager.instance.Stephen;
        personnage.focus = steph;
        steph.focus = personnage;

        BulleManager.instance.Say("Tout est prêt\npour ce soir", personnage);
        BulleManager.instance.Say("Ca va être\ntout une surprise!", ScenarioManager.instance.Stephen, 5);

        steph.SetFocusIn(null, 6);
        personnage.SetFocusIn(null, 6);
    }

    public void DiscussionStephen3()
    { }
    public void DiscussionEnrique2()
    { }
    public void DiscussionAnnushka()
    {
        Personne ann = ScenarioManager.instance.Annushka;
        personnage.focus = ann;
        ann.focus = personnage;

        BulleManager.instance.Say("Annunshka,\nn'oublies pas le colis ce\nsoir! C'est vraiment\nimportant pour nous", personnage);
        BulleManager.instance.Say("Quelle heure?", ScenarioManager.instance.Annushka, 2, 5);
        BulleManager.instance.Say("18h30! La salle\nd’entrainement sera verrouillée,\ndemande à Gaétan d’arranger cela", personnage, 7);
        BulleManager.instance.Say("D'accord", ScenarioManager.instance.Annushka, 2, 12);

        ann.SetFocusIn(null, 11);
        personnage.SetFocusIn(null, 11);
    }
    public void DiscussionGaétan()
    { }
    //Telephon
    public void phoneCall1()
    { }
    public void phoneCallAnnushka()
    {

    }
    public void phoneCall2()
    { }
    //Animations Fixe (ou marche dans le vide, dépendament)
    public void TravailPersonnel()
    { }
    public void CognePorte()
    { }
    public void CouleUnBronze()
    { }
    public void RelaxSalleManger()
    { }
    public void RelaxBureau()
    { }
    public void Mange()
    { }
    public void Entrainer()
    { }
}
