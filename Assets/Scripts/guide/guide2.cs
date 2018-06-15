using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guide2 : MonoBehaviour {
    public AudioClip audioClip;
    private AudioSource audioSource;
    GameObject obj;
    // Use this for initialization
    void Start () {
        obj = gameObject;
        audioSource = obj.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void NextGuide()
    {
        audioSource.Play();
        Application.LoadLevel("guide2");
    }
}
