using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

    private Text myText;
    private int stars = 0;

	// Use this for initialization
	void Start () {
        myText = this.GetComponent<Text>();
	}

    public void AddStars (int amount)
    {
        stars += amount;
        this.UpdateDisplay();
    }

    public void UseStars (int amount)
    {
        stars -= amount;
        this.UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        myText.text = stars.ToString();
    }
}
