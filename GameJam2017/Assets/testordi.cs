using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testordi : MonoBehaviour {

    public Ordinateur ordiContent;

    public List<SiteInternet> listSites = new List<SiteInternet>();
    public List<Courriel> listCourriel = new List<Courriel>();
    

    void Start()
    {
        ordiContent = new Ordinateur(listSites, listCourriel);
    }


    public void sendPerso()
    {
        DisplayObject.instance.GetComputer(ordiContent);
    }

}
