using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DisplayObject : MonoBehaviour {

    [System.Serializable]
    public class objectType
    {
        public string objectTypeName;
        public List<string> categoryName = new List<string>();
    }

    public class objectContent
    {
        private string objectName;
        private List<string> categoryContent = new List<string>();
    }


    public List<objectType> listObjets = new List<objectType>();

    private List<GameObject> categoryButton = new List<GameObject>();
    private List<GameObject> textZones = new List<GameObject>();

    public GameObject categoryTabButton;
    public GameObject tabLayoutGroup;
    public GameObject contentLayoutGroup;
    public GameObject textZone;

    public ClickCategoryTab clickCatTab;

    private int currentObjectType;
    public Text objetName;

    void Start()
    {
        clickCatTab.tabClicked.AddListener(changeTab);

        //currentCategory = 0;
        //categoryText.text = categoryName[nbCategory];
    }

    public void changeTab(int tab)
    {
        destrotTextZones();
        instanciateTextZones();
    }

    public void destrotTextZones()
    {
        while (textZones.Count > 0)
        {
            Destroy(textZones[textZones.Count - 1]);
            categoryButton.RemoveAt(textZones.Count - 1);
        }
    }

    public void instanciateTextZones()
    {
        int nbTextZones = listObjets[currentObjectType].categoryName.Count;
        for (int i = 0; i < nbCategory; i++)
        {
            GameObject newButton = Instantiate(categoryTabButton);
            Text newText = newButton.GetComponentInChildren<Text>();
            newButton.GetComponent<ClickCategoryTab>().numeroButton = i;
            newButton.transform.SetParent(tabLayoutGroup.transform);
            newText.text = listObjets[currentObjectType].categoryName[i];

            categoryButton.Add(newButton);
        }
    }


    public void changeObjectType()
    {
        destroyButtons();
        instanciateButtons();
    }

    public void destroyButtons()
    { 
        while (categoryButton.Count > 0)
        {
            Destroy(categoryButton[categoryButton.Count - 1]);
            categoryButton.RemoveAt(categoryButton.Count - 1);
        }
    }

    public void instanciateButtons()
    {
        int nbCategory = listObjets[currentObjectType].categoryName.Count;
        for (int i = 0; i < nbCategory; i++ )
        {
            GameObject newButton = Instantiate(categoryTabButton);
            Text newText = newButton.GetComponentInChildren<Text>();
            newButton.GetComponent<ClickCategoryTab>().numeroButton = i;
            newButton.transform.SetParent(tabLayoutGroup.transform);
            newText.text = listObjets[currentObjectType].categoryName[i];

            categoryButton.Add(newButton);         
        }
    }



    public void clickRight()
    {
     //   if (++nbCategory > categoryName.Count) nbCategory = 0;
       // categoryText.text = categoryName[nbCategory];
    }



}
