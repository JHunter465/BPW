using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class Spawner3d : MonoBehaviour
{
    public GameObject player3d;
    public GameObject player2d;
    public GameObject Start;
    public GameObject Gun;
    public bool HasTeleported = false;

    public Transform spawnposition;

    public CinemachineVirtualCamera camera2d;
    public CinemachineVirtualCamera camera3d;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player2d.SetActive(false);
            player3d.transform.position = spawnposition.position;
            player3d.GetComponent<FirstPersonAIO>().enabled = true;
            player3d.GetComponent<playerController>().enabled = true;
            GameObject crosshair = GameObject.Find("Crosshair");
            crosshair.GetComponent<Image>().enabled = true;
            camera3d.enabled = true;
            camera2d.enabled = false;
            HasTeleported = true;
            Start.GetComponent<canSpawn>().InvisiWall.SetActive(false);
        }
    }
}
