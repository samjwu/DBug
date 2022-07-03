using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class DebugButton : MonoBehaviour
{
    [SerializeField]
    Button _button;
    [SerializeField]
    Text _infoText;

    AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _button.onClick.AddListener(DebugCode);
    }

    void DebugCode()
    {
        _audioSource.Play();

        int randomInt = Random.Range(1, 10);
        if (randomInt <= GameStats.BugsMade)
        {
            _infoText.text = string.Format("You DBugged {0:g} bugs!", randomInt);
            GameStats.BugsMade -= randomInt;
        }
        else
        {
            _infoText.text = string.Format("You DBugged {0:g} bugs!", GameStats.BugsMade);
            GameStats.BugsMade = 0;
        }
    }
}
