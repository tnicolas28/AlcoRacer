using System.Collections;
using System.Collections.Generic;
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

    private void Awake()
    {
        // Si une instance existe déjà,
        // et que je ne suis pas cette instance là
        // destruction !!!
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


    const float delayBeforeUI = 3f;
    public void StopGame()
    {
        gameState = GameState.dying;
        StartCoroutine(nameof(GameOver));
    }


    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(delayBeforeUI);


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        //UiBtnPlay.SetActive(true);
        //gameState = GameState.waiting;
    }



    public void LaunchGame()
    {
        UiBtnPlay.SetActive(false);

        gameState = GameState.playing;
    }


    private void Start()
    {
        gameState = GameState.waiting;
    }
}