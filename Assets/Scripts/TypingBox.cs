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
        bool isMouseClick = Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2);
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

        GameStats.linesCommitted += _input.text.Length;
        GameStats.bugsMade += Random.Range(0, _input.text.Length);
        GameStats.numberCommits += 1;

        _input.text = "";

        _input.Select();
    }
}
