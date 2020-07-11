using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_objects : MonoBehaviour
{
    public float speed = 1f;
    public float posit_up_y, posit_down_y; //  позиции куда летит объект

    void Update()
    {

        transform.Translate(Vector2.up * speed * Time.deltaTime);

        if (transform.position.y < posit_up_y)
        {
            speed *= -1;
        }

        if (transform.position.y > posit_down_y)
        {
            speed *= -1;
        }
    }

    
}
