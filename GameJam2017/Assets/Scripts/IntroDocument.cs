using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CCC.Manager;

public class IntroDocument : MonoBehaviour {

    public Personne[] personnes;
    public Image portrait;
    public Text nom;
    public Text description;
    public Button leftButton;
    public Button rightButton;
    public Button continueButton;
    public bool canContinue = false;
    public AudioClip pageFlip;

    private int currentIndex;

    void Start()
    {
        continueButton.gameObject.SetActive(false);
        Display(personnes[0]);
        leftButton.interactable = false;
        leftButton.onClick.AddListener(OnLeftClick);
        rightButton.onClick.AddListener(OnRightClick);
    }

    void OnRightClick()
    {
        if (currentIndex < personnes.Length - 1)
            currentIndex++;

        if (currentIndex == personnes.Length - 1)
        {
            rightButton.interactable = false;
            continueButton.gameObject.SetActive(true);
        }
        leftButton.interactable = true;

        Display(personnes[currentIndex]);
        SoundManager.Play(pageFlip);
    }

    void OnLeftClick()
    {
        if (currentIndex > 0)
            currentIndex--;

        if (currentIndex == 0)
        {
            leftButton.interactable = false;
        }
        rightButton.interactable = true;

        Display(personnes[currentIndex]);
        SoundManager.Play(pageFlip);
    }

    public void Display(Personne personne)
    {
        portrait.sprite = personne.apparence;
        nom.text = personne.GetNom();
        description.text = personne.GetDescription().Replace('$', '\n');
    }
}
