using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

public class Bubble : MonoBehaviour {

    private float currentOffsetX;
    private float currentOffsetZ;

    private Character currentChar;

    public GameObject myText;
    public CCC.Utility.RandomAudioCliptList audioclips;

    private float time;

    void Start () {
        GetComponent<AudioSource>().clip = audioclips.Pick();
        GetComponent<AudioSource>().Play();
        Destroy(gameObject, time);
    }
	void Update ()
    {
       transform.position = new Vector3((currentChar.transform.position.x + currentOffsetX), transform.position.y, (currentChar.transform.position.z + currentOffsetZ));
    }

    public void SetValues(float offsetX, float offsetZ, Character currentChar, float time)
    {
        currentOffsetX = offsetX;
        currentOffsetZ = offsetZ;
        this.currentChar = currentChar;
        this.time = time;
    }
}
