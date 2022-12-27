using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;

public class Increment : MonoBehaviour
{


    public TextMeshProUGUI ScoreValue;

    private float score;

    void Start()
    {
        score = float.Parse(ScoreValue.text, CultureInfo.InvariantCulture.NumberFormat);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameState != GameState.playing) return;

        score += Time.deltaTime % 60;
        ScoreValue.text = score.ToString("0");

    }

}
