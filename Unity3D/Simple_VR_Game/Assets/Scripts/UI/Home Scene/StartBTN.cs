using UnityEngine;
using KetosGames.SceneTransition;

public class StartBTN : MonoBehaviour
{
    public void ChangeColorOnHover()
    {
        this.transform.GetChild(0).GetComponent<TextMesh>().color = new Color(255, 255, 255, 0.5f);
    }

    public void RevertColorOnExit()
    {
        this.transform.GetChild(0).GetComponent<TextMesh>().color = new Color(255, 255, 255, 1f);
    }

    public void LoadScene_Main()
    {
        SceneLoader.LoadScene("Main");
    }
}
