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
        StephenOrdi.initialise("StephenOrdi",listS,listC);
    }
    public void InitStevenOrdi()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
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
        AnnushkaOrdi.initialise("AnnushkaOrdi", listS, listC);
    }
    public void InitJustineOrdi()
    {
        List<Courriel> listC = new List<Courriel>();
        List<SiteInternet> listS = new List<SiteInternet>();
        JustineOrdi.initialise("JustineOrdi", listS, listC);
    }

}
