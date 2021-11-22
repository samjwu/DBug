using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
    public void BeginGame()
    {
        SceneManager.LoadScene(2);
    }
}
