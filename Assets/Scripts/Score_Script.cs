using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Script : MonoBehaviour
{
    public int ScoreCount;
    public TextMeshGUI ScoreText;
    void Start()
    {
        ScoreCount = 0;
        ScoreText.text = "SCORE: " + ScoreCount.ToString();
    }

    private void OnCollizionEnter(Collizion collizion)
    {
        if (collision.gameObject.CompareTag("SmallCoin"))
        {
            ScoreCount++;
            ScoreText.text = "SCORE: " + ScoreCount.ToString();
        }
    }
}
