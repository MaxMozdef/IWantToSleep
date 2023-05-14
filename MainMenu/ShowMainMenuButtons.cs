using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowMainMenuButtons : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameGameMainMenu;
    [SerializeField] TapToPlay toPlay;
    [SerializeField] Animator upGameName, playButtonAnimation, exitButtonAnimation;
    [SerializeField] Button playButton, exitButton;

    bool isMainMenuUpPosition = false;

    void OnEnable()
    {
        TapToPlay.firstTapAction += UpMainMenu;
        TapToPlay.firstTapAction += ShowButtons;
    }
    void OnDisable()
    {
        TapToPlay.firstTapAction -= UpMainMenu;
        TapToPlay.firstTapAction -= ShowButtons;
    }

    void UpMainMenu()
    {
        if (toPlay.isTapFirstTime)
        {
            upGameName.Play("GameNameUp");
            isMainMenuUpPosition = true;
        }
    }

    void ShowButtons()
    {
        if (isMainMenuUpPosition)
            StartCoroutine(ShowButtons—oroutine());
    }

    IEnumerator ShowButtons—oroutine()
    {
        yield return new WaitForSeconds(1.5f);

        playButton.gameObject.SetActive(true);
        playButtonAnimation.Play("RotateButton");

        exitButton.gameObject.SetActive(true);
        exitButtonAnimation.Play("RotateButton");
    }
}
