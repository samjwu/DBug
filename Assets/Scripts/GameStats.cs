using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{
    public static int LinesCommitted;
    public static int BugsMade;
    public static int NumberCommits;

    const float LINES_TO_COMPLETION = 1337;

    float _completionPercent;

    [SerializeField]
    Text _linesText;
    [SerializeField]
    Text _bugsText;
    [SerializeField]
    Text _commitText;
    [SerializeField]
    Text _completionText;

    void Update()
    {
        _linesText.text = string.Format("Lines of Code Committed: {0:g}", LinesCommitted);

        _bugsText.text = string.Format("Number of Bugs: {0:g}", BugsMade);

        _commitText.text = string.Format("Number of Commits: {0:g}", NumberCommits);

        _completionPercent = LinesCommitted / LINES_TO_COMPLETION;
        _completionText.text = string.Format("Project Completion (%): {0:p}", _completionPercent);

        if (LinesCommitted >= LINES_TO_COMPLETION)
        {
            SceneManager.LoadScene(2);
        }
    }
}
