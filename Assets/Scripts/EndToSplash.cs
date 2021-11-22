using UnityEngine;
using UnityEngine.SceneManagement;

public class EndToSplash : MonoBehaviour
{
    public GameObject AgainButton;

    public void PlayAgain()
    {
        SubmissionManager.LinesCommitted = 0;
        SubmissionManager.BugsMade = 0;
        SubmissionManager.NumberCommits = 0;

        SceneManager.LoadScene(1);
    }
}
