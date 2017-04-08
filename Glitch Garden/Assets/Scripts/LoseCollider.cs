using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private Load_New_Level levelManager;

	// Use this for initialization
	void Start () {
        levelManager = GameObject.FindObjectOfType<Load_New_Level>();
	}

    private void OnTriggerEnter2D()
    {
        levelManager.load_da_scene("03b Lose");
    }
}
