using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class IntroController : MonoBehaviour {

    [Header("Document")]
    public Image frontFade;
    public Button backFade;

    int stage = 0;

    void Start ()
    {
        backFade.onClick.AddListener(OnBackFadeClick);
        Stage0();
	}

    void OnBackFadeClick()
    {
        if(stage == 0)
        {
            Stage1();
        }
    }

    //Brefing
    void Stage0()
    {
        print("stage 0");
        frontFade.gameObject.SetActive(true);
        frontFade.DOFade(0, 1.5f);
    }

    //Suspects
    void Stage1()
    {
        print("stage 1");
    }

    //Plan
    void Stage2()
    {
        print("stage 2");
    }

    //Reunion
    void Stage3()
    {
        print("stage 3");
    }

}
