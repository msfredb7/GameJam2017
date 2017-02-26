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
}

[System.Serializable]
public struct Courriel
{
    public string destinataire;
    public string text;
}

public class Ordinateur : MonoBehaviour {
    public UnityEvent contentUpdate = new UnityEvent();

    private string nomOrdinateur;
    private List<SiteInternet> historique = new List<SiteInternet>();
    private List<Courriel> courriels = new List<Courriel>();

    private FichierActif fichierActif;


    public Ordinateur(string nomOrdinateur, List<SiteInternet> historique, List<Courriel> courriels)
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
    }

    public void AddSiteInternet(string adresse, string date)
    {
        SiteInternet newSite = new SiteInternet();
        newSite.date = date;
        newSite.adresse = adresse;
        historique.Add(newSite);

        contentUpdate.Invoke();
    }

    public void AddCourriel(string destinataire, string text)
    {
        Courriel newCourriel = new Courriel();
        newCourriel.destinataire = destinataire;
        newCourriel.text = text;
        courriels.Add(newCourriel);

        contentUpdate.Invoke();
    }
}
