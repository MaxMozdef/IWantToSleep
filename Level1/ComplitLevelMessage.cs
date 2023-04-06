using TMPro;
using UnityEngine;

public class ComplitLevelMessage : MonoBehaviour
{
    [SerializeField] TMP_Text compliteLevelText;
    [SerializeField] LevelsCompliteMessages levelsCompliteMessage;

    

    void OnEnable() => ConditionsForPassingTheFirstLevel.compliteFirstLevel += ShowComplitLevelText;
    void OnDisable() => ConditionsForPassingTheFirstLevel.compliteFirstLevel -= ShowComplitLevelText;

    void ShowComplitLevelText()
    {
        if (LinesDrawer.isPossibleDraw == false)
        {
            compliteLevelText.gameObject.SetActive(true);
            compliteLevelText.text = levelsCompliteMessage.messagesForCompliteLevel[0];
        }
    }
}
