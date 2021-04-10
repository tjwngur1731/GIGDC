using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private bool isWalk;
    [SerializeField]
    private bool isRun;

    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        anim.SetBool("isWalk", isWalk);
        anim.SetBool("isRun", isRun);
    }
}
