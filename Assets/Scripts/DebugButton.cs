using UnityEngine;
using UnityEngine.UI;

public class DebugButton : MonoBehaviour
{
    [SerializeField]
    Button _button;
    [SerializeField]
    Text _infoText;
    [SerializeField]
    AudioClip _audioClip;
    [SerializeField]
    AudioSource _audioSource;

    void Start()
    {
        _button.onClick.AddListener(DebugCode);
    }

    void DebugCode()
    {
        _audioSource.clip = _audioClip;
        _audioSource.volume = 1f;
        _audioSource.Play();

        int randomInt = Random.Range(1, GameStats.numberCommits);
        if (randomInt <= GameStats.bugsMade)
        {
            _infoText.text = string.Format("You DBugged {0:g} bugs!", randomInt);
            GameStats.bugsMade -= randomInt;
        }
        else
        {
            _infoText.text = string.Format("You DBugged {0:g} bugs!", GameStats.bugsMade);
            GameStats.bugsMade = 0;
        }
    }
}
