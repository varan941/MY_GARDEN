using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centipede : AEnemy
{
    [SerializeField] GameObject _bulltPrefab;
    [SerializeField] Transform _parent;

    private void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        allColliders.AddRange(GetComponents<Collider2D>());
    }


    public override void Attack()
    {
        //Debug.Log("1");
        Instantiate(_bulltPrefab, _parent);
    }   
}
