using System;
using UnityEngine;

public class LerpColor : MonoBehaviour
{
    [SerializeField][Range(0f, 3f)] float lerpTime;
    [SerializeField] Color[] colorsSubstitution;

    SpriteRenderer platformRenderer;
    int colorsSubstitutionLength;

    float toChangeColorIndexTime = 0;
    int colorIndex = 0;
    float maxValuelerp = 1;
    float indexTimeBarier = 0.9f;

    void Start()
    {
        platformRenderer = GetComponent<SpriteRenderer>();
        colorsSubstitutionLength = colorsSubstitution.Length;
    }

    void Update()
    {
        ChangePlatformColor();
    }

    void ChangePlatformColor()
    {
        platformRenderer.material.color = Color.Lerp(platformRenderer.material.color, colorsSubstitution[colorIndex], lerpTime * Time.deltaTime);
        toChangeColorIndexTime = Mathf.Lerp(toChangeColorIndexTime, maxValuelerp, lerpTime * Time.deltaTime);

        if (toChangeColorIndexTime > indexTimeBarier)
        {
            toChangeColorIndexTime = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= colorsSubstitutionLength) ? 0 : colorIndex;
        }
    }
}
