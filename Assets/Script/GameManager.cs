using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    waiting,
    playing,
    dying
}

public class GameManager : MonoBehaviour
{

    #region Singleton
    // doit être accessible de tous nos scripts = public + static
    public static GameManager Instance { get; private set; }


    public GameOverScreen GameOverScreen;
    public Steering SteeringWheel;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    #endregion


    public GameState gameState;


    [Header("Interface")]
    public GameObject UiBtnPlay;


    const float delayBeforeUI = 8f;
    public void StopGame()
    {
        gameState = GameState.dying;
        StartCoroutine(nameof(GameOver));
    }


    IEnumerator GameOver()
    {
        GameOverScreen.Setup();
        GameObject steeringWheel = GameObject.FindGameObjectWithTag("SteeringWheel");
        steeringWheel.SetActive(false);

        yield return new WaitForSeconds(delayBeforeUI);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LaunchGame()
    {
        UiBtnPlay.SetActive(false);
        Debug.Log("Starting");
        SteeringWheel.Setup();
        gameState = GameState.playing;
    }


    private void Start()
    {
        gameState = GameState.waiting;
    }
}