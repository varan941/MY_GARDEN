using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class PlayerController : Singleton<PlayerController>
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    public Joystick joystick; 

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    public float time_anim = 0.97f, y = 300, x = -250; // время анимации, направления куда улетит игрок
    Rigidbody2D rigidbody_Player;

    public GameObject respawn;
    public float time_resp = 0.8f; 

    private void Start()
    {
        rigidbody_Player = GetComponent<Rigidbody2D>(); // присваиваем RB чтобы откидывать после смерти
    }    

    void Update()
    {

        if (joystick.Horizontal >= 0.2f)
        {
            horizontalMove = runSpeed;
        }

        else if (joystick.Horizontal <= -0.2f)
        {
            horizontalMove = -runSpeed;
        }
        else
        {
            horizontalMove = 0.0f;
        }

        float verticalMove = joystick.Vertical;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (verticalMove >= .6f)
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            //animator.SetBool("IsJumping", true);
        }

        if (verticalMove <= -.5f)
        {
            crouch = true;
        }

        else
        {
            crouch = false;
        }

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    //public void OnCrouching (bool isCrouching)
    //{
    //	animator.SetBool("IsCrouching", isCrouching);
    //}

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Deadly" || other.tag == "Enemy") 
        {
            Debug.Log("Задел тригер смерти");                     
            GetDamage();
        }
        
    }

    public void BouncePlayer()
    {
        Debug.Log("Откидываем перса");
        rigidbody_Player.AddForce(new Vector2(x, y)); 
    }

    public void GetDamage()
    {
        animator.SetBool("IsDead", true);
        BouncePlayer();
        StartCoroutine(DiePlayer());
    }

    IEnumerator DiePlayer()  
    {
        yield return new WaitForSeconds(time_anim);
        animator.SetBool("IsDead", false); // выключение анимации
        yield return new WaitForSeconds(time_resp);
        gameObject.transform.position = respawn.transform.position;// перемещает нас в респаун, если
                                                                   // мы попадём в этот коллайдер
    }

}