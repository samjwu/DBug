using UnityEngine;
using UnityEngine.UI;

public class TypingBox : MonoBehaviour
{
    [SerializeField]
    InputField _input;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            CommitCode();
        }
    }

    void CommitCode()
    {
        GameStats.LinesCommitted += _input.text.Length;
        GameStats.BugsMade += Random.Range(0, _input.text.Length);
        GameStats.NumberCommits += 1;

        _input.text = string.Empty;
    }
}
