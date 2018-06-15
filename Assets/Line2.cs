using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line2 : MonoBehaviour {

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCol;
    static int Energy = 50;
    List<Vector2> points;

    public static Line2 instance;
    private void Awake()
    {
        makeInstance();
    }
    void makeInstance()
    {
        if (instance == null)
            instance = this;
    }
    public void UpdateLine(Vector2 pos)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            SetPoint(pos);

            return;
        }

        if (Vector2.Distance(points[points.Count - 1], pos) > .1f && Energy > 0)
            SetPoint(pos);
    }

    void SetPoint(Vector2 point)
    {
        points.Add(point);
        Energy--;
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);

        if (points.Count > 1)
            edgeCol.points = points.ToArray();
    }

 
}
