using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUIManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] RectTransform Lives;
    private static int MyScore = 0;
    public void UpdateScore()
    {
        MyScore += 10;
        scoreText.text = MyScore.ToString();
    }
    public void DecreaseLive()
    {
        Destroy(Lives.GetChild(0).gameObject);
    }
}
