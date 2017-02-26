using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using CCC.Manager;

public class IntroController : MonoBehaviour {

    [Header("Document")]
    public Image frontFade;
    public Button backFade;
    public Button continueButton;
    public GameObject document;
    public GameObject content;
    public AudioClip introClip;

    [Header("World")]
    public Camera cam;
    public ScenarioEventManager eventMan;

    int stage = 0;
    private bool canGoToStage1 = false;

    void Start ()
    {
        MasterManager.Sync(LaunchMusic);
        backFade.onClick.AddListener(OnBackFadeClick);
        continueButton.onClick.AddListener(OnContinueClick);
        Stage0();
	}

    void LaunchMusic()
    {
        SoundManager.PlayMusic(introClip);
    }

    void OnFadeInComplete()
    {
        canGoToStage1 = true;
    }

    void OnBackFadeClick()
    {
        if (!canGoToStage1)
            return;

        if(stage == 0)
        {
            Stage1();
        }
    }
    void OnContinueClick()
    {
        if (stage == 1)
        {
            Stage2();
        }
    }

    //Brefing
    void Stage0()
    {
        stage = 0;
        print("stage 0");
        frontFade.gameObject.SetActive(true);
        frontFade.DOFade(0, 4f).SetEase(Ease.Linear).OnComplete(OnFadeInComplete);
    }

    //Suspects
    void Stage1()
    {
        stage = 1;
        document.SetActive(true);
        print("stage 1");
    }

    //Plan
    void Stage2()
    {
        stage = 2;
        print("stage 2");
        frontFade.DOFade(1, 0.75f).OnComplete(delegate()
        {
            content.SetActive(false);
            backFade.gameObject.SetActive(false);
            frontFade.DOFade(0, 0.75f);
            cam.DOOrthoSize(8, 5).SetEase(Ease.InOutSine);
            cam.transform.DOMoveZ(8.5f, 5).SetEase(Ease.InOutSine).OnComplete(delegate()
            {
                eventMan.enabled = true;
                eventMan.ClearAll();

                BulleManager.instance.Say("Salut la gang!", ScenarioManager.instance.Enrique, 2);
                BulleManager.instance.Say("J’vais d’abord prendre \nquelques secondes pour \nféliciter Annoushka pour \navoir choisi la meilleure \nbusiness pour son stage \ninternational.", ScenarioManager.instance.Enrique, 6, 2);
                BulleManager.instance.Say("Elle arrive de la Russie \net travaillera avec nous \npour les 3 prochains mois.", ScenarioManager.instance.Enrique, 4, 8);

                float delay = 12;

                BulleManager.instance.Say("Merci ...\nmoi contente, \nde rencontrer tu.", ScenarioManager.instance.Annushka, 3, delay);

                delay += 3;


                BulleManager.instance.Say("Comme vous le savez,\nc’est la dernière journée\n de Justine aujourd’hui.", ScenarioManager.instance.Enrique, 4, delay);
                BulleManager.instance.Say("Mais avant qu’elle parte,\nelle doit autoriser un\npartenariat qui changera\nà tout jamais l’avenir\nde notre compagnie!", ScenarioManager.instance.Enrique, 5, delay + 4);
                BulleManager.instance.Say("J’vous dit pas le nom de \nl’autre compagnie tout’suite,\nc’est une surprise !", ScenarioManager.instance.Enrique, 4, delay + 9);

                delay += 4 + 5 + 4;

                BulleManager.instance.Say("*Rires*\nMoi j’aime ça\nles surprises\n*Rires*", ScenarioManager.instance.Samantha, 3, delay);

                delay += 3;
                
                BulleManager.instance.Say("Ok ouain… Je laisse\nle planning de la\njournée sur la table.", ScenarioManager.instance.Enrique, 3, delay);
                BulleManager.instance.Say("Get to work\nboys and grills!", ScenarioManager.instance.Enrique, 2, delay+3);

                delay += 3 + 2;

                DelayManager.CallTo(Stage3, delay);

            });
        });
    }

    //Sortie
    void Stage3()
    {
        stage = 3;
        print("stage 3");

        frontFade.DOFade(1, 1).OnComplete(LaunchMainScene);
    }

    void LaunchMainScene()
    {
        Scenes.Load("Controls");
    }

}
