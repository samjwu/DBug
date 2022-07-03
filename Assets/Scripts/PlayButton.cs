using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField]
    Button _button;

    void Start()
    {
        _button.onClick.AddListener(BeginGame);
    }

    void BeginGame()
    {
        GameStats.linesCommitted = 0;
        GameStats.bugsMade = 0;
        GameStats.numberCommits = 0;
        SceneManager.LoadScene(1);
    }
}
