using UnityEngine;
using UnityEngine.SceneManagement;

public class EndToSplash : MonoBehaviour
{
    public GameObject AgainButton;

    public void PlayAgain()
    {
        GameStats.LinesCommitted = 0;
        GameStats.BugsMade = 0;
        GameStats.NumberCommits = 0;

        SceneManager.LoadScene(1);
    }
}
