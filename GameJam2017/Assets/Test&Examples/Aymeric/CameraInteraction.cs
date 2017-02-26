using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CameraInteraction : Singleton<CameraInteraction> {

    enum CameraState {fix, following};

    public AudioListener audio;

    public GameObject IUCamera1;
    public GameObject Camera1;
    public Image Cam1Border;
    private CameraState state1 = CameraState.fix;

    public GameObject IUCamera2;
    public GameObject Camera2;
    public Image Cam2Border;
    private CameraState state2 = CameraState.fix;

    public Color selectedColor;
    public Color unSelectedColor;

    public float maxDepX;
    public float minDepX;

    public float maxDepY;
    public float minDepY;

    static public Personne GetFocusedTarget(int index)
    {
        Transform follow = null;

        if (index == 0)
            follow = instance.Camera1.GetComponent<FollowObject>().inFollow;
        else
            follow = instance.Camera2.GetComponent<FollowObject>().inFollow;

        if (follow != null && follow.GetComponent<Personne>() != null)
            return follow.GetComponent<Personne>();
        else return null;
    }


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
        Cam1Border.color = selectedColor;
        //IUCamera1.GetComponent<Image>().color = selectedColor;
        Camera1.GetComponent<AudioListener>().enabled = true;
        audio.enabled = false;
    }

    private void selectCamera2()
    {
        Cam2Border.color = selectedColor;
        //IUCamera2.GetComponent<Image>().color = selectedColor;
        Camera2.GetComponent<AudioListener>().enabled = true;
        audio.enabled = false;
    }

    private void deSelectCamera1()
    {
        Cam1Border.color = unSelectedColor;
        //IUCamera1.GetComponent<Image>().color = unSelectedColor;
        Camera1.GetComponent<AudioListener>().enabled = false;
        audio.enabled = true;
    }

    private void deSelectCamera2()
    {
        Cam2Border.color = unSelectedColor;
        //IUCamera2.GetComponent<Image>().color = unSelectedColor;
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

    public static void FocusCharacter(int camIndex, Personne character)
    {
        if(camIndex == 0)
        {
            DisplayObject.instance.GetCharacter(character);
            instance.Camera1.GetComponent<FollowObject>().follow(character.transform);
            instance.state1 = CameraState.following;
        }

        else
        {

            DisplayObject.instance.GetCharacter(character);
            instance.Camera2.GetComponent<FollowObject>().follow(character.transform);
            instance.state2 = CameraState.following;
        }
    }

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
                            FocusCharacter(0, hit.collider.GetComponent<Personne>());
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
                            FocusCharacter(1, hit.collider.GetComponent<Personne>());
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
