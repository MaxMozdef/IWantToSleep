using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] EdgeCollider2D edgeCollider;
    [SerializeField] Rigidbody2D rigidBody;

    float pointsMinDistance = 0.1f;
    float circleColiderRadius;

    [HideInInspector] public List<Vector2> points = new List<Vector2>();
    [HideInInspector] public int pointsCount = 0;

    public void AddPoint(Vector2 newPoint)
    {
        if (points.Count >= 1 && Vector2.Distance(newPoint, GetLastPoint()) < pointsMinDistance)
            return;

        points.Add(newPoint);
        pointsCount++;

        lineRenderer.positionCount = pointsCount;
        lineRenderer.SetPosition(pointsCount - 1, newPoint);

        if (pointsCount > 1)
            edgeCollider.points = points.ToArray();

        CircleCollider2D circleCollider2D = this.gameObject.AddComponent<CircleCollider2D>();
        circleCollider2D.offset = newPoint;
        circleCollider2D.radius = circleColiderRadius;
    }

    public Vector2 GetLastPoint()
    {
        return (Vector2)lineRenderer.GetPosition(pointsCount - 1);
    }

    public void UsePhysics(bool usePhysics)
    {
        rigidBody.isKinematic = !usePhysics;
    }

    public void SetLineColor(Gradient colorGradient)
    {
        lineRenderer.colorGradient = colorGradient;
    }

    public void SetPointsMinDistance(float distance)
    {
        pointsMinDistance = distance;
    }

    public void SetLineWidth(float width)
    {
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;

        circleColiderRadius = width / 2f;
        edgeCollider.edgeRadius = circleColiderRadius;
    }
}
