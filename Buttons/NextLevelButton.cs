using UnityEngine.SceneManagement;

public class NextLevelButton : ImplementShowButtons
{
    Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
}
