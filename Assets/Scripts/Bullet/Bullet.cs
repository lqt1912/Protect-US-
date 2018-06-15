using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet  : MonoBehaviour {

    public float speed;
    Vector3 v = new Vector3(0, 0, 0);
    public Rigidbody2D rb;
    public GameObject boom;
    void Start () {
       
	}
	// Update is called once per frame
	void Update () {
        rb.bodyType = RigidbodyType2D.Dynamic;
        transform.position = Vector2.MoveTowards(transform.position, v, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            PlayBoom();
        }
        if (collision.tag == "Dead")
            Application.LoadLevel("lost");
    }
    void PlayBoom()
    {
        GameObject tmp = (GameObject)Instantiate(boom);
        tmp.transform.position = transform.position;
    }
}
