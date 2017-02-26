using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PasswordWallSpawner : Singleton<PasswordWallSpawner> {

    public PasswordWall prefab;
    public RectTransform container;

    public static PasswordWall LaunchPasswordWall(UnityAction callback, string password)
    {
        if (instance == null)
            return null;

        PasswordWall pass = Instantiate(instance.prefab.gameObject, instance.container.transform).GetComponent<PasswordWall>();
        pass.transform.localScale = Vector3.one;
        pass.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
        pass.Init(callback, password);

        return pass;
    }
}
