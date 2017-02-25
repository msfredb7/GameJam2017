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

    public Personne UIPersonne;
    public Cell UICell;

    private List<GameObject> categoryButton = new List<GameObject>();
    private List<GameObject> textZones = new List<GameObject>();
    
    public GameObject categoryTabButton;
    public GameObject tabLayoutGroup;
    public GameObject contentLayoutGroup;
    public GameObject textZone;
    public SpriteRenderer charFace;
    public Text topInfo;

    public Sprite Computer;
    public Sprite Door;

    private int currentObjectType;
    private int currentCategoryTab;

    void Start()
    {
        instance = this;
    }


    public void ChangeTab(int tab)
    {
        currentCategoryTab = tab;
        InstanciateTextZones();
    }

    public void InstanciateTextZones()
    {
        DestroyTextZones();

        if (currentObjectType == 0)
        {
            if (currentCategoryTab == 0) DisplayDescription();
            if (currentCategoryTab == 1) DisplayAppel();
            if (currentCategoryTab == 2) DisplaySMS();
        }
        if (currentObjectType == 1)
        {
            if (currentCategoryTab == 0) DisplayHistorique();
            if (currentCategoryTab == 1) DisplayCourriel();
           
        }
        if (currentObjectType == 2)
        {
            if (currentCategoryTab == 0) DisplayAccès();
        }
        PrintTexts();
    }

    public void DisplayDescription()
    {
        texts.Add(UIPersonne.GetNom());
    }


    public List<string> texts = new List<string>();

    public void DisplayAppel()
    {
        List<Call> listAppel = UIPersonne.GetCell().GetHistoriqueAppels();
        for (int i = 0; i < listAppel.Count; i++)
        {
            texts.Add("Date: " + listAppel[i].date + "\nDestinaire: " + listAppel[i].destinataire);
        }
    }

    public void DisplaySMS()
    {
        List<SMS> listSMS = UIPersonne.GetCell().GetHistoriqueTextos();
        for (int i = 0; i < listSMS.Count; i++)
        {
            texts.Add("Date: " + listSMS[i].date + "\nDestinaire: " + listSMS[i].destinataire + "\nContenu: " + listSMS[i].text);
        }
    }
    public void DisplayHistorique()
    {
    }
    public void DisplayCourriel()
    {
    }
    public void DisplayAccès()
    {
    }

    public void PrintTexts()
    {

        int nbtexts = texts.Count;
        for (int i = 0; i < nbtexts; i++)
        {
            GameObject newTextZone = Instantiate(textZone);
            Text newText = newTextZone.GetComponentInChildren<Text>();
            newText.text = texts[i];

            newTextZone.transform.SetParent(contentLayoutGroup.transform);
            textZones.Add(newTextZone);
        }
        texts.Clear();
    }

    public void DestroyTextZones()
    {
        while (textZones.Count > 0)
        {
            Destroy(textZones[textZones.Count - 1]);
            textZones.RemoveAt(textZones.Count - 1);
        }
    }


    public void ChangeObject()
    {
        UpdateHeader();
        DestroyCategoryTab();
        currentCategoryTab = 0;
        InstanciateCategoryTab();
        
    }



    public void UpdateHeader()
    {
        if (currentCategoryTab == 0)
        {
            charFace.sprite = UIPersonne.apparence;         
            topInfo.text = UIPersonne.GetNom();
        }
        if (currentCategoryTab == 1)
        {
            charFace.sprite = Computer;
        }
        if (currentCategoryTab == 2)
        {
            charFace.sprite = Door;
        }
    }

    public void DestroyCategoryTab()
    {
        while (categoryButton.Count > 0)
        {
            Destroy(categoryButton[categoryButton.Count - 1]);
            categoryButton.RemoveAt(categoryButton.Count - 1);
        }
    }

    public void InstanciateCategoryTab()
    {
        DestroyCategoryTab();
        int nbCategory = listObjets[currentObjectType].categoryName.Count;
        for (int i = 0; i < nbCategory; i++)
        { 
            GameObject newButton = Instantiate(categoryTabButton);
            Text newText = newButton.GetComponentInChildren<Text>();

            newButton.GetComponent<ClickCategoryTab>().numeroButton = i;

            newButton.transform.SetParent(tabLayoutGroup.transform);
            newText.text = listObjets[currentObjectType].categoryName[i];

            ClickCategoryTab newTab = newButton.GetComponent<ClickCategoryTab>();
            newTab.tabClicked.AddListener(ChangeTab);

            categoryButton.Add(newButton);
        }

        InstanciateTextZones();
    }

    public void GetCharacter(Personne personne)
    {
        UIPersonne = personne;
        UICell = personne.GetCell();
        currentObjectType = 0;
        currentCategoryTab = 0;

        ChangeObject();
    }


    
}
