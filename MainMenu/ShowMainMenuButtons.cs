using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowMainMenuButtons : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameGameMainMenu;
    [SerializeField] TapToPlay toPlay;

    Vector2 newGameNamePosition = new Vector2( 0, 30);

    void OnEnable() => TapToPlay.firstTapAction += UpMainMenu;
    void OnDisable() => TapToPlay.firstTapAction -= UpMainMenu;

    void UpMainMenu()
    {
        if (toPlay.isTapFirstTime)
        {
            nameGameMainMenu.transform.position = Vector2.Lerp(transform.position, newGameNamePosition, Time.deltaTime / 2);
        }
    }
}
