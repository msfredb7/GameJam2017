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

    public MusicManager musicManager;

    void Start ()
    {
        // Voici tous les messages qu'on va envoyer au joueur!
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(0, NouvellePizzeria));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(570, LastMinute));
        
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
        musicManager.PlayNotification();
        messageText.text = text[currentTransmission];
        currentTransmission++;
        DelayManager.CallTo(EndTransmission, timeOfTransmition);
    }

    // Fin de la transmission, on la fait disparaitre
    void EndTransmission()
    {
        transmissionCanvas.SetActive(false);
    }

    public void LastMinute()
    {
        musicManager.PlayLastMinuteSong();
        CreateTransmission("Attention, nous avons eu comme information que le complot se mettra en marche dans approximativement 1 minutes!",0);
    }

    public void EndGame()
    {
        GameManager.EndGame(false);
    }

    public void NouvellePizzeria()
    {
        CreateTransmission("Attention, nous avons eu comme information qu'une nouvelle pizzeria viens d'ouvrir au coin de la cue!", 0);
    }
}
