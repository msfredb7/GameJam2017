using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyAIPath))]
public class Character : MonoBehaviour {


    void Awake()
    {
        pather = GetComponent<MyAIPath>();
    }

    #region Movement

    private MyAIPath pather;

    public void MoveTo(Vector2 position)
    {
        pather.SetTarget(new Vector3(position.x, 0, position.y));
    }

    public void Stop()
    {
        pather.Stop();
    }

    public void LookTarget(Transform target)
    {
        pather.lookTarget = target;
    }

    #endregion
}
