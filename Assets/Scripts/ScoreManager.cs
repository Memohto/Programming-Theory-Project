using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreText;

    public int Score { get; private set; }

    private void Awake()
    {
        UpdateScore(0);
    }

    public void UpdateScore(int scoreToAdd) {
        string name = GameManager.Instance == null ? "Name" : GameManager.Instance.Name;
        Score += scoreToAdd;
        scoreText.text = $"Score ({name}): {Score}";
    }
}
