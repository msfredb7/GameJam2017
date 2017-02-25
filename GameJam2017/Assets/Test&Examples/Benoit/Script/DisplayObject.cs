using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        public string objectName;
        public List<List<string>> categoryContent = new List<List<string>>();
    }


    public List<objectType> listObjets = new List<objectType>();
    private List<GameObject> categoryButton = new List<GameObject>();
    private List<Text> categoryText = new List<Text>();

    public GameObject categoryTabButton;
    public GameObject tabLayoutGroup;
    public GameObject contentLayoutGroup;

    private int currentObjectType;

    public Text objetName;
    void Start()
    {
        //currentCategory = 0;
        //categoryText.text = categoryName[nbCategory];
    }

    public void changeObjectType()
    {
        destroyOldButtons();
        instanciateNewButtons();
    }

    public void destroyOldButtons()
    { 
        while (categoryButton.Count > 0)
        {
            Destroy(categoryButton[categoryButton.Count - 1]);
            categoryButton.RemoveAt(categoryButton.Count - 1);
        }
    }

    public void instanciateNewButtons()
    {
        int nbCategory = listObjets[currentObjectType].categoryName.Count;
        for (int i = 0; i < nbCategory; i++ )
        {
            GameObject newButton = Instantiate(categoryTabButton);
            Text newText = newButton.GetComponentInChildren<Text>();

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
