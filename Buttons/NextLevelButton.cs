using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelButton : MonoBehaviour
{
    [SerializeField] Button nextLevelButtonObject;

    void OnEnable() => ConditionsForPassingTheFirstLevel.compliteFirstLevel += ShowButton;
    void OnDisable() => ConditionsForPassingTheFirstLevel.compliteFirstLevel -= ShowButton;

    void ShowButton()
    {
        if (LinesDrawer.isPossibleDraw == false)
            nextLevelButtonObject.gameObject.SetActive(true);
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
