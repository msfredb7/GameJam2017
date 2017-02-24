using System.Collections;
using System.Collections.Generic;
using CCC.Manager;
using UnityEngine;
using UnityEngine.UI;

public class TransmissionManager : MonoBehaviour {

    public GameObject transmissionCanvas;
    public Text messageText;
    public float timeOfTransmition;
    private List<string> text = new List<string>();
    private int currentTransmission = 0;

    void Start ()
    {
        // Voici tous les messages qu'on va envoyer au joueur!
        CreateTransmission("Une nouvelle pizzeria vient d'ouvrir au coin de la rue",2);
        CreateTransmission("test2", 8);
        CreateTransmission("test3", 14);
    }

    void SendTransmission()
    {
        transmissionCanvas.SetActive(true);
        messageText.text = text[currentTransmission];
        currentTransmission++;
        DelayManager.CallTo(EndTransmission, timeOfTransmition);
    }

    void EndTransmission()
    {
        transmissionCanvas.SetActive(false);
    }

    void CreateTransmission(string text, float time)
    {
        this.text.Add(text);
        DelayManager.CallTo(SendTransmission, time);
    }
}
