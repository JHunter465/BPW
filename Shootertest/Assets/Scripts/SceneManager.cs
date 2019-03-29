using UnityEngine.UI;
using UnityEngine;

public class SceneManager : MonoBehaviour
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
}
