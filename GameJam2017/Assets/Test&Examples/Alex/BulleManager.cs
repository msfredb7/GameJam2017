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
    public Text petiteBulleText;
    public GameObject moyenneBulle;
    public Text moyenneBulleText;
    public GameObject grosseBulle;
    public Text grosseBulleText;

    private GameObject currentBulle;
    private Text currentText;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Say(string text, Character character, float time = 5)
    {
        float offsetX = 33;
        float offsetY = 36;

        ChoisirBulle(text);

        Transform bullePosition = currentBulle.transform;
    
        bullePosition.position = new Vector3(character.transform.position.x + offsetX, character.transform.position.y + offsetY, character.transform.position.z);
        currentBulle.SetActive(true);
        currentText.text = text;
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
            currentBulle = petiteBulle;
            currentText = petiteBulleText;
        } else if (text.Length <= lenghtMaxMoyenneBulle)
        {
            currentBulle = moyenneBulle;
            currentText = moyenneBulleText;
        } else
        {
            currentBulle = grosseBulle;
            currentText = grosseBulleText;
        }
    }
}
