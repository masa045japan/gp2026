using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int combo = 0;
    public TextMeshProUGUI scoreText; // スコアを表示するテキスト

    // スコア加算
    public void AddScore()
    {
        score += 10;
        combo++;

        // コンボボーナス
        if (combo >= 2)
            score += combo - 1;

        string formattedScore = score.ToString("D4"); // スコアを4桁の文字列に変換
        scoreText.text = formattedScore;
    }

    // コンボのリセット
    public void ResetCombo()
    {
        combo = 0;
    }
}