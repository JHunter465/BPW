using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject HowtoPlayHUD;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HowToPlay()
    {
        HowtoPlayHUD.SetActive(true);
    }
    public void BacktoMain()
    {
        HowtoPlayHUD.SetActive(false);
    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
