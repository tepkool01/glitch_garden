using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

    private Text myText;
    private int stars = 100;
    public enum Status { SUCCESS, FAILURE };

	// Use this for initialization
	void Start () {
        myText = this.GetComponent<Text>();
        this.UpdateDisplay();
	}

    public void AddStars (int amount)
    {
        stars += amount;
        this.UpdateDisplay();
    }

    public Status UseStars (int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            this.UpdateDisplay();
            return Status.SUCCESS;
        } else
        {
            return Status.FAILURE;
        }
        
    }

    private void UpdateDisplay()
    {
        myText.text = stars.ToString();
    }
}
