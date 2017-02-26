﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CameraInteraction : MonoBehaviour {

    enum CameraState {fix, following};

    public AudioListener audio;

    public GameObject IUCamera1;
    public GameObject Camera1;
    private CameraState state1 = CameraState.fix;

    public GameObject IUCamera2;
    public GameObject Camera2;
    private CameraState state2 = CameraState.fix;

    public Color selectedColor;
    public Color unSelectedColor;

    public float maxDepX;
    public float minDepX;

    public float maxDepY;
    public float minDepY;


    #region hoveredCamera

    int hoveredCamera;

    public void enter1()
    {
        hoveredCamera = 1;
    }

    public void enter2()
    {
        hoveredCamera = 2;
    }

    public void exit1()
    {
        if(hoveredCamera!=2)
        {
            hoveredCamera = 0;
        }
    }

    public void exit2()
    {
        if(hoveredCamera!=1)
        {
            hoveredCamera = 0;
        }
    }

    #endregion

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
        Debug.Log("Hey");
        selectedCamera = 0;
        
    }

    private void selectCamera1()
    {
        IUCamera1.GetComponent<Image>().color = selectedColor;
        Camera1.GetComponent<AudioListener>().enabled = true;
        audio.enabled = false;
    }

    private void selectCamera2()
    {
        IUCamera2.GetComponent<Image>().color = selectedColor;
        Camera2.GetComponent<AudioListener>().enabled = true;
        audio.enabled = false;
    }

    private void deSelectCamera1()
    {
        IUCamera1.GetComponent<Image>().color = unSelectedColor;
        Camera1.GetComponent<AudioListener>().enabled = false;
        audio.enabled = true;
    }

    private void deSelectCamera2()
    {
        IUCamera2.GetComponent<Image>().color = unSelectedColor;
        Camera2.GetComponent<AudioListener>().enabled = false;
        audio.enabled = true;
    }

    #endregion

    #region MouvementCameras
    private void mouvementCamera()
    {
        if (Input.GetAxis("Vertical") < 0)
        {
            if(selectedCamera == 1 && state1 != CameraState.following && Camera1.transform.position.z > minDepY)
            {
                Camera1.transform.Translate(new Vector3(0, -0.1f, 0));
            }
            else if(selectedCamera == 2 && state2 != CameraState.following && Camera2.transform.position.z > minDepY)
            {
                Camera2.transform.Translate(new Vector3(0, -0.1f, 0));
            }
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            if (selectedCamera == 1 && state1 != CameraState.following && Camera1.transform.position.z < maxDepY)
            {
                Camera1.transform.Translate(new Vector3(0, 0.1f, 0));
            }
            else if (selectedCamera == 2 && state2 != CameraState.following && Camera2.transform.position.z < maxDepY)
            {
                Camera2.transform.Translate(new Vector3(0, 0.1f, 0));
            }
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            if (selectedCamera == 1 && state1 != CameraState.following && Camera1.transform.position.x > minDepX )
            {
                Camera1.transform.Translate(new Vector3(-0.1f, 0, 0));
            }
            else if (selectedCamera == 2 && state2 != CameraState.following && Camera2.transform.position.x > minDepX)
            {
                Camera2.transform.Translate(new Vector3(-0.1f, 0, 0));
            }
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (selectedCamera == 1 && state1 != CameraState.following && Camera1.transform.position.x < maxDepX)
            {
                Camera1.transform.Translate(new Vector3(0.1f, 0, 0));
            }
            else if (selectedCamera == 2 && state2 != CameraState.following && Camera2.transform.position.x < maxDepX)
            {
                Camera2.transform.Translate(new Vector3(0.1f, 0, 0));
            }
        }
    }

    #endregion

    #region ClickOnNPC

    private void OnMouseDown()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            if(hoveredCamera != selectedCamera)
            {
                selectedCamera = hoveredCamera;
            }
            else
            {
                if (selectedCamera == 1)
                {
                    Ray ray = Camera1.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.GetComponent<Personne>() != null)
                        {
                            DisplayObject.instance.GetCharacter(hit.collider.GetComponent<Personne>());
                            Camera1.GetComponent<FollowObject>().follow(hit.collider.transform);
                            state1 = CameraState.following;
                        }
                        else
                        {
                            Camera1.GetComponent<FollowObject>().stopFollow();
                            state1 = CameraState.fix;
                        }
                    }
                }

                if (selectedCamera == 2)
                {
                    Ray ray = Camera2.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.collider.GetComponent<Personne>() != null)
                        {
                            DisplayObject.instance.GetCharacter(hit.collider.GetComponent<Personne>());
                            Camera2.GetComponent<FollowObject>().follow(hit.collider.transform);
                            state2 = CameraState.following;
                        }
                        else
                        {
                            Camera2.GetComponent<FollowObject>().stopFollow();
                            state2 = CameraState.fix;
                        }
                    }
                }
            }
        }
            
    }

    #endregion

    public void Update()
    {
        mouvementCamera();
        OnMouseDown();
    }
}
