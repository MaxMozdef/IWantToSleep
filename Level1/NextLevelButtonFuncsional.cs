using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButtonFuncsional : MonoBehaviour
{
    Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void GoToSecondLevel()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
}
