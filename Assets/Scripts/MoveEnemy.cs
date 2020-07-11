using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{

    public float speed = 1f;
    public int flip_cheak = 1; // если значение 1 объект переворачивается



    public Transform pos1, pos2, startPos;

    Vector2 nextPos;

    private void Start()
    {
        nextPos = startPos.position;
    }

    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
            Flip();

        }

        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
            Flip();
        }

        transform.position = Vector2.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    void Flip() // функция переворачивающая объект 
    {
        if (flip_cheak == 1)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
}
