using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testRegis : MonoBehaviour {

    public Registre registre;

    public List<Entry> listEntré = new List<Entry>();


    void Start()
    {
        registre = new Registre(listEntré);
    }


    public void sendPerso()
    {
        DisplayObject.instance.GetRegister(registre);
    }

}
