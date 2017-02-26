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
    
    public List<string> Message;
    public List<string> Parleur;
    //IMPORTANT-> altérnance 1message/1message entre emetteur recepteur et le recepteur commence TJRS, TJRS, TJRS


    public AppelTéléphonique(string _nomEmetteur, string _nomRecepteur)
    {
        Message = new List<string>();
        Parleur = new List<string>();
        this.nomEmetteur = _nomEmetteur;
        this.nomRecepteur = _nomRecepteur;
    }

    public void AddMessage(string mIn,string pIn)
    {
        Message.Add(mIn);
        Parleur.Add(pIn);
        contentUpdate.Invoke();
    }
}

