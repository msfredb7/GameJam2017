using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FichierActif {

    private string nomFichier;
    private string contenuFichier;

    public FichierActif(string _nomFichier, string _contenuFichier)
    {
        this.nomFichier = _nomFichier;
        this.contenuFichier = _contenuFichier;              //non modifiable
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
