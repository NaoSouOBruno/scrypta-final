using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneName;
    public float delay = 3f;

    private void Start()
    {
        Invoke("ChangeScene", delay);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}