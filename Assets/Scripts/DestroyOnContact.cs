﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    public float timedeth = 1f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag== "Bonus")
        {
            Debug.Log("Destroy Bonus");
            Destroy(other.gameObject);
        }

        //if (other.gameObject.tag == "Enemy_Head")
        //{
        //    Debug.Log("Задел голову");
            
        //    Destroy(other.transform.parent.gameObject, timedeth);
            
            
        //}
    }
}
