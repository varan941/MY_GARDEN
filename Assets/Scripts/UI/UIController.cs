using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class UIController : Singleton<UIController>
{
    [SerializeField]
    private Animator _animator;


    private void Start()
    {
        _animator=GetComponentInChildren<Animator>();
    }

    public void RunAnimation()
    {
        _animator.SetTrigger("RunDieScreen");
    }

}
