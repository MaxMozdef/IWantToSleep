using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConditionsForPassingTheFirstLevel : MonoBehaviour
{
    public static UnityAction compliteFirstLevel;
    bool isLineTouchPlatform;

    void OnEnable() => compliteFirstLevel += LineTouchPlatform;
    void OnDisable() => compliteFirstLevel -= LineTouchPlatform;

    void Update()
    {
        compliteFirstLevel();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Line")
            isLineTouchPlatform = true;
    }

    void LineTouchPlatform()
    {
        if (isLineTouchPlatform)
        {
            Time.timeScale = 0;
            LinesDrawer.isPossibleDraw = false;
        }
    }
}
