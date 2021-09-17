using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The part of the the health that decreases")]
    private RectTransform m_HealthBar;

    [SerializeField]
    [Tooltip("The text displaying the score of the player.")]
    private Text m_CurrentScore;

    [SerializeField]
    [Tooltip("The text displaying the number of enemies killed.")]
    private Text m_EnemiesKilled;
    #endregion

    #region Private Variables
    private float p_HealthBarOrigWidth;
    private int p_Score;
    private int p_EnemiesKilled;
    #endregion

    #region Initialization
    private void Awake() {
        p_HealthBarOrigWidth = m_HealthBar.sizeDelta.x;
        p_Score = 0;
        p_EnemiesKilled = 0;
        UpdateCurrentScore(0);
        UpdateEnemiesKilled(0);
    }
    #endregion

    #region Update Health Bar
    public void UpdateHealth(float percent) {
        m_HealthBar.sizeDelta = new Vector2(p_HealthBarOrigWidth * percent, m_HealthBar.sizeDelta.y);
    }
    #endregion

    #region Update Current Score Text
    public void UpdateCurrentScore(int amount) {
        p_Score += amount;
        m_CurrentScore.text = "Score: " + p_Score.ToString();
    }
    #endregion

    #region Update Number of Enemies Killed Text
    public void UpdateEnemiesKilled(int number) {
        if (number != 0) {
            p_EnemiesKilled += number;
        }
        m_EnemiesKilled.text = "Enemies Killed: " + p_EnemiesKilled.ToString();
    }
    #endregion
}
