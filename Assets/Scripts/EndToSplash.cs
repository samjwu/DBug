using UnityEngine;
using UnityEngine.SceneManagement;

public class EndToSplash : MonoBehaviour
{
    public GameObject AgainButton;

    public void PlayAgain()
    {
        StatsTextManager.LinesCommitted = 0;
        StatsTextManager.BugsMade = 0;
        StatsTextManager.NumberCommits = 0;

        SceneManager.LoadScene(1);
    }
}
