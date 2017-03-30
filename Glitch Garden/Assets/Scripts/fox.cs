using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Attackers))]
public class fox : MonoBehaviour {

    private Animator anim;
    private Attackers attacker;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
        attacker = this.GetComponent<Attackers>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.gameObject;

        if (!obj.GetComponent<Defenders>())
        {
            return;
        }

        if (obj.GetComponent<Stone>())
        {
            anim.SetTrigger("JumpTrigger");
        } else
        {
            anim.SetBool("isAttacking", true);
            attacker.attack(obj);
        }
    }
}
