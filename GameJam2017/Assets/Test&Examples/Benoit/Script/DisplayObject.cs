using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DisplayObject : MonoBehaviour {

    public static DisplayObject instance;

    [System.Serializable]
    public class objectType
    {
        public string objectTypeName;
        public List<string> categoryName = new List<string>();
    }
    public List<objectType> listObjets = new List<objectType>();

    public Personne UIpersonne;
    public Cell UICell;

    private List<GameObject> categoryButton = new List<GameObject>();
    private List<GameObject> textZones = new List<GameObject>();
    
    public GameObject categoryTabButton;
    public GameObject tabLayoutGroup;
    public GameObject contentLayoutGroup;
    public GameObject textZone;

    private int currentObjectType;
    private int currentCategoryTab;
    public Text objetName;

    void Start()
    {
        currentObjectType = 0;
        currentCategoryTab = 0;

        changeObjectType();

        changeTab(currentObjectType);
    }




    public void changeTab(int tab)
    {
        currentCategoryTab = tab;
         
        if (currentObjectType == 0 && tab == 1)         //Call object Cellulaire
        {
            currentObjectType = 3;
            currentCategoryTab = 0;
            changeObjectType();
        }

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
        for (int i = 0; i < nbTextZones; i++)
        {
            GameObject newTextZone = Instantiate(textZone);
            Text newText = newTextZone.GetComponentInChildren<Text>();
            newTextZone.GetComponent<ClickCategoryTab>();
            newTextZone.transform.SetParent(contentLayoutGroup.transform);
            newText.text = listObjets[currentObjectType].categoryName[i];
    
            categoryButton.Add(newTextZone);
        }    
    }


    public void changeObjectType()
    {
        destroyCategoryTab();
        instanciateCategoryTab();
    }

    public void destroyCategoryTab()
    {
        Debug.Log("reste " + categoryButton.Count);
        while (categoryButton.Count > 0)
        {
            Destroy(categoryButton[categoryButton.Count - 1]);
            categoryButton.RemoveAt(categoryButton.Count - 1);
        }
    }

    public void instanciateCategoryTab()
    {
        int nbCategory = listObjets[currentObjectType].categoryName.Count;
        for (int i = 0; i < nbCategory; i++)
        { 
            GameObject newButton = Instantiate(categoryTabButton);
            Text newText = newButton.GetComponentInChildren<Text>();

            newButton.GetComponent<ClickCategoryTab>().numeroButton = i;

            newButton.transform.SetParent(tabLayoutGroup.transform);
            newText.text = listObjets[currentObjectType].categoryName[i];

            ClickCategoryTab newTab = newButton.GetComponent<ClickCategoryTab>();
            newTab.tabClicked.AddListener(changeTab);

            categoryButton.Add(newButton);
           Debug.Log("create " + i);
        }
    }


    
}
