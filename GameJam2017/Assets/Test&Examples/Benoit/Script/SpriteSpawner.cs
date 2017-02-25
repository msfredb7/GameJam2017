using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    public void SpawnSprite(Sprite sprite, Vector2 Position, float scale = 1)
    {
        GameObject newSprite = Instantiate(instance.AnySprite);

        newSprite.transform.position = new Vector3(Position.x, 10, Position.y);
        newSprite.transform.localScale = Vector3.one * scale;
        newSprite.GetComponent<SpriteRenderer>().sprite = sprite; 

        Destroy(newSprite, 3);
    }
}
