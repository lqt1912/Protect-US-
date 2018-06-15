using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnergyController : MonoBehaviour {

    public static int Energy;
    public static int EnergyLost = 0;
    // Use this for initialization
    Text text;
    float time;
    void Start()
    {
        text = GetComponent<Text>();
        Energy = 45;
        time = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (time > 1.0f)
        {
            time = 0;
            Energy += 2;
        }

        time = time + Time.deltaTime;
        if (Energy < 0)
          Energy = 0;
        if (Energy > 45)
            Energy = 45;
        text.text = "" + Energy;
    }
}
