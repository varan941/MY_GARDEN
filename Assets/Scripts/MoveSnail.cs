using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSnail : MonoBehaviour
{

    public float speed = 1f;
    private float start_speed, end_speed;
    
    public int flip_cheak = 1; // если значение 1 объект переворачивается

    public float posit_lef_x = 10f, posit_righ_x = -1; // левая и правая позиции куда летит объект

    private void Start()
    {
        start_speed = speed;
        end_speed = -speed;
    }



    void Update()
    {

        transform.Translate(Vector2.left * speed * Time.deltaTime); //вначале перс движеться влево


        if (transform.position.x < posit_lef_x)
        {
            speed = end_speed;
            Flip();
        }

        if (transform.position.x > posit_righ_x)
        {
            speed = start_speed;
            Flip();
        }
    }

    void Flip() // функция переворачивающая объект 
    {
        if (flip_cheak == 1)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }

}



    //void Flip() // функция переворачивающая объект - спрайтом
    //{
    //    if (speed<0)
    //    {
    //        flip.flipX = true;
    //    }
    //    else
    //    {
    //        flip.flipX = false;
    //    }

   


