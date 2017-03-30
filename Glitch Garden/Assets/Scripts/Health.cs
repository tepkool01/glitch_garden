using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float hp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float doDamage(float damage)
    {
        hp = hp - damage;

        if (hp <= 0)
        {
            DestroyObject();
        }

        return hp;
    }

    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
