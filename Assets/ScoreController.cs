using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    // Use this for initialization
    public static int Score, highScore  ;
    Text text;
    
	void Start () {
        text = GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("highscore", highScore );
	}
	
	// Update is called once per frame
	void Update () {

            if(highScore < Score)
            {
               highScore = Score;
            }
            text.text = "" + Score;
            
	}
    void OnDestroy()
    {
        PlayerPrefs.SetInt("highscore", highScore);
        PlayerPrefs.Save();
    }
}
