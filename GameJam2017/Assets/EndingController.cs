using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EndingController : MonoBehaviour {

    public Image fadeImage;

	// Use this for initialization
	void Start () {
        fadeImage.DOFade(0,2);
	}
}
