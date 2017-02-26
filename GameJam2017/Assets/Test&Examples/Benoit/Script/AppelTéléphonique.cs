using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using CCC.Manager;



public class AppelTéléphonique
{
    public UnityEvent contentUpdate = new UnityEvent();

    private string nomEmetteur;
    private string nomRecepteur;
    
    private List<string> MessageEmetteur;
    private List<string> MessageRecepteur;
    //IMPORTANT-> altérnance 1message/1message entre emetteur recepteur et le recepteur commence TJRS, TJRS, TJRS


    public AppelTéléphonique(string _nomEmetteur, string _nomRecepteur)
    {
        MessageEmetteur = new List<string>();
        MessageRecepteur = new List<string>();
        this.nomEmetteur = _nomEmetteur;
        this.nomRecepteur = _nomRecepteur;
    }

    public string GetNomEmetteur()
    {
        return nomEmetteur;
    }

    public string GetNomRecepteur()
    {
        return nomRecepteur;
    }

    public List<string> GetMessageEmetteur()
    {
        return MessageEmetteur;
    }

    public List<string> GetMessageRecepteur()
    {
        return MessageRecepteur;
    }

    public void AddMessageEmetteur(string message)
    {
        MessageEmetteur.Add(message);

        contentUpdate.Invoke();
    }

    public void AddMessageRecepteur(string message)
    {
        MessageRecepteur.Add(message);

        contentUpdate.Invoke();
    }
}

