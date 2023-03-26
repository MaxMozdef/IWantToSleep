using UnityEngine;

public class WhiteRedGradient : MonoBehaviour, ICreationGradient
{
    Gradient lineGradient;
    GradientColorKey[] colorKey;
    GradientAlphaKey[] alphaKey;

    public Gradient CreationGradient()
    {
        lineGradient = new Gradient();

        colorKey = new GradientColorKey[2];
        colorKey[0].color = Color.white;
        colorKey[0].time = 0.0f;
        colorKey[1].color = Color.red;
        colorKey[1].time = 1.0f;

        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 0.0f;
        alphaKey[1].time = 1.0f;

        lineGradient.SetKeys(colorKey, alphaKey);

        return lineGradient;
    }
}
