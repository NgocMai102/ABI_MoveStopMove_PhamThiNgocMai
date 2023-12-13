using System.Collections;
using System.Collections.Generic;
using Game.Character;
using UnityEngine;

public class PlayerRange : MonoBehaviour
{
    [SerializeField] private SphereCollider collider;
    [SerializeField] private Player player;
    [SerializeField] private float range;
    
    void Start()
    {
        range = collider.radius;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(CharacterTag.ENEMY))
        { 
            player.target = other.transform;

            player.isAttack = true;
            player.currentState.ChangeState(player.AttackState);
        }
    }
    void Update()
    {
        
    }
}
