using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulleManager : Singleton<BulleManager> {

    public int lenghtMaxPetiteBulle = 27;
    public int lenghtMaxMoyenneBulle = 60;

    public GameObject petiteBulle;
    public Text petiteBulleText;
    public GameObject moyenneBulle;
    public Text moyenneBulleText;
    public GameObject grosseBulle;
    public Text grosseBulleText;

    public GameObject currentBulle;
    public Text currentText;

    public void Say(string text, )
    {
        ChoisirBulle(text);
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
