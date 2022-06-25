using UnityEngine;
using UnityEngine.UI;

public class DebugButton : MonoBehaviour
{
    public Button Button;
    public Text InfoText;

    void Start()
    {
        Button.onClick.AddListener(DebugCode);
    }

    void DebugCode()
    {
        int randomInt = Random.Range(1, 10);
        if (randomInt >= GameStats.BugsMade)
        {
            InfoText.text = string.Format("You DBugged {0:g} bugs!", randomInt);
            GameStats.BugsMade -= randomInt;
        }
        else
        {
            InfoText.text = string.Format("You DBugged {0:g} bugs!", GameStats.BugsMade);
            GameStats.BugsMade = 0;
        }
    }
}
