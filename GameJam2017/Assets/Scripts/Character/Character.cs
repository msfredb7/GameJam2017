using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CCC.Manager;

[RequireComponent(typeof(MyAIPath))]
public class Character : MonoBehaviour
{
    public enum Direction { Up, Down, Left, Right }
    public Animator animatorFront;
    public Animator animatorBack;
    public Animator animatorRight;
    public Animator animatorLeft;
    public Direction defaultDirection = Direction.Down;
    private Animator currentAnimator;

    private Vector2 speed;
    private Vector2 lastPos;
    private bool walking = false;

    void Awake()
    {
        pather = GetComponent<MyAIPath>();
    }

    public void SetDirectionIn(Direction dir, float time)
    {
        if (time <= 0)
        {
            this.defaultDirection = dir;
        }
        else
            DelayManager.CallTo(delegate ()
            {
                this.defaultDirection = dir;
            }, time);
    }

    void Start()
    {
        animatorLeft.gameObject.SetActive(false);
        animatorBack.gameObject.SetActive(false);
        animatorRight.gameObject.SetActive(false);
        SetSide(Direction.Down);
        //pather.onTargetReached.AddListener(Stop);
    }

    void Update()
    {
        UpdateSpeed();
        UpdateAnim();
    }

    #region Movement

    private MyAIPath pather;

    void UpdateSpeed()
    {
        Vector2 pos = new Vector2(transform.position.x, transform.position.z);

        speed = (pos - lastPos) / Time.deltaTime;

        lastPos = pos;
    }

    public void MoveTo(Vector3 position)
    {
        pather.canMove = true;
        pather.SetTarget(position);
    }

    public void Teleport(Vector3 position)
    {
        pather.canMove = false;
        Vector3 flattenedPos = new Vector3(position.x, 0.5f, position.z);
        transform.position = flattenedPos;
        Stop();
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

    void UpdateAnim()
    {
        if (speed.magnitude > 0.5f)
        {
            float angle = Mathf.Atan(speed.y / speed.x);
            if (speed.x < 0)
                angle += Mathf.PI;

            //print(speed + "     angle: " + angle * Mathf.Rad2Deg);
            angle *= Mathf.Rad2Deg;
            if (angle < -45)
            {
                SetSide(Direction.Down);
            }
            else if (angle < 45)
            {
                SetSide(Direction.Right);
            }
            else if (angle < 135)
            {
                SetSide(Direction.Up);
            }
            else if (angle < 225)
            {
                SetSide(Direction.Left);
            }
            else if (angle < 360)
            {
                SetSide(Direction.Down);
            }
            if (!walking)
                SetWalkingAnim();
        }
        else
        {
            if (walking)
                SetIdleAnim();
            SetSide(defaultDirection);
        }
    }

    void SetWalkingAnim()
    {
        walking = true;
        ApplyAnim();
    }

    void SetIdleAnim()
    {
        walking = false;
        ApplyAnim();
    }

    void ApplyAnim()
    {
        if (currentAnimator != null)
            currentAnimator.SetBool("Walking", walking);
    }

    void SetSide(Direction direction)
    {
        Animator chosenOne = null;
        switch (direction)
        {
            case Direction.Up:
                chosenOne = animatorBack;
                break;
            case Direction.Down:
                chosenOne = animatorFront;
                break;
            case Direction.Left:
                chosenOne = animatorLeft;
                break;
            case Direction.Right:
                chosenOne = animatorRight;
                break;
        }

        if (chosenOne == currentAnimator)
            return;

        if (currentAnimator != null)
            currentAnimator.gameObject.SetActive(false);

        chosenOne.gameObject.SetActive(true);

        currentAnimator = chosenOne;
        ApplyAnim();

    }
}
