using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Script : MonoBehaviour
{
    public int ScoreCount;
    public TextMeshProUGUI ScoreText;
    void Start()
    {
        ScoreCount = 0;
        ScoreText.text = "SCORE: " + ScoreCount.ToString();
        print("1");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SmallCoin"))
        {
            print("2");
            ScoreCount++;
            ScoreText.text = "SCORE: " + ScoreCount.ToString();
        }
    }
}
