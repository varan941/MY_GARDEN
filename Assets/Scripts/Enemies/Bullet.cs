using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float timeLife = 3f;
    [SerializeField] private Rigidbody2D _rigb;
    private float timer = 0;

    
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
        timer += Time.deltaTime;
        if (timer>= timeLife)        
            Destroy(gameObject);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (true)
        {
            if (other.tag == "Player")
            {
                Debug.Log("Bullet damage");
                PlayerController.Instance.GetDamage();
            }
        }
    }

    


}
