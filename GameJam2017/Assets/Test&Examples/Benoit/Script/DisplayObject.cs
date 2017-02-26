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

    private List<GameObject> categoryButton = new List<GameObject>();
    private List<GameObject> textZones = new List<GameObject>();

    public GameObject categoryTabButton;
    public GameObject tabLayoutGroup;
    public GameObject contentLayoutGroup;
    public GameObject textZone;
    public Image charFace;
    public Text topInfo;

    public Sprite Computer;
    public Sprite Door;
    public Sprite Appel;

    private Personne UIPersonne;
    private Cell UICell;
    private Ordinateur UIOrdinateur;
    private Registre UIRegistre;
    private AppelTéléphonique UIAppelTéléphonique;
    private FichierActif UIFichierActif;

    private int currentObjectType;
    private int currentCategoryTab;

    void Start()
    {
        instance = this;
    }


    public void ChangeTab(int tab)
    {
        if (tab != -1) currentCategoryTab = tab;  
        InstanciateTextZones();
    }

    public void UpdateHeader()
    {

        if (currentObjectType == 0)
        {
            charFace.sprite = UIPersonne.apparence;
            topInfo.text = UIPersonne.GetNom();
        }
        if (currentObjectType == 1)
        {
            charFace.sprite = Computer;
            topInfo.text = UIOrdinateur.GetNomOrdinateur();
        }
        if (currentObjectType == 2)
        {
            charFace.sprite = Door;
            topInfo.text = "fonctionnalité non implanté";
        }
    }

    public void InstanciateTextZones()
    {
        DestroyTextZones();

        if (currentObjectType == 0)
        {
            if (currentCategoryTab == 0) DisplayDescription();
            if (currentCategoryTab == 1) DisplayAppel();      //historique
            if (currentCategoryTab == 2) DisplaySMS();
            if (currentCategoryTab == 3) DisplayAppelTéléphonique();
        }
        if (currentObjectType == 1)
        {
            if (currentCategoryTab == 0) DisplayHistorique();
            if (currentCategoryTab == 1) DisplayCourriel();
            if (currentCategoryTab == 2) DisplayFichierActif();

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

    public void DisplayFichierActif()
    {
        texts.Add("Nom du fichier: " + UIFichierActif.GetNomFichier() + "\n\n" + UIFichierActif.GetContenuFicher());
    }

    public void DisplayHistorique()
    {
        List<SiteInternet> listSites = UIOrdinateur.GetHistorique();
        for (int i = 0; i < listSites.Count; i++)
        {
            texts.Add("Adresse: " + listSites[i].adresse + "\nContenu: " + listSites[i].date);
        }
    }

    public void DisplayCourriel()
    {
        List<Courriel> listcourriel = UIOrdinateur.GetCourriels();
        for (int i = 0; i < listcourriel.Count; i++)
        {
            texts.Add("Destinataire: " + listcourriel[i].destinataire + "\nContenu: " + listcourriel[i].text);
        }
    }

    public void DisplayAccès()
    {
        List<Entry> listRegistre = UIRegistre.GetEntries();
        for (int i = 0; i < listRegistre.Count; i++)
        {
            texts.Add("Passage de: " + listRegistre[i].name + "\nHeure: " + listRegistre[i].hour);
        }
    }

    public void DisplayAppelTéléphonique()
    {
        List<string> messageEmetteur = UIAppelTéléphonique.GetMessageEmetteur();
        List<string> messageRecepteur = UIAppelTéléphonique.GetMessageRecepteur();
        string nomEmetteur = UIAppelTéléphonique.GetNomEmetteur();
        string nomRecepteur = UIAppelTéléphonique.GetNomRecepteur();

        for (int i = 0; i < messageRecepteur.Count; i++)
        {
            texts.Add(nomRecepteur + ": \n" + nomRecepteur[i]);
            if (i < messageEmetteur.Count)
            {
                texts.Add(nomEmetteur + ": \n" + messageEmetteur[i]);
            }
        }
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

    public void DisableListener()
    {
        if (currentObjectType == 0)
        {
            UICell.contentUpdate.RemoveAllListeners();
            UIAppelTéléphonique.contentUpdate.RemoveAllListeners();
        }
        if (currentObjectType == 1)
        {
            UIOrdinateur.contentUpdate.RemoveAllListeners();
            UIFichierActif.contentUpdate.RemoveAllListeners();
        }
        if (currentObjectType == 2)
        {
            UIRegistre.contentUpdate.RemoveAllListeners();
        }
    }

    public void ActivateListener()
    {

        if (currentObjectType == 0)
        {
            if (UICell != null) UICell.contentUpdate.AddListener(newContent);
            if (UIAppelTéléphonique != null) UIAppelTéléphonique.contentUpdate.AddListener(newContent);
        }
        if (currentObjectType == 1)
        {
            if (UIOrdinateur != null) UIOrdinateur.contentUpdate.AddListener(newContent);
            if (UIFichierActif != null) UIFichierActif.contentUpdate.AddListener(newContent);
        }
        if (currentObjectType == 2)
        {
            if (UIOrdinateur != null) UIRegistre.contentUpdate.AddListener(newContent);
        }
    }

    public void newContent()
    {
        int previousTab = currentCategoryTab; //Change object met le tab à cuurentCatTab à 0
        ChangeObject();
        ChangeTab(previousTab);
    }

    public void ChangeObject()
    {
        if (currentObjectType == 0)  UIAppelTéléphonique = UICell.GetCurrentCall();  
        if (currentObjectType == 1)  UIFichierActif = UIOrdinateur.GetFichierActif();

        UpdateHeader();
        DestroyCategoryTab();
        currentCategoryTab = 0;
        InstanciateCategoryTab();

        ActivateListener(); 
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
            if (currentObjectType == 1 && i == 2 && UIFichierActif == null) { }             //skip fichier actif si null
            else if (currentObjectType == 0 && i == 2 && UIAppelTéléphonique == null) { }   //skip appel courant si null
            else
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
        }

        InstanciateTextZones();
    }

    public void GetCharacter(Personne personne)
    {
        DisableListener();

        UIPersonne = personne;
        UICell = personne.GetCell();
        UIAppelTéléphonique = UICell.GetCurrentCall();
        currentObjectType = 0;
        currentCategoryTab = 0;

        ChangeObject();
    }

    public void GetComputer(Ordinateur ordinateur)
    {
        DisableListener();

        UIOrdinateur = ordinateur;
        UIFichierActif = ordinateur.GetFichierActif();
        currentObjectType = 1;
        currentCategoryTab = 0;

        ChangeObject();
    }

    public void GetRegister(Registre registre)
    {
        DisableListener();

        UIRegistre = registre;
        currentObjectType = 2;
        currentCategoryTab = 0;
  
        ChangeObject();
    }
}
