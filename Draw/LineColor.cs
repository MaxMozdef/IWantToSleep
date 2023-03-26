using UnityEngine;

public class LineColor : MonoBehaviour
{
    ICreationGradient gradientGradient;

    public LineColor(ICreationGradient gradientGradient)
    {
        this.gradientGradient = gradientGradient;
    }

    public Gradient CreationGradient()
    {
        return gradientGradient.CreationGradient();
    }
}
