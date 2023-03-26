using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCreateGradient : MonoBehaviour
{
    Gradient lineGradient;
    GradientColorKey[] colorKey;
    GradientAlphaKey[] alphaKey;

    protected Gradient CreationGradient()
    {
        lineGradient = new Gradient();

        colorKey = new GradientColorKey[2];

        SetColor();

        colorKey[0].time = 0.0f;
        colorKey[1].time = 1.0f;

        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 0.0f;
        alphaKey[1].time = 1.0f;

        lineGradient.SetKeys(colorKey, alphaKey);

        return lineGradient;
    }

    protected virtual void SetColor()
    {
        colorKey[0].color = Color.white;
        colorKey[1].color = Color.blue;
    }
}
