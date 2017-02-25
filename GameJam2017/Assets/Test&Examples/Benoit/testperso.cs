using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class testperso : MonoBehaviour {


    public Personne persoContent;

    public List<SMS> listSMS = new List<SMS>();
    public List<Call> listCall = new List<Call>();

    public Cell myCell ;


    void Start()
    {
        myCell = new Cell(listSMS, listCall);
        persoContent.SetPersonne("bob", "AFASFASF ca marche pas", myCell);
    }


    public void sendPerso()
    {
        DisplayObject.instance.GetCharacter(persoContent);
    }


}
