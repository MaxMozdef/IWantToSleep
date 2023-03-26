using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LinesDrawer : MonoBehaviour
{
    [SerializeField] GameObject linePrefab;
    [SerializeField] float linePointsMinDIstance, lineWidth;
    [SerializeField] LayerMask cantDrawOverLayer;

    LineColor lineColor;
    int cantDrawOverLayerIndex;
    Line currentLine;
    Camera cam;

    void Start()
    {
        lineColor = new LineColor(new WhiteRedGradient());
        cam = Camera.main;
        cantDrawOverLayerIndex = LayerMask.NameToLayer("CantDrawOver");
    }


    void Update()
    {
        DrawComplite();
    }

    void DrawComplite()
    {
        if (Input.GetMouseButtonDown(0))
            BeginDraw();

        if (currentLine != null)
            Draw();

        if (Input.GetMouseButtonUp(0))
            EndDraw();
    }

    void BeginDraw()
    {
        currentLine = Instantiate(linePrefab, this.transform).GetComponent<Line>();

        currentLine.UsePhysics(false);
        currentLine.SetLineColor(lineColor.CreationGradient());
        currentLine.SetPointsMinDistance(linePointsMinDIstance);
        currentLine.SetLineWidth(lineWidth);
    }

    void Draw()
    {
        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D raycastHit2D = Physics2D.CircleCast(mousePosition, lineWidth / 3f, Vector2.zero, 1f, cantDrawOverLayer);

        if (raycastHit2D)
            EndDraw();
        else
            currentLine.AddPoint(mousePosition);
    }

    void EndDraw()
    {
        if (currentLine != null)
        {
            if (currentLine.pointsCount < 2)
                Destroy(currentLine.gameObject);
            else
            {
                currentLine.gameObject.layer = cantDrawOverLayerIndex;
                currentLine.UsePhysics(true);
                currentLine = null;
            }
        }
    }
}
