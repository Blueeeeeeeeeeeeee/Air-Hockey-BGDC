using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameUI : MonoBehaviour
{
    float oldTime;
    [SerializeField] private Powerups powerup;
    [SerializeField] private float currentTime = 5f;
    [SerializeField] private float interval = 10f;
    [SerializeField] private TMP_Text timeText;

    [SerializeField] private AudioSource uiSound;
    [SerializeField] private TMP_Text endText;
    [SerializeField] private GameObject endUI;

    [SerializeField] private int WinScore = 10;
    [SerializeField] private TMP_Text score;
    int scorePl1 = 0;
    int scorePl2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "Timer:\n" + currentTime.ToString("0") + " S";
        oldTime = currentTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timeText.text = timeText.text.Replace(oldTime.ToString("0"), currentTime.ToString("0"));
        oldTime = currentTime;
        if (currentTime <= 0)
        {
            powerup.triggerRandomPowerup();
            currentTime = interval;
        }
    }

    public void UpdateScore()
    {
        score.text = "Score:\n" + scorePl1.ToString() + " : " + scorePl2.ToString();
    }

    public void Addscore(bool isPlayerHole)
    {
        if (isPlayerHole) scorePl2 += 1;
        else scorePl1 += 1;
        UpdateScore();

    }

    public void ResetScore()
    {
        scorePl1 = 0;
        scorePl2 = 0;
    }

    public void CheckWinner()
    {
        string winner = "";
        if (scorePl1 >= WinScore)
        {
            winner = "Player";
        }
        else if (scorePl2 >= WinScore)
        {
            winner = "Enemy";
        }
        else return;
        endUI.SetActive(true);
        endText.text = winner + " Win";
        Time.timeScale = 0;
    }

    public void RetryButton()
    {
        StartCoroutine(RetryGame());
    }

    public void MenuButton()
    {
        StartCoroutine(MenuGame());
    }

    IEnumerator RetryGame()
    {
        uiSound.Play();
        yield return new WaitForSecondsRealtime(0.4f);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator MenuGame()
    {
        uiSound.Play();
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
