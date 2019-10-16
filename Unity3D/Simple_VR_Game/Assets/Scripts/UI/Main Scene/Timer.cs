using KetosGames.SceneTransition;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMesh Time_LBL;

    public int startSeconds;
    public string time;

    void Start()
    {
        UpdateTime();
        InvokeRepeating("decrementSeconds", 1, 1);
    }

    void decrementSeconds()
    {
        if (!(startSeconds <= 0))
        {
            startSeconds--;
            UpdateTime();
        }
        else
        {
            SceneLoader.LoadScene("Home");
        }
    }

    void UpdateTime()
    {
        time = (startSeconds / 60).ToString() + ":" + (startSeconds % 60).ToString("00");
        Time_LBL.text = time;
    }
}
