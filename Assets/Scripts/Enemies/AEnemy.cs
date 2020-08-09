using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AEnemy : MonoBehaviour
{
    public int HP = 1;
    [NonSerialized] public Animator animator;
    [NonSerialized] public SpriteRenderer sprite;
    public List<Collider2D> allColliders;

    public void GetDamage(int count = 0)
    {
        if (count != 0)
            Debug.Log("Сильный урон");
        else
        {
            HP--;
            if (HP <= 0)
            {
                Debug.Log("Враг погиб");
                foreach (var item in allColliders)
                {
                    item.enabled = false;
                }
                animator.SetBool("IsDeadEnemy", true);
                StartCoroutine(OffBody());
            }
        }
    }

    public virtual void Attack()
    {
        Debug.Log("Attack");
    }

    public IEnumerator OffBody()
    {
        var clips = animator.runtimeAnimatorController.animationClips;
        float time = 0;
        foreach (AnimationClip clip in clips)
        {
            if (clip.name.Contains("Die"))
                time = clip.length;            
        }        

            yield return new WaitForSeconds(time+0.1f);
        gameObject.SetActive(false);
    }
}
