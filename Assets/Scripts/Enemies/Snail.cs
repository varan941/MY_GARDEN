using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snail : AEnemy
{
    public float speed = 1f;
    public float posit_lef_x = 10f, posit_righ_x = -1; 

    private bool _movingRight=false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        allColliders.AddRange(GetComponents<Collider2D>());
        allColliders.AddRange(GetComponentsInChildren<Collider2D>());               
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); 

        if (transform.position.x < posit_lef_x &&speed>0)        
            Move(true);
        
        else if(transform.position.x > posit_righ_x && speed < 0)       
            Move(false);        
    }

    private void Move(bool flag)
    {
        _movingRight = flag;
        speed *= -1;
        sprite.flipX = _movingRight;
    }
}
