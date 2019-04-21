using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class Endlevel : MonoBehaviour
{
    public Text endlevelText;
    public GameObject player2d;
    public GameObject player3d;
    public GameObject QuitGameButton;
    public CinemachineVirtualCamera endCamera;
    public ICinemachineCamera ActiveVirtualCamera { get; }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player2d.SetActive(false);
            player3d.SetActive(false);
            //player3d.GetComponent<FirstPersonAIO>().enabled = false;
            //player3d.GetComponent<playerController>().enabled = false;
            //player3d.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            endCamera.enabled = true;
            endlevelText.enabled = true;
            QuitGameButton.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
}
