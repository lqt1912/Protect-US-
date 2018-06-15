using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    // Use this for initialization
    public ButtonController.BtnType bt;
    public enum BtnType
    {
        exitBtn,
        replayBtn,
        homeBtn

    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (bt == ButtonController.BtnType.exitBtn)
            Application.Quit();
        if (bt == ButtonController.BtnType.replayBtn)
            Application.LoadLevel("a");
        if (bt == ButtonController.BtnType.homeBtn)
            Application.LoadLevel("home");
	}
}
