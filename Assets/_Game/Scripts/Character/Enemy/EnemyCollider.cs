using System;
using System.Collections;
using System.Collections.Generic;
using Game.Character;
using Game.Weapons;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    [SerializeField] private GameObject circleOnLeg;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(WeaponsUtils.TAG))
        {
            enemy.currentState.ChangeState(enemy.EDeadState);
            Debug.Log("Enemy Dead");
        }

        if (other.CompareTag(CharacterTag.PLAYER))
        {
            circleOnLeg.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(CharacterTag.PLAYER))
        {
            circleOnLeg.SetActive(false);
        }
    }
}
