using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour {

    // Use this for initialization
    public Slider slider;
	void Start () {
        slider.value = 100;
	}
	
	// Update is called once per frame
	void Update () {

        slider.value = EnergyController.Energy;
	}
}
