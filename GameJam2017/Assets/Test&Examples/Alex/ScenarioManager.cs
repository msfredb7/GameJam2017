﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

    public static ScenarioManager instance;

    public FeuillePapier FeuillePlan;
    public FeuillePapier FeuilleAmourGaetan;
    public FeuillePapier FeuilleAmourSamantha;

    //public Ordinateur computer1;
    public Ordinateur StephenOrdi;
    public Ordinateur StevenOrdi;
    public Ordinateur EnriqueOrdi;
    public Ordinateur SamanthaOrdi;
    public Ordinateur GaryOrdi;
    public Ordinateur AnnushkaOrdi;
    public Ordinateur JustineOrdi;


    //public Registre registre1;

    public Personne Enrique;
    public Personne Samantha;
    public Personne Steven;
    public Personne Stephen;
    public Personne Justine;
    public Personne Annushka;
    public Personne Gary;
    public Personne Gaetan;
    public Personne MonsieurX;

    public GameObject particleClavier;

    void Awake ()
    {
        if (instance == null)
            instance = this;
        

        Enrique.SetPersonne("Enrique", "Enrique est le PDG de l’entreprise.\n\nD’origine mexicaine, il a déménagé ici à un très jeune âge.\n\nIl est rapidement devenu un douchebag.\n\nIl passe une bonne partie de son temps dans en réunion ou dans la salle d’entrainement de l’édifice.", new Cell());
        Samantha.SetPersonne("Samantha", "Samantha est la secrétaire de l’entreprise.\n\nElle a rejoint l’entreprise au cours de la dernière année.\n\nSes aptitudes professionnelles sont très peu développées, contrairement à sa poitrine.\n\nSes deux excellentes qualités lui ont permis d’être engagé sans aucun problème.", new Cell());
        Steven.SetPersonne("Steven", "Steven est plus âgé de 2 minutes et 21 secondes que son frère Stephen qui travaille également dans l’entreprise.\n\nIl s’occupe du département des ressources humaines de l’entreprise et son bureau renferme l’ensemble des données confidentielles des employés.", new Cell());
        Stephen.SetPersonne("Stephen", "Stephen est quelqu’un d’extrêmement charismatique et est le frère cadet de Steven.\n\nSa dernière campagne publicitaire a permis de doubler le chiffre d’affaire de l’entreprise.\n\nIl adore aller discuter avec les autres employés et être le centre de l’attention.", new Cell());
        Justine.SetPersonne("Justine", "Justine est une excellente comptable, mais elle déteste la routine.\n\nDu moins, c’est la raison qu’elle vous donnera lorsque vous lui demanderez pourquoi elle ne reste jamais plus de 5 ans dans la même compagnie.\n\nJustement, son contrat de travail se termine aujourd’hui...", new Cell());
        Annushka.SetPersonne("Annushka", "Annushka est une jeune femme russe qui effectue un stage international au sein de l’entreprise.\n\nSon français laisse à désirer, mais elle arrive, du moins la plupart du temps, à se faire comprendre malgré tout.\n\nAnnushka est une féministe très engagée et défend ardemment l’égalité des sexes en entreprise.", new Cell());
        Gary.SetPersonne("Gary", "Gary est l’informaticien de l’entreprise.\n\nAucun employé n’a déjà vu son visage, même pas le patron de l’entreprise, puisque Gary était déjà employé avant que Enrique devienne PDG.\n\nDes rumeurs supposent que le concierge a déjà aperçu brièvement la couleur de ses yeux, un soir de pleine lune lors de la dernière année bissextile.", new Cell());
        Gaetan.SetPersonne("Gaetan", "Gaétan est le concierge de l’édifice depuis près de 30 ans.\n\nD’origine musulmane, ses deux parents sont décédés il y a quelques années.\n\nIl passe la grande majorité de son temps dans les salles de bain de l’édifice ou dans son placard de conciergerie, ce qui explique ses comportements étranges.", new Cell());
        MonsieurX.SetPersonne("Luis", "Aucune information disponible", new Cell());

        //Trouve les référence des ordinateurs et les initialises.
        StephenOrdi = GameObject.Find("StephenOrdi").GetComponent<Ordinateur>();
        StevenOrdi = GameObject.Find("StevenOrdi").GetComponent<Ordinateur>();
        EnriqueOrdi = GameObject.Find("EnriqueOrdi").GetComponent<Ordinateur>();
        SamanthaOrdi = GameObject.Find("SamanthaOrdi").GetComponent<Ordinateur>();
        GaryOrdi = GameObject.Find("GaryOrdi").GetComponent<Ordinateur>();
        AnnushkaOrdi = GameObject.Find("AnnushkaOrdi").GetComponent<Ordinateur>();
        JustineOrdi = GameObject.Find("JustineOrdi").GetComponent<Ordinateur>();

        InitStephen();
        InitSteven();
        InitEnrique();
        InitSamantha();
        InitGary();
        InitAnnushka();
        InitJustine();
        InitGaetan();
        InitMx();


      
    }

    public void InitStephen()
    {
        List < Courriel > listC= new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Marketing Online", "Titre : Résumé de votre dernière campagne publicitaire (#098-1) Message: Votre dernière campagne publicitaire a généré 1082 % plus de clics qu’à l’habitude.Nous vous remercions de la confiance accordée à Marketing Online. "));
        listC.Add(new Courriel("EB GAMES", "Titre : Votre infolettre mensuel Message: Passez en boutique pour bénéficier de rabais exceptionnels sur les nouveautés.Échangez votre Xbox One(avec un minimum de 14 jeux et 3 mannettes) pour obtenir un crédit - magasin de 50$ sur la Nintendo Switch. "));


        listS.Add(new SiteInternet("www.LeMarketingPourLesNuls.ca","29/02/2016 : 8h00"));
        listS.Add(new SiteInternet("www.DevenirVotreProprePatron.fr", "29/02/2016 : 14h00"));
        StephenOrdi.initialise("StephenOrdi",listS,listC);
        Stephen.GetCell().AddTexto("J'sens que Enrique va me donner un bon bonus ma belle ! J'vais te gâter ;)", "29/02/2016 19.00", "Maya");
        Stephen.GetBrain().ToDo();
    }
    public void InitSteven()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Ressources Humaines Canada", "Titre : Conditions de travail Message: En réponse à vos précédentes requêtes, nous vous confirmons que les motifs évoqués par vos employés ne sont pas suffisant pour ouvrir une enquête interne sur votre PDG. "));
        listC.Add(new Courriel("LinkedIn", "Titre : Nouvelle connexion Message: Annushka désire rejoindre votre réseau LinkedIn.Nous vous suggérons de n’accepter les invitations des personnes que vous connaissez personnellement. "));
        listS.Add(new SiteInternet("www.StrategiesHumaines.ca", "29/02/2016 : 11h00"));
        listS.Add(new SiteInternet("www.uqac.ca", "29/02/2016 : 13.00"));
        listS.Add(new SiteInternet("www.MotiverSesEmployés.com", "29/02/2016 : 16h10"));
        StevenOrdi.initialise("StevenOrdi", listS, listC);
        StevenOrdi.AddFichierActif("RH", "Enrique Nom de jeune fille de la mère: Flores Date de naissance: 1980 - 08 - 01 Code employé: MasterChief \nGaétan Nom de jeune fille de la mère: Tremblay Date de naissance: 1980 - 07 - 15 Code employé: JanitorMan \nJustine Nom de jeune fille de la mère: Lavoie Date de naissance: 1987 - 09 - 21 Code employé: Juju87 \nSteven Nom de jeune fille de la mère: Dupont Date de naissance: 1984 - 06 - 29 Code employé: Stephen \nStephen Nom de jeune fille de la mère: Dupont Date de naissance: 1984 - 06 - 29 Code employé: Steven \nGary Nom de jeune fille de la mère: Loiselle Date de naissance: 1990 - 05 - 04 Code employé: gary_the_best \nAnnushkra Nom de jeune fille de la mère: Abakoumov Date de naissance: 1982 - 11 - 12 Code employé: LaStagiaireRusse \n Samantha :Nom de jeune fille de la mère: Lagarce Date de naissance: 1989 - 04 - 15 Code employé: SexyLady");
        Steven.GetCell().AddTexto("Faut qu'on se parle de nos plans pour demain soir !", "29/02/2017 18.30", "Stephen");
        Steven.GetBrain().ToDo();
    }
    public void InitEnrique()
    {
        List<Courriel> listC = new List<Courriel>();
        listC.Add(new Courriel("Garage automobile", "Titre : Civic immatriculé 756 JWB Message: Votre Civic est prête à être récupéré.Votre facture s’élève à 11, 876$ taxes incluses payable dans les trente(30) prochains jours."));
        listC.Add(new Courriel("Magasine 100% Hétéro", "Titre : Renouvellement abonnement Message: Votre abonnement au magasine 100 % Hétéro a expiré il y a 2 jours.Le renouvellement automatique d’un montant de 69, 00$ s’effectuera automatiquement la semaine prochaine.Pour annuler votre abonnement, veuillez communiquer avec le service à la clientèle. "));
        List<SiteInternet> listS = new List<SiteInternet>();
        listS.Add(new SiteInternet("www.100%-Hétéro.com", "29/02/2016 : 8h59"));
        listS.Add(new SiteInternet("www.ConnaitreSaSexualite.com", "29/02/2016 : 9h05"));
        listS.Add(new SiteInternet("www.100%-Homo.com", "29/02/2016 : 9h10"));
        listS.Add(new SiteInternet("www.100%-Homo.com", "30/02/2016 : 8h05"));
        EnriqueOrdi.initialise("EnriqueOrdi", listS, listC);
        Enrique.GetCell().AddTexto("Alors, toujours pas de copine? Pourtant j'tai présenté pleins de filles, j'commence à croire que t'es aux hommes", "29/02/2017", "Mikael");
        Enrique.GetCell().AddTexto("Y'a pas plus hétéro que moi j'tassure ! J'suis même abonné à 100% Hétéro depuis des années", "29/02/2017", "Message Sortant");
        Enrique.GetBrain().ToDo();
    }
    public void InitSamantha()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listS.Add(new SiteInternet("www.LaVenusMaquillage.ca", "29/02/2016 : 11.00"));
        listS.Add(new SiteInternet("www.SeduireSonPatron.com", "29/02/2016 : 13.00"));
        listS.Add(new SiteInternet("www.AmourDeBureau.ca", "29/02/2016 : 13.10"));
        SamanthaOrdi.initialise("SamanthaOrdi", listS, listC);
        Samantha.GetCell().AddTexto("Je vais suivre tes conseils pour draguer Enrique! Il ne pourra pas me résister cette fois ;)", "30/02/2017 8h05", "Sabrina");
        Samantha.GetBrain().ToDo();
    }
    public void InitGary()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listS.Add(new SiteInternet("www.EveOnline.com", "29/02/2016 : 11.00"));
        listS.Add(new SiteInternet("www.WoW.com", "29/02/2016 : 13.00"));
        listS.Add(new SiteInternet("www.GuildWar2.com", "29/02/2016 : 13.10"));
        GaryOrdi.initialise("GaryOrdi", listS, listC);
        GaryOrdi.AddFichierActif("Rapport Incomplet", "PDG de la compagnie Petrolus, depuis près de 20 ans, M.Luis est très respecté au Mexique. \n\nNéanmoins, j’ai réussi à trouver un scandale qui remonte à plusieurs années, soit 1996. \n\nIl aurait renié son fils après qu’il se soit ouvertement déclaré homosexuel, ce dernier aurait désormais changé d’identité et quitté le pays. Il est encore à se jour marié à une certaine Madame Flores.");
        Gary.GetCell().AddTexto("Calling all capitale pilote! We got a Titan tackled in 7RM, all reinforcement needed!","30/02/2017 2h30","CEO Init");
        Gary.GetBrain().ToDo();
    }
    public void InitAnnushka()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("International Student Center", "Titre : Message de bienvenue Message: Nous confirmons votre autorisation de travailler pour une durée de 3 mois, avec possibilité de prolongement conditionnel aux recommandations au sein de l’entreprise de M.Enrique Rodriguez. "));
        listC.Add(new Courriel("LinkedIn", "Titre : Steven a accepté votre demande de connexion Message: Vous pouvez désormais visualiser le profil de Steven ou démarrer une conversation. "));
        AnnushkaOrdi.initialise("AnnushkaOrdi", listS, listC);
        Annushka.GetCell().AddTexto("стадия CE? Ту меня тянь Au Courant де комментарий SE раззё тонный премьер ?", "30/02/2017 7h50", "Maman");
        Annushka.GetBrain().ToDo();
    }
    public void InitJustine()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Ordre comptable agréé (CPA)", "Titre : Plainte #134-02-111 Message: Madame, nous vous rappelons l’importance de répondre dans les plus brefs délais à notre précédent message.Votre ancien employeur, M.Milton, ayant déposé une plainte contre vous, il est dans votre devoir de formuler votre version des faits rapidement. "));
        listC.Add(new Courriel("Votre concessionnaire BMW", "Titre : Livraison - BMW 3 Series 2017 Message: Nous avons le plaisir de vous annoncer que votre BMW 3 Series 2017 vient tout juste d’arriver à notre succursale.Vous pouvez passer dès ce soir la récupérer, tel que demandé, nous l’avons décoré d’un ruban rouge. "));
        listC.Add(new Courriel("M.Milton", "Titre : Fraude fiscale Message: Puisque tu ne retournes pas mes appels, j’ai officiellement déposé une plainte à ton ordre professionnel.J’ai toutes les preuves nécessaires pour te poursuivre en justice.Je te conseille de me rendre ce que tu m’as volé pendant les 5 dernières années + intérêt de 10 % +dédommagement de 50 000$. "));
        listS.Add(new SiteInternet("www.Droit.ca", "29/02/2016 : 9h27"));
        listS.Add(new SiteInternet("www.ContratLegal.fr", "29/02/2016 : 14h05"));
        listS.Add(new SiteInternet("www.ParadisFiscaux.ca", "29/02/2016 : 15h16"));
        JustineOrdi.initialise("JustineOrdi", listS, listC);
        Justine.GetCell().AddTexto("Je prépare le même coup que d'habitude ce soir. 1 fois par 5 ans, c'est une tradition", "29/02/2016 16h40", "Julie");
        Justine.GetBrain().ToDo();
    }

    public void InitGaetan()
    {

        Gaetan.GetCell().AddTexto("Quand est-ce que tu nous présentes ton nouveau chum?", "29/02/2016 16h20", "George");
        Gaetan.GetBrain().ToDo();
    }

    public void InitMx()
    {
        MonsieurX.GetBrain().ToDo();
    }

    public Ordinateur GetPC(string name)
    {
        switch (name)
        {
            case "Enrique":
                return EnriqueOrdi;
            case "Samantha":
                return SamanthaOrdi;
            case "Gary":
                return GaryOrdi;
            case "Steven":
                return StevenOrdi;
            case "Stephen":
                return StephenOrdi;
            case "Justine":
                return JustineOrdi;
            case "Annushka":
                return AnnushkaOrdi;
            default:
                return null;
        }
    }
}

