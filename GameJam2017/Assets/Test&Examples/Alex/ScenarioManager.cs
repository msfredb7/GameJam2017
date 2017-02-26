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

        //Trouve les référence des ordinateurs et les initialises.
        StephenOrdi = GameObject.Find("StephenOrdi").GetComponent<Ordinateur>();
        StevenOrdi = GameObject.Find("StevenOrdi").GetComponent<Ordinateur>();
        EnriqueOrdi = GameObject.Find("EnriqueOrdi").GetComponent<Ordinateur>();
        SamanthaOrdi = GameObject.Find("SamanthaOrdi").GetComponent<Ordinateur>();
        GaryOrdi = GameObject.Find("GaryOrdi").GetComponent<Ordinateur>();
        AnnushkaOrdi = GameObject.Find("AnnushkaOrdi").GetComponent<Ordinateur>();
        JustineOrdi = GameObject.Find("JustineOrdi").GetComponent<Ordinateur>();

        Debug.Log(StephenOrdi);

        InitStephenOrdi();
        InitStevenOrdi();
        InitEnriqueOrdi();
        InitSamanthaOrdi();
        InitGaryOrdi();
        InitAnnushkaOrdi();
        InitJustineOrdi();

        Enrique.GetBrain().ToDo();
        Samantha.GetBrain().ToDo();
        Steven.GetBrain().ToDo();
        Stephen.GetBrain().ToDo();
        Justine.GetBrain().ToDo();
        Annushka.GetBrain().ToDo();
        Gary.GetBrain().ToDo();
        Gaetan.GetBrain().ToDo();
        MonsieurX.GetBrain().ToDo();
	}

    public void InitStephenOrdi()
    {
        List < Courriel > listC= new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Marketing Online", "Titre : Résumé de votre dernière campagne publicitaire (#098-1) Message: Votre dernière campagne publicitaire a généré 1082 % plus de clics qu’à l’habitude.Nous vous remercions de la confiance accordée à Marketing Online. "));
        listC.Add(new Courriel("EB GAMES", "Titre : Votre infolettre mensuel Message: Passez en boutique pour bénéficier de rabais exceptionnels sur les nouveautés.Échangez votre Xbox One(avec un minimum de 14 jeux et 3 mannettes) pour obtenir un crédit - magasin de 50$ sur la Nintendo Switch. "));
        StephenOrdi.initialise("StephenOrdi",listS,listC);
    }
    public void InitStevenOrdi()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Ressources Humaines Canada", "Titre : Conditions de travail Message: En réponse à vos précédentes requêtes, nous vous confirmons que les motifs évoqués par vos employés ne sont pas suffisant pour ouvrir une enquête interne sur votre PDG. "));
        listC.Add(new Courriel("LinkedIn", "Titre : Nouvelle connexion Message: Annushka désire rejoindre votre réseau LinkedIn.Nous vous suggérons de n’accepter les invitations des personnes que vous connaissez personnellement. "));
        StevenOrdi.initialise("StevenOrdi", listS, listC);
    }
    public void InitEnriqueOrdi()
    {
        List<Courriel> listC = new List<Courriel>();
        listC.Add(new Courriel("Garage automobile", "Titre : Civic immatriculé 756 JWB Message: Votre Civic est prête à être récupéré.Votre facture s’élève à 11, 876$ taxes incluses payable dans les trente(30) prochains jours."));
        listC.Add(new Courriel("Magasine 100% Hétéro", "Titre : Renouvellement abonnement Message: Votre abonnement au magasine 100 % Hétéro a expiré il y a 2 jours.Le renouvellement automatique d’un montant de 69, 00$ s’effectuera automatiquement la semaine prochaine.Pour annuler votre abonnement, veuillez communiquer avec le service à la clientèle. "));
        List<SiteInternet> listS = new List<SiteInternet>();
        EnriqueOrdi.initialise("EnriqueOrdi", listS, listC);
    }
    public void InitSamanthaOrdi()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        SamanthaOrdi.initialise("SamanthaOrdi", listS, listC);
    }
    public void InitGaryOrdi()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        GaryOrdi.initialise("GaryOrdi", listS, listC);
    }
    public void InitAnnushkaOrdi()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("International Student Center", "Titre : Message de bienvenue Message: Nous confirmons votre autorisation de travailler pour une durée de 3 mois, avec possibilité de prolongement conditionnel aux recommandations au sein de l’entreprise de M.Enrique Rodriguez. "));
        listC.Add(new Courriel("LinkedIn", "Titre : Steven a accepté votre demande de connexion Message: Vous pouvez désormais visualiser le profil de Steven ou démarrer une conversation. "));
        AnnushkaOrdi.initialise("AnnushkaOrdi", listS, listC);
    }
    public void InitJustineOrdi()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        listC.Add(new Courriel("Ordre comptable agréé (CPA)", "Titre : Plainte #134-02-111 Message: Madame, nous vous rappelons l’importance de répondre dans les plus brefs délais à notre précédent message.Votre ancien employeur, M.Milton, ayant déposé une plainte contre vous, il est dans votre devoir de formuler votre version des faits rapidement. "));
        listC.Add(new Courriel("Votre concessionnaire BMW", "Titre : Livraison - BMW 3 Series 2017 Message: Nous avons le plaisir de vous annoncer que votre BMW 3 Series 2017 vient tout juste d’arriver à notre succursale.Vous pouvez passer dès ce soir la récupérer, tel que demandé, nous l’avons décoré d’un ruban rouge. "));
        listC.Add(new Courriel("M.Milton", "Titre : Fraude fiscale Message: Puisque tu ne retournes pas mes appels, j’ai officiellement déposé une plainte à ton ordre professionnel.J’ai toutes les preuves nécessaires pour te poursuivre en justice.Je te conseille de me rendre ce que tu m’as volé pendant les 5 dernières années + intérêt de 10 % +dédommagement de 50 000$. "));
        JustineOrdi.initialise("JustineOrdi", listS, listC);
    }

}
