using System.Collections;
using UnityEngine;

public class ShowHead : MonoBehaviour
{
    [SerializeField] TapToPlay toPlay;

    float speed = 0.002f;
    float timeCount = 0.01f;
    Vector2 newHeadPosition = new Vector2(-2.07f, -4.53f);

    private void Update()
    {
        HeadTransfer();
    }

    void HeadTransfer()
    {
        if (toPlay.isTapFirstTime == false)
            StartCoroutine(WaitBeforeShowHead());
    }

    IEnumerator WaitBeforeShowHead()
    {
        yield return new WaitForSecondsRealtime(86);
        transform.position = Vector2.Lerp(transform.position, newHeadPosition, Time.deltaTime/2);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Vector2.zero), timeCount * speed);
        timeCount += Time.deltaTime;

        yield return new WaitForSecondsRealtime(10);
        gameObject.SetActive(false);
    }
}
