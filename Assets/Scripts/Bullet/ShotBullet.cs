using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour {
    [SerializeField]
    private GameObject bullet;
    public GameObject bullet1;
    public GameObject bullet2;
    private BoxCollider2D box;
    // Use this for initialization
    private void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }
    void Start () {
        StartCoroutine (ShotBullets());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator ShotBullets()
    {
        yield return new WaitForSeconds(Random.Range(1f,2f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;
        Vector3 tmp = transform.position;
        tmp.x = Random.Range(minX, maxX);
        int x = (int) Random.Range(1,3);
        Debug.Log(x);
        switch(x)
        {
            case 1:
                Instantiate(bullet,tmp,Quaternion.identity);
                break;
            case 2:
                Instantiate(bullet1,tmp,Quaternion.identity);
                break;
  
        }

        StartCoroutine(ShotBullets());
    }
}
