using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {

    public float speed, damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attackers attacker = collision.gameObject.GetComponent<Attackers>();
        Health health = collision.gameObject.GetComponent<Health>();

        if (attacker && health)
        {
            health.doDamage (damage);
            Destroy (gameObject);
        }
    }
}
