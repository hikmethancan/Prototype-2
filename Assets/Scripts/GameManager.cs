using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void GameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(0);
    }
}
