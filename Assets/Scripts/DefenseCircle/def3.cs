using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class def3 : MonoBehaviour {

    public def2 d2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bullet>() == null)
            return;

        
    }
}
