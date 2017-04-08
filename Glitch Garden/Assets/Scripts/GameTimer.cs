using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {

    private Slider slider;
    private AudioSource audioSource;
    private Load_New_Level levelManager;
    private GameObject winLabel;

    public float levelSeconds = 100;

    private bool isEndOfLevel = false;

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
        audioSource = GetComponent<AudioSource>();
        levelManager = GameObject.FindObjectOfType<Load_New_Level>();
        FindYouWin();
        winLabel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        slider.value = Time.timeSinceLevelLoad / levelSeconds;

        if (Time.timeSinceLevelLoad >= levelSeconds && !isEndOfLevel)
        {
            audioSource.Play();
            winLabel.SetActive(true);

            Invoke("LoadNextLevel", audioSource.clip.length);
            isEndOfLevel = true;
        }
	}

    void LoadNextLevel()
    {
        levelManager.LoadNextLevel();
    }

    void FindYouWin()
    {
        winLabel = GameObject.Find("Win Label");
        if (!winLabel)
        {
            Debug.Log("Please create You Win object.");
        }
    }
}
