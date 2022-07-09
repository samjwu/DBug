using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{
    public static int linesCommitted;
    public static int bugsMade;
    public static int numberCommits;

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
    [SerializeField]
    Text _infoText;

    void Update()
    {
        _linesText.text = string.Format("Lines of Code Committed: {0:g}", linesCommitted);

        _bugsText.text = string.Format("Number of Bugs: {0:g}", bugsMade);

        _commitText.text = string.Format("Number of Commits: {0:g}", numberCommits);

        _completionPercent = linesCommitted / LINES_TO_COMPLETION;
        _completionText.text = string.Format("Project Completion (%): {0:p}", _completionPercent);

        if (linesCommitted >= LINES_TO_COMPLETION)
        {
            _infoText.text = "Fix your bugs!";

            if (bugsMade == 0)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
