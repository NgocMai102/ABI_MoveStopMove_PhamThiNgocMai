using System.Collections;
using System.Collections.Generic;
using _Framework.StateMachine;
using Game.Character;
using Game.Character.Animation;
using UnityEngine;

public class AttackState : IState<Player>
{
    private float attackDelayTime;
    public void OnEnter(Player t)
    {
        t.isMoving = false;
        t.isAttack = true;

        attackDelayTime = CharacterUtils.ATTACK_DELAY_TIME;
        
        t.ChangeAnim(AnimType.ATTACK);
        //SimplePool.Spawn<Bullet>(PoolType.Bullet, t.TF.position, Quaternion.identity);
    }

    public void OnExecute(Player t)
    {
        if (t.isMoving)
        {
            t.isAttack = false;
            t.currentState.ChangeState(t.IdleState);
            return;
        }
        attackDelayTime -= Time.deltaTime;
        if (attackDelayTime > 0f)
        {
            return;
        }
        t.isAttack = false;
        t.currentState.ChangeState(t.IdleState);
    }

    public void OnExit(Player t)
    {
        
    }
}
