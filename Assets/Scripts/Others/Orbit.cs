using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {
    public float speed;
    public Transform target;
    public GameObject linePrefab;
    Line activeLine;
    int sumPoint = 0;
    bool flag = true;
    // Use this for initialization
    int z=1;
    int SpeedPerTime;
	void Start () {
        

    }
    private void FixedUpdate()
    {
        transform.RotateAround(target.position, new Vector3(0, 0, z), 1+Time.deltaTime*200);
    }
    // Update is called once per frame
    void Update () {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      
        if (Input.GetMouseButtonDown(0) && !(mousePos.y > -3 && mousePos.y < -2 && mousePos.x < -2 && mousePos.x > -3))
        {
           // Debug.Log(Input.mousePosition.x + " " + Input.mousePosition.y);
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<Line>();
        }

        if (Input.GetMouseButtonUp(0)||EnergyController.Energy<=0)
        {
            activeLine = null;
        }
        if (activeLine != null && flag)
        {
            activeLine.UpdateLine(transform.position);
        }
    }
    public void ChangeZ()
    {
        z = -z;
    }
}
