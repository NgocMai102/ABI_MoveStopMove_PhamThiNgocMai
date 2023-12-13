using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Weapons
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Player player;
    private Vector3 direction;
    
    void Start()
    {
        moveSpeed = 10f;
        if (player == null)
        {
            player = FindObjectOfType<Player>();
        }
        TF.forward = (player.target.position - player.TF.position).normalized;
    }

    void Update()
    {
        TF.Translate(TF.forward * moveSpeed * Time.deltaTime, Space.World);
    }
    
    private void Movement()
    {
        //transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

}
