using UnityEngine;

public class YelloBlueGradient : MonoBehaviour, ICreationGradient
{
    Gradient lineGradient;
    GradientColorKey[] colorKey;
    GradientAlphaKey[] alphaKey;

    public Gradient CreationGradient()
    {
        lineGradient = new Gradient();

        colorKey = new GradientColorKey[2];
        colorKey[0].color = Color.yellow;
        colorKey[0].time = 0.0f;
        colorKey[1].color = Color.blue;
        colorKey[1].time = 1.0f;

        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 1.0f;
        alphaKey[1].alpha = 1.0f;
        alphaKey[1].time = 1.0f;

        lineGradient.SetKeys(colorKey, alphaKey);

        return lineGradient;
    }
}
