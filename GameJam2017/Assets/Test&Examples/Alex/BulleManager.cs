using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CCC.Manager;

public class BulleManager : MonoBehaviour {

    public static BulleManager instance;

    public int lenghtMaxPetiteBulle = 27;
    public int lenghtMaxMoyenneBulle = 60;

    public GameObject petiteBulle;
    public GameObject petiteBulleText;
    public GameObject moyenneBulle;
    public GameObject moyenneBulleText;
    public GameObject grosseBulle;
    public GameObject grosseBulleText;

    private GameObject currentBulle;
    private GameObject currentText;

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

        Transform bullePosition = currentBulle.transform;

        bullePosition.position = new Vector3((character.transform.position.x + currentOffsetX), character.transform.position.y, (character.transform.position.z + currentOffsetZ));

        currentBulle.SetActive(true);
        currentText.GetComponent<TextMesh>().text = text;
        DelayManager.CallTo(EraseBulle, time);
    }

    private void EraseBulle()
    {
        currentBulle.SetActive(false);
    }

    private void ChoisirBulle(string text)
    {
        if(text.Length <= lenghtMaxPetiteBulle)
        {
            currentOffsetX = littleOffsetX;
            currentOffsetZ = littleOffsetZ;
            currentBulle = petiteBulle;
            currentText = petiteBulleText;
        } else if (text.Length <= lenghtMaxMoyenneBulle)
        {
            currentOffsetX = moyenOffsetX;
            currentOffsetZ = moyenOffsetZ;
            currentBulle = moyenneBulle;
            currentText = moyenneBulleText;
        } else
        {
            currentOffsetX = bigOffsetX;
            currentOffsetZ = bigOffsetZ;
            currentBulle = grosseBulle;
            currentText = grosseBulleText;
        }
    }
}
