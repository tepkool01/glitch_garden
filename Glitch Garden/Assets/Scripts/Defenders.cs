using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour {

    private StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}

    public void AddStars (int amount)
    {
        starDisplay.AddStars(amount);
    }
}
