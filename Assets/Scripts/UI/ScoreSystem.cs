using UnityEngine;
using TMPro;
public class ScoreSystem : MonoBehaviour
{
    public TextMeshProUGUI _text;

    private void OnEnable()
    {
        _text.text = "Asteroids destroyed:";
    }

    public void UpdateScore(int score)
    {
        _text.SetText("Asteroids destroyed: " + score);
    }
}
