using UnityEngine;

public class DestroyLine : MonoBehaviour
{
    float destroyLine = -12;

    void FixedUpdate()
    {
        if (transform.position.y < destroyLine)
        {
            Destroy(gameObject);
        }
    }
}
