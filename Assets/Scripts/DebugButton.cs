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
