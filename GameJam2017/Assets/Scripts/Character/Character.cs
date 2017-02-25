using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyAIPath))]
public class Character : MonoBehaviour {

    public Animator animatorFront;
    public Animator animatorBack;
    public Animator animatorRight;
    public Animator animatorLeft; 

    void Awake()
    {
        pather = GetComponent<MyAIPath>();
    }

    #region Movement

    private MyAIPath pather;

    public void MoveTo(Vector2 position)
    {
        pather.SetTarget(new Vector3(position.x, 0, position.y));
        //animator.SetBool("Walking", true);
        pather.onTargetReached.AddListener(Stop);
    }

    public void Stop()
    {
        pather.Stop();
        //animator.SetBool("Walking", false);
    }

    public void LookTarget(Transform target)
    {
        pather.lookTarget = target;
    }

    #endregion
}
