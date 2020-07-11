using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDeth : MonoBehaviour
{

    public Animator animator;
    public float time_anim = 1f;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            print("Задел голову");
            animator.SetBool("IsDeadEnemy", true);
            //rigidbody_Player.AddForce(new Vector2(x, y));
        }
    }


  
}
