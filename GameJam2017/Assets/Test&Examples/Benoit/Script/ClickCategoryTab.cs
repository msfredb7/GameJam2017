using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCategoryTab : MonoBehaviour {

    public class clickOnCategoryTab : UnityEvent<int> { };
    public int numeroButton;
    public clickOnCategoryTab tabClicked = new clickOnCategoryTab();
   

    void Start () {
        GetComponent<Button>().onClick.AddListener(clickButton);         
    }
	
    public void clickButton()
    {
        tabClicked.Invoke(numeroButton);
    }
}
