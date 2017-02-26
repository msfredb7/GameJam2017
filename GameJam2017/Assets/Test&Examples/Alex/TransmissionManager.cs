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

        /*
        CreateTransmission("Une nouvelle pizzeria vient d'ouvrir au coin de la rue",2);
        */
        
        CreateTransmission("Attention, nous avons eu comme information que le complot se mettra en marche dans approximativement 1 minutes!", 570);
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(630, EndGame));
    }

    // Creer la transmission pour plus tard
    void CreateTransmission(string text, float time)
    {
        this.text.Add(text);
        DelayManager.CallTo(SendTransmission, time);
    }

    // Envoyer une transmission dans l'ecran
    void SendTransmission()
    {
        transmissionCanvas.SetActive(true);
        messageText.text = text[currentTransmission];
        currentTransmission++;
        DelayManager.CallTo(EndTransmission, timeOfTransmition);
    }

    // Fin de la transmission, on la fait disparaitre
    void EndTransmission()
    {
        transmissionCanvas.SetActive(false);
    }

    public void EndGame()
    {
        //GameManager.EndGame();
    }
}
