using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
