using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ImplementShowButtons : MonoBehaviour
{
    [SerializeField] Button thisButton;
    [SerializeField] TapToPlay toPlay;

    float buttonDelay = 1.1f;

    void Update()
    {
        ShowMainMenuButton();
    }

    private void ShowMainMenuButton()
    {
        if (toPlay.isTapFirstTime)
            StartCoroutine(ActivetedButton());
    }

    IEnumerator ActivetedButton()
    {
        yield return new WaitForSeconds(buttonDelay);
        thisButton.gameObject.SetActive(true);
    }
}
