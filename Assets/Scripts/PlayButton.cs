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
        GameStats.LinesCommitted = 0;
        GameStats.BugsMade = 0;
        GameStats.NumberCommits = 0;
        SceneManager.LoadScene(1);
    }
}
