using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public Sprite sprite;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void callSpawner()
    {
        SpriteSpawner.instance.SpawnSprite(sprite, new Vector2(10,0), 20);
    }   


}
