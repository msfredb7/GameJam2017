using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class SpriteSpawner : MonoBehaviour {

    public static SpriteSpawner instance;

    public GameObject AnySprite;
    public float positionY;

    // Use this for initialization
    void Start () {
        if (instance == null)
            instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnSprite(Sprite sprite, Vector3 Position, float scale = 1)
    {
        GameObject newSprite = Instantiate(instance.AnySprite);

        newSprite.transform.position = new Vector3(Position.x, positionY, Position.z);
        newSprite.transform.localScale = Vector3.one * scale;
        newSprite.GetComponent<SpriteRenderer>().sprite = sprite;
        newSprite.GetComponent<SpriteRenderer>().DOFade(0, 1).SetDelay(1.99f);
        newSprite.transform.DOMoveZ(newSprite.transform.position.z + 1, 3).OnComplete(delegate()
        {
            Destroy(newSprite);
        });

    }
}
