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
    public Bubble callBulle;

    private Bubble currentBulle;

    public float littleOffsetX = 2.93f;
    public float littleOffsetZ = 4.84f;

    public float moyenOffsetX = 3.74f;
    public float moyenOffsetZ = 6.04f;

    public float bigOffsetX = 5.84f;
    public float bigOffsetZ = 7.63f;

    public float callOffsetX = 0.98f;
    public float callOffsetZ = 1.06f;

    private float currentOffsetX;
    private float currentOffsetZ;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void Say(string text, Character character, float time = 5, float delay = 0)
    {
        if(delay > 0)
        {
            DelayManager.CallTo(delegate ()
            {
                Say(text, character, time, 0);
            }, delay);
            return;
        }

        MoveCamera(character);

        ChoisirBulle(text);

        Vector3 position = new Vector3((character.transform.position.x + currentOffsetX), currentBulle.transform.position.y, (character.transform.position.z + currentOffsetZ));
        
        Bubble myBubble = Instantiate(currentBulle, position, currentBulle.transform.rotation);

        myBubble.gameObject.SetActive(true);
        myBubble.myText.GetComponent<TextMesh>().text = text;
        myBubble.SetValues(currentOffsetX, currentOffsetZ, character, time);
    }

    private void MoveCamera(Character character)
    {
        if (!CameraInteraction.InstaceNotNull())
            return;
        Personne tar1 = CameraInteraction.GetFocusedTarget(0);
        Personne tar2 = CameraInteraction.GetFocusedTarget(1);
        if (tar1 != null && tar1.focus == character)
            CameraInteraction.FocusCharacter(0, (Personne)character);
        if (tar2 != null && tar2.focus == character)
            CameraInteraction.FocusCharacter(1, (Personne)character);
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

    public void StartCall(Character character, float time)
    {
        currentBulle = callBulle;

        Vector3 position = new Vector3((character.transform.position.x + currentOffsetX), currentBulle.transform.position.y, (character.transform.position.z + currentOffsetZ));

        Bubble myBubble = Instantiate(currentBulle, position, currentBulle.transform.rotation);

        myBubble.SetValues(callOffsetX,callOffsetZ,character,time);
    }
}
