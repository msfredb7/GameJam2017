using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CCC.Manager;

public class BulleManager : MonoBehaviour {

    public static BulleManager instance;

    public int lenghtMaxPetiteBulle = 27;
    public int lenghtMaxMoyenneBulle = 60;

    public Bubble petiteBulle;
    public Bubble moyenneBulle;
    public Bubble grosseBulle;

    private Bubble currentBulle;

    public float littleOffsetX = 2.93f;
    public float littleOffsetZ = 4.84f;

    public float moyenOffsetX = 3.74f;
    public float moyenOffsetZ = 6.04f;

    public float bigOffsetX = 5.84f;
    public float bigOffsetZ = 7.63f;

    private float currentOffsetX;
    private float currentOffsetZ;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Say(string text, Character character, float time = 5)
    {
        ChoisirBulle(text);

        Vector3 position = new Vector3((character.transform.position.x + currentOffsetX), currentBulle.transform.position.y, (character.transform.position.z + currentOffsetZ));

        print(currentBulle.transform.position.y);

        Bubble myBubble = Instantiate(currentBulle, position, currentBulle.transform.rotation);

        myBubble.gameObject.SetActive(true);
        myBubble.myText.GetComponent<TextMesh>().text = text;
        myBubble.SetValues(currentOffsetX, currentOffsetZ, character, time);
    }

    private void ChoisirBulle(string text)
    {
        if(text.Length <= lenghtMaxPetiteBulle)
        {
            currentOffsetX = littleOffsetX;
            currentOffsetZ = littleOffsetZ;
            currentBulle = petiteBulle;
        } else if (text.Length <= lenghtMaxMoyenneBulle)
        {
            currentOffsetX = moyenOffsetX;
            currentOffsetZ = moyenOffsetZ;
            currentBulle = moyenneBulle;
        } else
        {
            currentOffsetX = bigOffsetX;
            currentOffsetZ = bigOffsetZ;
            currentBulle = grosseBulle;
        }
    }
}
