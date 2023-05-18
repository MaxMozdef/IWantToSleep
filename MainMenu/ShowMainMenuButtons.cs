using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowMainMenuButtons : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameGameMainMenu;
    [SerializeField] TapToPlay toPlay;
    [SerializeField] Animator upGameName;

    public bool isMainMenuUpPosition { get; private set; }

    void Start()
    {
        isMainMenuUpPosition = false;
    }

    void Update()
    {
        UpMainMenu();
    }

    void UpMainMenu()
    {
        if (toPlay.isTapFirstTime)
        {
            upGameName.Play("GameNameUp");
            isMainMenuUpPosition = true;
        }
    }
}
