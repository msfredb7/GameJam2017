using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using CCC.Manager;

[System.Serializable]
public struct SiteInternet
{
    public string adresse;
    public string date;

    public SiteInternet(string a,string d)
    {
        adresse = a;
        date = d;
    }
}

[System.Serializable]
public struct Courriel
{
    public string expediteur;
    public string text;

    public Courriel(string d, string t)
    {
        expediteur = d;
        text = t;
    }
}

public class Ordinateur : MonoBehaviour {
    public UnityEvent contentUpdate = new UnityEvent();
    public string password = "";

    private string nomOrdinateur;
    private List<SiteInternet> historique = new List<SiteInternet>();
    private List<Courriel> courriels = new List<Courriel>();

    private FichierActif fichierActif;


    public void initialise(string nomOrdinateur, List<SiteInternet> historique, List<Courriel> courriels)
    {
        this.nomOrdinateur = nomOrdinateur;
        this.historique = historique;
        this.courriels = courriels;
        fichierActif = null;
    }

    public string GetNomOrdinateur()
    {
        return nomOrdinateur;
    }

    public FichierActif GetFichierActif()
    {
        return fichierActif;
    }

    public List<SiteInternet> GetHistorique()
    {
        return historique;
    }

    public List<Courriel> GetCourriels()
    {
        return courriels;
    }

    public void AddFichierActif(string nomFichier, string contenuFichier)
    {
        fichierActif = new FichierActif(nomFichier, contenuFichier);
        contentUpdate.Invoke();
    }

    public void AddSiteInternet(SiteInternet newSite)
    {
        historique.Add(newSite);

        contentUpdate.Invoke();
    }

    public void AddCourriel(Courriel newCourriel)
    {
       
        courriels.Add(newCourriel);

        contentUpdate.Invoke();
    }
}
