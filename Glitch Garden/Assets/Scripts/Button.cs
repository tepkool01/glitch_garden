using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    private Button[] buttonArray;
    public GameObject prefab;
    public static GameObject currentlySelected;

	// Use this for initialization
	void Start () {
        buttonArray = GameObject.FindObjectsOfType<Button>();

        this.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        foreach (Button thisButton in buttonArray)
        {
            thisButton.GetComponent<SpriteRenderer>().color = Color.black;
        }
        this.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);

        currentlySelected = prefab;
    }
}
