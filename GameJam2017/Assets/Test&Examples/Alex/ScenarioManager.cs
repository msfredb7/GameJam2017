using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {

    public static ScenarioManager instance;

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

    void Awake ()
    {
        if (instance == null)
            instance = this;
        

        Enrique.SetPersonne("Enrique", "Enrique est le PDG de l’entreprise.\n\nD’origine mexicaine, il a déménagé ici à un très jeune âge. Il est rapidement devenu un douchebag. Il passe une bonne partie de son temps dans en réunion ou dans la salle d’entrainement de l’édifice.", new Cell());
        Samantha.SetPersonne("Samantha", "Samantha est la secrétaire de l’entreprise.\n\nElle a rejoint l’entreprise au cours de la dernière année. Ses aptitudes professionnelles sont très peu développées, contrairement à sa poitrine. Ses deux excellentes qualités lui ont permis d’être engagé sans aucun problème.", new Cell());
        Steven.SetPersonne("Steven", "Steven est plus âgé de 2 minutes et 21 secondes que son frère Stephen qui travaille également dans l’entreprise.\n\nIl s’occupe du département des ressources humaines de l’entreprise et son bureau renferme l’ensemble des données confidentielles des employés.", new Cell());
        Stephen.SetPersonne("Stephen", "Stephen est quelqu’un d’extrêmement charismatique et est le frère cadet de Steven.\n\nSa dernière campagne publicitaire a permis de doubler le chiffre d’affaire de l’entreprise. Il adore aller discuter avec les autres employés et être le centre de l’attention.", new Cell());
        Justine.SetPersonne("Justine", "Justine est une excellente comptable, mais elle déteste la routine.\n\nDu moins, c’est la raison qu’elle vous donnera lorsque vous lui demanderez pourquoi elle ne reste jamais plus de 5 ans dans la même compagnie. Justement, son contrat de travail se termine aujourd’hui...", new Cell());
        Annushka.SetPersonne("Annushka", "Annushka est une jeune femme russe qui effectue un stage international au sein de l’entreprise.\n\nSon français laisse à désirer, mais elle arrive, du moins la plupart du temps, à se faire comprendre malgré tout. Annushka est une féministe très engagée et défend ardemment l’égalité des sexes en entreprise.", new Cell());
        Gary.SetPersonne("Gary", "Gary est l’informaticien de l’entreprise.\n\nAucun employé n’a déjà vu son visage, même pas le patron de l’entreprise, puisque Gary était déjà employé avant que Enrique devienne PDG. Des rumeurs supposent que le concierge a déjà aperçu brièvement la couleur de ses yeux, un soir de pleine lune lors de la dernière année bissextile.", new Cell());
        Gaetan.SetPersonne("Gaetan", "Gaétan est le concierge de l’édifice depuis près de 30 ans.\n\nD’origine musulmane, ses deux parents sont décédés il y a quelques années. Il passe la grande majorité de son temps dans les salles de bain de l’édifice ou dans son placard de conciergerie, ce qui explique ses comportements étranges.", new Cell());
        MonsieurX.SetPersonne("MonsieurX", "Whore", new Cell());

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


        Debug.Log("Hey");





       
	}

    public void InitStephen()
    {
        List < Courriel > listC= new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Marketing Online", "Titre : Résumé de votre dernière campagne publicitaire (#098-1) Message: Votre dernière campagne publicitaire a généré 1082 % plus de clics qu’à l’habitude.Nous vous remercions de la confiance accordée à Marketing Online. "));
        listC.Add(new Courriel("EB GAMES", "Titre : Votre infolettre mensuel Message: Passez en boutique pour bénéficier de rabais exceptionnels sur les nouveautés.Échangez votre Xbox One(avec un minimum de 14 jeux et 3 mannettes) pour obtenir un crédit - magasin de 50$ sur la Nintendo Switch. "));


        listS.Add(new SiteInternet("www.LeMarketingPourLesNuls.ca","29/02/2016 : 11.00"));
        listS.Add(new SiteInternet("www.LaFainDuMonde.fr", "29/02/2016 : 13.00"));
        listS.Add(new SiteInternet("www.LeMonde.fr", "29/02/2016 : 13.10"));
        StephenOrdi.initialise("StephenOrdi",listS,listC);
        Stephen.GetBrain().ToDo();
    }
    public void InitSteven()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Ressources Humaines Canada", "Titre : Conditions de travail Message: En réponse à vos précédentes requêtes, nous vous confirmons que les motifs évoqués par vos employés ne sont pas suffisant pour ouvrir une enquête interne sur votre PDG. "));
        listC.Add(new Courriel("LinkedIn", "Titre : Nouvelle connexion Message: Annushka désire rejoindre votre réseau LinkedIn.Nous vous suggérons de n’accepter les invitations des personnes que vous connaissez personnellement. "));
        listS.Add(new SiteInternet("www.MutinerieEnEntreprise.ca", "29/02/2016 : 11.00"));
        listS.Add(new SiteInternet("www.PrimiPrime.fr", "29/02/2016 : 13.00"));
        listS.Add(new SiteInternet("www.Calinours.fr", "29/02/2016 : 13.10"));
        StevenOrdi.initialise("StevenOrdi", listS, listC);
        Steven.GetBrain().ToDo();
    }
    public void InitEnrique()
    {
        List<Courriel> listC = new List<Courriel>();
        listC.Add(new Courriel("Garage automobile", "Titre : Civic immatriculé 756 JWB Message: Votre Civic est prête à être récupéré.Votre facture s’élève à 11, 876$ taxes incluses payable dans les trente(30) prochains jours."));
        listC.Add(new Courriel("Magasine 100% Hétéro", "Titre : Renouvellement abonnement Message: Votre abonnement au magasine 100 % Hétéro a expiré il y a 2 jours.Le renouvellement automatique d’un montant de 69, 00$ s’effectuera automatiquement la semaine prochaine.Pour annuler votre abonnement, veuillez communiquer avec le service à la clientèle. "));
        List<SiteInternet> listS = new List<SiteInternet>();
        listS.Add(new SiteInternet("www.CactchAttack.ca", "29/02/2016 : 11.00"));
        listS.Add(new SiteInternet("www.CatchMen.fr", "29/02/2016 : 13.00"));
        listS.Add(new SiteInternet("www.XMen.ca", "29/02/2016 : 13.10"));
        EnriqueOrdi.initialise("EnriqueOrdi", listS, listC);
        Enrique.GetBrain().ToDo();
    }
    public void InitSamantha()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listS.Add(new SiteInternet("www.LaVenusMaquillage.ca", "29/02/2016 : 11.00"));
        listS.Add(new SiteInternet("www.FoudroiStyle.fr", "29/02/2016 : 13.00"));
        listS.Add(new SiteInternet("www.Sasasamouraille.ca", "29/02/2016 : 13.10"));
        SamanthaOrdi.initialise("SamanthaOrdi", listS, listC);
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
        Gary.GetBrain().ToDo();
    }
    public void InitAnnushka()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("International Student Center", "Titre : Message de bienvenue Message: Nous confirmons votre autorisation de travailler pour une durée de 3 mois, avec possibilité de prolongement conditionnel aux recommandations au sein de l’entreprise de M.Enrique Rodriguez. "));
        listC.Add(new Courriel("LinkedIn", "Titre : Steven a accepté votre demande de connexion Message: Vous pouvez désormais visualiser le profil de Steven ou démarrer une conversation. "));
        AnnushkaOrdi.initialise("AnnushkaOrdi", listS, listC);
        Annushka.GetBrain().ToDo();
    }
    public void InitJustine()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Ordre comptable agréé (CPA)", "Titre : Plainte #134-02-111 Message: Madame, nous vous rappelons l’importance de répondre dans les plus brefs délais à notre précédent message.Votre ancien employeur, M.Milton, ayant déposé une plainte contre vous, il est dans votre devoir de formuler votre version des faits rapidement. "));
        listC.Add(new Courriel("Votre concessionnaire BMW", "Titre : Livraison - BMW 3 Series 2017 Message: Nous avons le plaisir de vous annoncer que votre BMW 3 Series 2017 vient tout juste d’arriver à notre succursale.Vous pouvez passer dès ce soir la récupérer, tel que demandé, nous l’avons décoré d’un ruban rouge. "));
        listC.Add(new Courriel("M.Milton", "Titre : Fraude fiscale Message: Puisque tu ne retournes pas mes appels, j’ai officiellement déposé une plainte à ton ordre professionnel.J’ai toutes les preuves nécessaires pour te poursuivre en justice.Je te conseille de me rendre ce que tu m’as volé pendant les 5 dernières années + intérêt de 10 % +dédommagement de 50 000$. "));
        listS.Add(new SiteInternet("www.Droit.ca", "29/02/2016 : 11.00"));
        listS.Add(new SiteInternet("www.ContratLegal.fr", "29/02/2016 : 13.00"));
        listS.Add(new SiteInternet("www.MaitreNabal.ca", "29/02/2016 : 13.10"));
        JustineOrdi.initialise("JustineOrdi", listS, listC);
        Justine.GetBrain().ToDo();
    }

    public void InitGaetan()
    {

        Gaetan.GetCell().AddTexto("Yo man, bien ou bien chez toi?", "29/02/2016 16.20", "George Tron");

        Gaetan.GetBrain().ToDo();
    }

    public void InitMx()
    {
        MonsieurX.GetBrain().ToDo();
    }

}

