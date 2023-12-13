using System;
using System.Collections;
using System.Collections.Generic;
using _Framework.StateMachine;
using UnityEngine;
using Game.Character.Animation;

public class Character : ObjectColor
{
    [Space(10)] [Header("Property")]
    [SerializeField] private Animator anim;
    [SerializeField] private Transform model;
    [SerializeField] private Transform RightHand;
    
    [HideInInspector] public bool isDead;
    [HideInInspector] public bool isAttack;
    [HideInInspector] public bool isMoving;
    [HideInInspector] public Transform target;

    private string currentAnimName;
    private bool isFoundCharacter;

    private void Start()
    { 
        OnInit();   
    }

    protected void OnInit()
    {
        animInit();
        isDead = false;
        isAttack = false;
        isMoving = false;
    }

    #region Animation
    protected void animInit()
    {
        //currentAnimName = AnimType.IDLE;
    }

    protected void Idle()
    {
        ChangeAnim(AnimType.IDLE);
    }

    protected void Run()
    {
        ChangeAnim(AnimType.RUN);
    }
    
    protected void Win()
    {
        ChangeAnim(AnimType.WIN);
    }
    
    protected void Dance()
    {
        ChangeAnim(AnimType.DANCE);
    }

    protected void Dead()
    {
        ChangeAnim(AnimType.DEAD);
    }

    public void ChangeAnim(string animName)
    {
        if (currentAnimName != animName)
        {
            anim.ResetTrigger(animName);
            currentAnimName = animName;
            if (currentAnimName != null)
                anim.ResetTrigger(currentAnimName);
            anim.SetTrigger(currentAnimName);
        }
    }
    #endregion

    protected virtual void MoveTo(Vector3 direction) { }
    
    
    protected void RotateTo(Vector3 target)
    {
        model.forward = target;
    }

    public void Attack()
    {
        
    }
    
}
