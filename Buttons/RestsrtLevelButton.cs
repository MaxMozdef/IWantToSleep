using UnityEngine;
using UnityEngine.SceneManagement;

public class RestsrtLevelButton : MonoBehaviour
{
    UnityEngine.SceneManagement.Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void RestartThisScene() => SceneManager.LoadScene(scene.buildIndex);
}
