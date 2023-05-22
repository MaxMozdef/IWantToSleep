using UnityEngine;
using UnityEngine.UI;

public class ButtonGoToSecondLevel : MonoBehaviour
{
    [SerializeField] Button secondLevelGoButtons;

    void OnEnable() => ConditionsForPassingTheFirstLevel.compliteFirstLevel += ShowButtonGoSecondLevel;
    void OnDisable() => ConditionsForPassingTheFirstLevel.compliteFirstLevel -= ShowButtonGoSecondLevel;

    void ShowButtonGoSecondLevel()
    {
        if (LinesDrawer.isPossibleDraw == false)
            secondLevelGoButtons.gameObject.SetActive(true);
    }
}
