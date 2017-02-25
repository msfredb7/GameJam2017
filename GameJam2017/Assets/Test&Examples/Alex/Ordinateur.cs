using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public struct SiteInternet
{
    public string adresse;
    public string date;
}

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


    public void AddSiteInternet(string adresse, string date, float time = 0)
    {
        SiteInternet newSite = new SiteInternet();
        newSite.date = date;
        newSite.adresse = adresse;
        if (time == 0)
        {
            historique.Add(newSite);

        } else
        {
            DelayManager.CallTo(delegate()
            {
                historique.Add(newSite);
            }, time);
        }
    }

    public void AddCourriel(string destinataire, string text, float time = 0)
    {
        Courriel newCourriel = new Courriel();
        newCourriel.destinataire = destinataire;
        newCourriel.text = text;
        if (time == 0)
        {
            courriels.Add(newCourriel);
        } else
        {
            DelayManager.CallTo(delegate()
            {
                courriels.Add(newCourriel);
            }, time);
        }
    }
}
