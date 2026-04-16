using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{

    public void ChangeToScene(string targetSceneName)
    {
        SceneManager.LoadScene(targetSceneName);
    }
}
