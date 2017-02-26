using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using CCC.Manager;

[System.Serializable]
public struct Call
{
    public string date;
    public string destinataire;
}

[System.Serializable]
public struct SMS
{
    public string text;
    public string date;
    public string destinataire;
}

public class Cell {
    public UnityEvent contentUpdate = new UnityEvent();

    private List<SMS> historiqueTextos = new List<SMS>();
    private List<Call> historiqueAppels = new List<Call>();

    private AppelTéléphonique myCall;

    public Cell()
    {
        myCall = null;
    }

    public Cell(List<SMS> historiqueTextos, List<Call> historiqueAppels)
    {
        myCall = null;
        this.historiqueAppels = historiqueAppels;
        this.historiqueTextos = historiqueTextos;
    }
	
    public List<Call> GetHistoriqueAppels()
    {
        return historiqueAppels;
    }

    public List<SMS> GetHistoriqueTextos()
    {
        return historiqueTextos;
    }

    public void AddTexto(string text, string date, string destinataire, float time = 0)
    {
        SMS nouveauSMS = new SMS();
        nouveauSMS.text = text;
        nouveauSMS.date = date;
        nouveauSMS.destinataire = destinataire;
        historiqueTextos.Add(nouveauSMS);

        contentUpdate.Invoke();
    }

    public void AddCall(string destinataire, string date, float time = 0)
    {
        Call nouveauCall = new Call();
        nouveauCall.destinataire = destinataire;
        nouveauCall.date = date;
        historiqueAppels.Add(nouveauCall);

        contentUpdate.Invoke();
    }

    public void SetMyCall(AppelTéléphonique myCall)
    {
        this.myCall = myCall;
        contentUpdate.Invoke();
    }

    public AppelTéléphonique GetCurrentCall()
    {
        return myCall;
    }

    public void SayInTelephone(string messageIn, string parleurIn, float delay = 0)
    {
        if (delay == 0)
        {
            myCall.AddMessage(messageIn, parleurIn);
        } else
        {
            AppelTéléphonique tempCall = myCall;
            DelayManager.CallTo(delegate ()
            {
                tempCall.AddMessage(messageIn, parleurIn);
            }, delay);
        }
    }

    public void EndCall(float delay)
    {
        if (delay == 0)
        {
            myCall = null;
        }
        else
        {
            DelayManager.CallTo(delegate ()
            {
                myCall = null;
            }, delay);
        }
    }
}
