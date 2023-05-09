using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ShowHead : MonoBehaviour
{
    float speed = 0.01f;
    float timeCount = 0.01f;
    public static bool isFirstTouchDone = false;
    Vector2 newHeadPosition = new Vector2(-2.07f, -4.53f);
    Quaternion newHeadRotation = new Quaternion(1, 1, -0.3f, 0);

    UnityAction ifTapToScrean;

    void OnEnable() => ifTapToScrean += FirstTouchDone;

    void OnDisable() => ifTapToScrean -= FirstTouchDone;

    private void Update()
    {
        HeadTransfer();
        ifTapToScrean();
        print(isFirstTouchDone);
    }

    void FirstTouchDone()
    {
        if(Input.GetMouseButtonDown(0))
            isFirstTouchDone = true;
    }

    void HeadTransfer()
    {
        if (isFirstTouchDone == false)
            StartCoroutine(WaitBeforeShowHead());
    }

    IEnumerator WaitBeforeShowHead()
    {
        yield return new WaitForSecondsRealtime(86);
        transform.position = Vector2.Lerp(transform.position, newHeadPosition, Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, newHeadRotation, timeCount * speed);
        timeCount += Time.deltaTime;
        yield return new WaitForSecondsRealtime(7);
        gameObject.SetActive(false);
    }
}
