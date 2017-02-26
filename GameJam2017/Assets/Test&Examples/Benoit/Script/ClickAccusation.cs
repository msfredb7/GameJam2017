using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ClickAccusation : MonoBehaviour {

    public UnityEvent clickAccusation = new UnityEvent();
 
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(clickButton);
    }

    public void clickButton()
    {
        clickAccusation.Invoke();
    }
}
