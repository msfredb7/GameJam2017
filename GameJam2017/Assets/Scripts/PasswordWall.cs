using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PasswordWall : MonoBehaviour {

    public InputField field;
    public Text wrongText;

    private UnityAction callback;
    private string password;
    
    void Start()
    {
        wrongText.gameObject.SetActive(false);
    }

    public void Init(UnityAction callback, string password)
    {
        this.callback = callback;
        this.password = password;
    }

    public void Close()
    {
        Destroy(gameObject);
    }

    public void Submit()
    {
        if(field.text == password)
        {
            if (callback != null)
                callback();
            Close();
        }
        else
        {
            wrongText.gameObject.SetActive(true);
        }
    }
}
