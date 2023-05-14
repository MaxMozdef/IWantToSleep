using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(0);
    }
}
