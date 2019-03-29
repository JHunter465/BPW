using UnityEngine;

public class Start2d : MonoBehaviour
{
    private bool renderer;
    public GameObject player2;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HELLO WORLD");

        if (other.gameObject.name.Contains("Spec"))
        {
            Debug.Log("JEMOEDER");
            renderer = GetComponentInParent<Renderer>().enabled;
            Debug.Log(renderer);
            if (renderer)
            {
                player2.SetActive(true);
                Debug.Log("Camera 2");
            }
        }
    }
}