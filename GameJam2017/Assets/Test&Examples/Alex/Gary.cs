using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gary : Brain {

    public override void ToDo()
    {
        ScenarioEventManager.AddEvent(new MoveScenarioEvent(-1, WayPoint.getWaypoint("InformaticienInsideDesk").position,personnage));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(5, Work));

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
        ScenarioManager.instance.AnnushkaOrdi.AddCourriel(new Courriel("Garry", "Titre : Bienvenue dans l’équipe Message: Bonjour ma chère Annuska, je prends quelques minutes pour te souhaiter bienvenue dans l’équipe.Malheureusement, tu n’auras pas la chance de me voir en personne, mais si tu cognes à ma porte, je réglerai tout tes problèmes. "));
    }

    public void SendCourrielToSteven()
    {
        ScenarioManager.instance.StevenOrdi.AddCourriel(new Courriel("Garry", "Titre : Réponse : Invitation Soirée Message: Tu seras probablement loin d’être surpris d’apprendre que je ne pourrai pas être présent ce soir.Comme tu le sais, je déteste les interactions humaines.Je préfère largement les intelligences artificielles, qui elles, ne te demandent pas de commettre des gestes que tu pourrais regretter amèrement. "));

    }

    public void SendCourrielToEnrique()
    {
        ScenarioManager.instance.EnriqueOrdi.AddCourriel(new Courriel("Garry", "Titre : Réponse conversation téléphonique Message: Oui je peux toujours m’arranger pour fermer les lumières, c’est à quelle heure la soirée ? "));
    }

    public void TelephoneEnrique()
    {

    }

    public void SendCourrielTStephen()
    {
        ScenarioManager.instance.StephenOrdi.AddCourriel(new Courriel("Garry", "Titre : Informations sur la réunion Message: J’ai entendu tes problèmes et je suis prêt à t’offrir une solution simple et peu coûteuse.Il suffit de m’amener 1000$ dans une enveloppe scellée d’ici 17h30 et je te fournirai les informations que tu désires, soit le nom de la compagnie avec laquelle Enrique s’apprête à conclure une entente. "));
    }

    public void SendCourrielToStephen2()
    {
        ScenarioManager.instance.StephenOrdi.AddCourriel(new Courriel("Garry", "Titre : Spoiler Message: Pour te motiver à trouver le 1000$ rapidement, je te donne un petit indice !Notre mystérieux visiteur arrive du Mexique, où sa compagnie est évaluée à plusieurs milliards de dollars. "));
    }

    public void SendCourrielToAnn2()
    {
        ScenarioManager.instance.AnnushkaOrdi.AddCourriel(new Courriel("Garry", "Titre : Problème électronique Message: J’ai réparé ton ordinateur, désolé de ne pas t’avoir répondu en personne, je communique uniquement par courriel.On s’habitue rapidement, ne t’inquiètes pas. "));
    }

    public void TelephoneEnrique2()
    {

    }

    public void SendCourrielToStephen3()
    {
        ScenarioManager.instance.StephenOrdi.AddCourriel(new Courriel("Garry", "Titre : Délai expiré Message: Malheureusement, tu n’as pas satisfait les conditions.Je ne te remettrai malheureusement pas le rapport contenant les informations.Tu peux toujours essayer de pirater mon ordinateur pour l’obtenir.Personne n’a jamais réussi, donc bonne chance! "));
    }

    public void Work()
    {
        ClavierAnimation();
    }
}
