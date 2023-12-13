using System.Collections;
using System.Collections.Generic;
using _Framework.StateMachine;
using Game.Character.Animation;
using UnityEngine;

public class EPatrolState : IState<Enemy>
{
    public void OnEnter(Enemy t)
    {
        t.ChangeAnim(AnimType.RUN);
        t.isMoving = true;
    }

    public void OnExecute(Enemy t)
    {
        t.MoveTo(new Vector3(1, 0, 1));
        
    }

    public void OnExit(Enemy t)
    {
        
    }
}
