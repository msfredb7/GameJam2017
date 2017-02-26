using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class FichierActif {
    public UnityEvent contentUpdate = new UnityEvent();

    private string nomFichier;
    private string contenuFichier;

    public FichierActif(string _nomFichier, string _contenuFichier)
    {
        this.nomFichier = _nomFichier;
        this.contenuFichier = _contenuFichier;              //non modifiable
        contentUpdate.Invoke();
    }

    public string GetNomFichier()
    {
        return nomFichier;
    }

    public string GetContenuFicher()
    {
        return contenuFichier;
    }
}
