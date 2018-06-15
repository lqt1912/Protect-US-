using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line : MonoBehaviour {
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCol;
    public Text text;
    List<Vector2> points;
    

    public void UpdateLine(Vector2 pos)
    {
        if (EnergyController.Energy == 0)
        {
            return;
        }
        
        if (points == null)
        {
            points = new List<Vector2>();
            SetPoint(pos);
            return;
        }    
        if (Vector2.Distance(points[points.Count - 1], pos) > .1f&&EnergyController.Energy>0)
            SetPoint(pos);
    }
    static public int maxPointGet = 0;
    void SetPoint(Vector2 point)
    {
        if (EnergyController.Energy == 0)
            return;
        points.Add(point);
        EnergyController.Energy--;
        EnergyController.EnergyLost++;
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);
        
        if (points.Count > 1&&EnergyController.Energy>0)
            edgeCol.points = points.ToArray();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
            
       // EnergyController.Energy += 8;//
            ScoreController.Score += 50;
        // Line.maxPointGet = 0;//
        
    }
}
