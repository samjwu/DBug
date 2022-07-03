using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class TypingBox : MonoBehaviour
{
    [SerializeField]
    InputField _input;
    [SerializeField]
    Text _infoText;

    AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        bool isMouseClick = Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2);
        if (Input.anyKey && !isMouseClick)
        {
            _audioSource.PlayOneShot(_audioSource.clip, _audioSource.volume);
        }

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
