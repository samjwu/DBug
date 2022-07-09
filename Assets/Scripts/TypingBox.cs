using UnityEngine;
using UnityEngine.UI;

public class TypingBox : MonoBehaviour
{
    [SerializeField]
    InputField _input;
    [SerializeField]
    Text _infoText;
    [SerializeField]
    AudioClip _audioClip;
    [SerializeField]
    AudioSource _audioSource;

    void Update()
    {
        bool isMouseClick = Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetMouseButton(2);
        if (Input.anyKey && !isMouseClick)
        {
            _audioSource.clip = _audioClip;
            _audioSource.volume = 0.25f;
            _audioSource.PlayOneShot(_audioSource.clip, _audioSource.volume);
        }

        if (Input.GetKeyUp(KeyCode.Return))
        {
            CommitCode();
        }
    }

    void CommitCode()
    {
        GameStats.linesCommitted += _input.text.Length;
        int bugs = Random.Range(0, _input.text.Length / 2);
        GameStats.bugsMade += bugs;
        GameStats.numberCommits += 1;

        _infoText.text = string.Format("You committed {0:g} lines of code\nand made {1:g} bugs!", _input.text.Length, bugs);

        _input.text = "";
        _input.Select();
    }
}
