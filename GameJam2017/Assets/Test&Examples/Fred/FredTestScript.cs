using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FredTestScript : MonoBehaviour {
    public PasswordWall passwordWallPrefab;
    public Canvas parent;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            PasswordWall pass = Instantiate(passwordWallPrefab.gameObject, parent.transform).GetComponent<PasswordWall>();
            pass.transform.localScale = Vector3.one;
            pass.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
            pass.Init(Prout, "hello");
        }
    }

    void Prout()
    {
        print("prout");
    }
}
