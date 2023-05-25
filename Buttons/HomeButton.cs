using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    int indexHomeScene = 0;

    public void TransitionToHome() => SceneManager.LoadScene(indexHomeScene);
}
