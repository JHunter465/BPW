using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagert : MonoBehaviour
{
    public Text coinCount;

    private void Start()
    {
        coinCount.text = " ";
    }
    public void Addcoins(int coins)
    {
        coinCount.text = coins.ToString() ;
    }
    public void QuittoMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
