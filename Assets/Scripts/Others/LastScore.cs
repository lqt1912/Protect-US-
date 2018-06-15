using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour {

    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
      //  if(ScoreController.Score > ScoreController.highScore)
       // {
            //ScoreController.highScore = ScoreController.Score;
            text.text = "" + ScoreController.Score + "\n"+ ScoreController.highScore;
       // }
	}
}
