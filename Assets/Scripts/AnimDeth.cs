using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDeth : MonoBehaviour
{
    private AEnemy _aEnemy;
    public float time_anim = 1f;

    private void Start()
    {
        _aEnemy = GetComponentInParent<AEnemy>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            print("Задел голову");
            _aEnemy.GetDamage();

            PlayerController.Instance.BouncePlayer();
        }
    }  
}
