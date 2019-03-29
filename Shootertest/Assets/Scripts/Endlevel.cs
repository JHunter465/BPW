using UnityEngine;

public class Endlevel : MonoBehaviour
{
    public GameObject endlevelText;
    public GameObject player2d;
    public GameObject player3d;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player2d.SetActive(false);
        player3d.GetComponent<FirstPersonAIO>().enabled = false;
        endlevelText.SetActive(true);
    }
}
