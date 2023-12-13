using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using _Game.Camera;
using UnityEngine;

public class Player : Character
{
    public StateMachine<Player> currentState;
    
    [Header("---------------Player Property---------------")]
    [SerializeField] private FloatingJoystick joystick;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private float moveSpeed;
    
    private Vector3 moveVector3;
    private float horizontal;
    private float vertical;

    #region State
    public IdleState IdleState { get; private set; }
    public RunState RunState { get; private set; }
    public AttackState AttackState { get; private set; }
    public DeadState DeadState { get; private set; }
    #endregion
    
    private void Awake()
    {
        base.Awake();
        OnInit();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        currentState.UpdateState();
    }

    void OnInit()
    {
        base.OnInit();
        InitJoystick();
        InitCamera();
        InitState();
    }
    
    private void InitState()
    {
        IdleState = new IdleState();
        RunState = new RunState();
        AttackState = new AttackState();
        DeadState = new DeadState();
        
        currentState = new StateMachine<Player>();
        currentState.SetCharacter(this);
        currentState.ChangeState(IdleState);
    }
    
    private void InitJoystick()
    {
        if (joystick == null)
        {
            joystick = FindObjectOfType<FloatingJoystick>();
        }
    }

    private void InitCamera()
    {
        CameraFollow cameraFollow = FindObjectOfType<CameraFollow>();
        if (cameraFollow != null)
        {
            cameraFollow.SetTarget(TF);
        }
    }

    private void GetInput()
    {
        if (joystick == null)
            return;
        horizontal = joystick.Horizontal;
        vertical = joystick.Vertical;
    }

    public bool checkMove()
    {
        GetInput();
        if (Math.Abs(horizontal) > 0.1f || Math.Abs(vertical) > 0.1f)
        {
            isMoving = true;
            return true;
        }

        return false;
    }

    public void Move()
    {
        GetInput();
        if (isDead)
        {
            return;
        }
        if (Math.Abs(horizontal) > 0.1f || Math.Abs(vertical) > 0.1f)
        {
            Vector3 direction = new Vector3(horizontal, 0, vertical);
            MoveTo(direction);
            RotateTo(direction);
            // Quaternion targetRotation = Quaternion.LookRotation(direction);
            // TF.rotation = Quaternion.Lerp(TF.rotation, targetRotation, 15 * Time.deltaTime);
        }
    }
    
    protected override void MoveTo(Vector3 direction)
    {
        characterController.Move(direction * moveSpeed * Time.deltaTime);
    }


}
