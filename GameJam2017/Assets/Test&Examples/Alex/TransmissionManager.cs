using System.Collections;
using System.Collections.Generic;
using CCC.Manager;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TransmissionManager : MonoBehaviour {

    public GameObject transmissionCanvas;
    public Text messageText;
    public float timeOfTransmition;
    private List<string> text = new List<string>();
    private int currentTransmission = 0;

    private float initialY;

    public MusicManager musicManager;

    void Start ()
    {
        initialY = transmissionCanvas.transform.position.y;

        // Voici tous les messages qu'on va envoyer au joueur!

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(2, NouvelAgent));
        
        ScenarioEventManager.AddEvent(new ActionScenarioEvent(100, NouvellePizzeria));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(145, Reminder));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(185, TimHorton));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(210, WarningCinqmin));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(300, RabaisMcDo));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(375, Reminder2));

        ScenarioEventManager.AddEvent(new ActionScenarioEvent(450, Reminder3));

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
        transmissionCanvas.transform.DOLocalMoveY((Screen.height/4) * 0.1f,1);
        DelayManager.CallTo(delegate () 
        {
            musicManager.PlayNotification();
        }, 0.5f);
        messageText.text = text[currentTransmission];
        currentTransmission++;
        DelayManager.CallTo(EndTransmission, timeOfTransmition);
    }

    // Fin de la transmission, on la fait disparaitre
    void EndTransmission()
    {
        transmissionCanvas.transform.DOLocalMoveY(initialY, 1);
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
        CreateTransmission("Attention, nous avons eu comme information qu'une nouvelle pizzeria viens d'ouvrir au coin de la rue!", 0);
    }

    public void NouvelAgent()
    {
        CreateTransmission("Bienvenue dans votre nouvel interface de surveillance agent. Soyez vigilant et gardez l'oeil ouvert!", 0);
    }

    public void WarningCinqmin()
    {
        CreateTransmission("Attention, nous avons eu comme information que le complot se mettra en marche dans approximativement 5 minutes!", 0);
    }

    public void RabaisMcDo()
    {
        CreateTransmission("Nouvelle de dernieres minutes, de nouveaux coupons rabais ont de chez McDo ont été déposé dans la salle des employés. Premier arrivé, premier servis!", 0);
    }

    public void TimHorton()
    {
        CreateTransmission("Information important! Nouvelle saveur de café au Tim Hortons", 0);
    }

    public void Reminder()
    {
        CreateTransmission("N'oubliez pas que vous pouvez écouter la ligne téléphonique lorsqu'un personnage effectue un appel", 0);
    }

    public void Reminder2()
    {
        CreateTransmission("Vous pouvez toujours selectionner une personne pour suivre son deplacement, mais aussi ses conversations de manière fluide", 0);
    }

    public void Reminder3()
    {
        CreateTransmission("N'hésitez pas à fouiller dans les ordinateurs et les cellulaires ainsi que de lire les mémos pour découvrir des informations cruciales à votre enquête", 0);
    }
}
