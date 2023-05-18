using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : ImplementShowButtons
{

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
