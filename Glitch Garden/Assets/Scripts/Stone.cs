using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    private Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    private void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Attackers attacker = collision.gameObject.GetComponent<Attackers>();

        if (attacker)
        {
            animator.SetTrigger("underAttack trigger");
        }
    }
}
