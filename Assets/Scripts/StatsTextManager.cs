using UnityEngine;
using UnityEngine.UI;

public class StatsTextManager : MonoBehaviour
{
    public static int LinesCommitted;
    public static int BugsMade;
    public static int NumberCommits;

    const float LINES_TO_COMPLETION = 1337;

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

        _completionText.text = string.Format("Project Completion (%): {0:n}", (float)LinesCommitted / LINES_TO_COMPLETION);
    }
}
