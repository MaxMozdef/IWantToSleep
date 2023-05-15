using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ImplementShowButtons : MonoBehaviour
{
    [SerializeField] string animationName;
    [SerializeField] ShowMainMenuButtons showMainMenuButtons;
    [SerializeField] Button thisButton;

    Animator thisButtonAnimator;
    UnityAction<Button, Animator, string> ShowButtonAction;

    void OnEnable()
    {
        thisButton = GetComponent<Button>();
        thisButtonAnimator = GetComponent<Animator>();

        ShowButtonAction += AppereanceButton;
    }

    void OnDisable()
    {
        ShowButtonAction -= AppereanceButton;
    }

    void Update()
    {
        StartShowButtonAction();
    }

    private void StartShowButtonAction()
    {
        if (showMainMenuButtons.isMainMenuUpPosition)
            ShowButtonAction.DynamicInvoke(this);
    }

    void AppereanceButton(Button but, Animator anim, string animName)
    {
        but = thisButton;
        anim = thisButtonAnimator;
        animName = animationName;

        IEnumerator ShowButtonsCoroutine()
        {
            yield return new WaitForSeconds(1.5f);

            but.gameObject.SetActive(true);
            anim.Play(animName);
        }

        if (showMainMenuButtons.isMainMenuUpPosition)
            StartCoroutine(ShowButtonsCoroutine());
    }
}
