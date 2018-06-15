using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour {
    public AudioClip audioClip;
    private AudioSource audioSource;
    GameObject obj;
	void Start () {
        obj = gameObject;
        audioSource = obj.GetComponent<AudioSource>();
        
		
	}
	
	// Update is called once per frame
	public void exitGame()
    {
        audioSource.Play();
        Application.Quit();
    }
    public void playGame()
    {
        audioSource.Play();
        Application.LoadLevel("a");
    }
    public void guideGame()
    {
        audioSource.Play();
        Application.LoadLevel("guide");
    }
}
