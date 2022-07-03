using UnityEngine;
using UnityEngine.UI;

public class TypingBox : MonoBehaviour
{
    [SerializeField]
    InputField _input;
    [SerializeField]
    Text _infoText;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            CommitCode();
        }
    }

    void CommitCode()
    {
        _infoText.text = string.Format("You committed {0:g} lines of code!", _input.text.Length);

        GameStats.LinesCommitted += _input.text.Length;
        GameStats.BugsMade += Random.Range(0, _input.text.Length);
        GameStats.NumberCommits += 1;

        _input.text = string.Empty;
    }
}
