using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour {

    private float speed = 1.5f;
    private GameObject currentTarget;
    private Animator anim;

	// Use this for initialization
	void Start () {

        anim = this.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name + " trigger entered.");
    }

    // Update is called once per frame
    void Update () {
        transform.Translate (Vector3.left * speed * Time.deltaTime);

        if (!currentTarget)
        {
            anim.SetBool("isAttacking", false);
        }
	}

    public void setSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    // called from animation at time of actual attack/damage
    public void strikeCurrentTarget(float damage)
    {
        Debug.Log("Doing damage: " + damage);

        if (currentTarget)
        {
            Health targetHealth = currentTarget.GetComponent<Health>();
 
            if (targetHealth)
            {
                targetHealth.doDamage(damage);
            }
        }
    }

    // puts user into 'attack mode'
    public void attack(GameObject obj)
    {
        currentTarget = obj;
    }
}
