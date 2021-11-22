using UnityEngine;
using UnityEngine.UI;

public class SubmissionManager : MonoBehaviour
{
    public GameObject CodeInput;
    public GameObject DebugButton;
    public GameObject InfoDisplay;

    public static int LinesCommitted;
    public int LinesCount;
    public GameObject LinesDisplay;

    public static int BugsMade;
    public int BugsCount;
    public GameObject BugsDisplay;

    public static int NumberCommits;
    public int CommitCount;
    public GameObject CommitDisplay;

    public GameObject CompletionDisplay;

    const float LINES_TO_COMPLETION = 1337;

    void Start()
    {
    }

    void Update()
    {
        LinesCount = LinesCommitted;
        LinesDisplay.GetComponent<Text>().text = string.Format("Lines of Code Committed: {0:g}", LinesCount);

        BugsCount = BugsMade;
        BugsDisplay.GetComponent<Text>().text = string.Format("Number of Bugs: {0:g}", BugsCount);

        CommitCount = NumberCommits;
        CommitDisplay.GetComponent<Text>().text = string.Format("Number of Commits: {0:g}", CommitCount);

        CompletionDisplay.GetComponent<Text>().text = string.Format("Project Completion (%): {0:n}", (float)LinesCount / LINES_TO_COMPLETION);
    }
}
