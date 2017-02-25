using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    private List<SiteInternet> historique = new List<SiteInternet>();
    private List<Courriel> courriels = new List<Courriel>();

	public Ordinateur(List<SiteInternet> historique, List<Courriel> courriels)
    {
        this.historique = historique;
        this.courriels = courriels;
    }

    public List<SiteInternet> GetHistorique()
    {
        return historique;
    }

    public List<Courriel> GetCourriels()
    {
        return courriels;
    }

    public void AddSiteInternet(string adresse, string date)
    {
        SiteInternet newSite = new SiteInternet();
        newSite.date = date;
        newSite.adresse = adresse;
        historique.Add(newSite);
    }

    public void AddCourriel(string destinataire, string text)
    {
        Courriel newCourriel = new Courriel();
        newCourriel.destinataire = destinataire;
        newCourriel.text = text;
        courriels.Add(newCourriel);
    }
}
