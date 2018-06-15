using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseControll : MonoBehaviour {
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
    public void ExitGameNow()
    {
        audioSource.Play();
        Application.Quit();
    }
    public void Replay()
    {
        audioSource.Play();
        Application.LoadLevel("a");
        ScoreController.Score = 0;
    }
}
