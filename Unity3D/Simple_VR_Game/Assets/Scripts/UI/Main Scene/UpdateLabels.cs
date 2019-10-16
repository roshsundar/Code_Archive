using UnityEngine;
public class UpdateLabels : MonoBehaviour
{
    public TextMesh Score_LBL;

    int score = 0;

    void Start()
    {
        Score_LBL.text = "Score: " + score.ToString();
    }

    public void UpdateScore()
    {
        score++;
        Score_LBL.text = "Score: " + score.ToString();
    }
}
