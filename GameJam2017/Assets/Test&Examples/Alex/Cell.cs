﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public struct Call
{
    public string date;
    public string destinataire;
}

public struct SMS
{
    public string text;
    public string date;
    public string destinataire;
}

public class Cell {

    private List<SMS> historiqueTextos = new List<SMS>();
    private List<Call> historiqueAppels = new List<Call>();

    public Cell(List<SMS> historiqueTextos, List<Call> historiqueAppels)
    {
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
    }

    public void AddCall(string destinataire, string date, float time = 0)
    {
        Call nouveauCall = new Call();
        nouveauCall.destinataire = destinataire;
        nouveauCall.date = date;
        historiqueAppels.Add(nouveauCall);
    }
}