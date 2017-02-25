using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraInteraction : MonoBehaviour {

    public GameObject IUCamera1;
    public GameObject Camera1;

    public GameObject IUCamera2;
    public GameObject Camera2;

    public Color selectedColor;
    public Color unSelectedColor;


    #region SelectionCamera
    //La camera actuellement séléctioné
    private int _selectedCamera = 0;

    public int selectedCamera
    {
        get
        {
            return _selectedCamera;
        }
        set
        {
            if(value != _selectedCamera)
            {
                if(_selectedCamera == 1)
                {
                    deSelectCamera1();
                }
                else if(_selectedCamera ==2)
                {
                    deSelectCamera2();
                }

                _selectedCamera = value;

                if(_selectedCamera == 1)
                {
                    selectCamera1();
                }
                else if(_selectedCamera == 2)
                {
                    selectCamera2();
                }
            }
        }
    }

    public void OnClickCamera1()
    {
        selectedCamera = 1;
    }

    public void OnClickCamera2()
    {
        selectedCamera = 2;
    }

    public void OnClickOutCamera()
    {
        selectedCamera = 0;
    }

    private void selectCamera1()
    {
        Debug.Log("Camera1Selected");
        IUCamera1.GetComponent<Image>().color = selectedColor;
    }

    private void selectCamera2()
    {
        Debug.Log("Camera2Selected");
        IUCamera2.GetComponent<Image>().color = selectedColor;
    }

    private void deSelectCamera1()
    {
        Debug.Log("Camera1DeSelected");
        IUCamera1.GetComponent<Image>().color = unSelectedColor;
    }

    private void deSelectCamera2()
    {
        Debug.Log("Camera2DeSelected");
        IUCamera2.GetComponent<Image>().color = unSelectedColor;
    }

    #endregion


    #region MouvementCameras
    private void mouvementCamera()
    {
        if (Input.GetAxis("Vertical") < 0)
        {
            if(selectedCamera == 1)
            {
                Camera1.transform.Translate(new Vector3(0, -0.1f, 0));
            }
            else if(selectedCamera == 2)
            {
                Camera2.transform.Translate(new Vector3(0, -0.1f, 0));
            }
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            if (selectedCamera == 1)
            {
                Camera1.transform.Translate(new Vector3(0, 0.1f, 0));
            }
            else if (selectedCamera == 2)
            {
                Camera2.transform.Translate(new Vector3(0, 0.1f, 0));
            }
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            if (selectedCamera == 1)
            {
                Camera1.transform.Translate(new Vector3(-0.1f, 0, 0));
            }
            else if (selectedCamera == 2)
            {
                Camera2.transform.Translate(new Vector3(-0.1f, 0, 0));
            }
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (selectedCamera == 1)
            {
                Camera1.transform.Translate(new Vector3(0.1f, 0, 0));
            }
            else if (selectedCamera == 2)
            {
                Camera2.transform.Translate(new Vector3(0.1f, 0, 0));
            }
        }
    }
        
    #endregion

    public void Update()
    {
        mouvementCamera();
    }
}
