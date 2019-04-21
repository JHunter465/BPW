using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class SpecBullet : MonoBehaviour
{
    public GameObject player2d;
    public GameObject player3d;
    public GameObject Gun;

    public CinemachineVirtualCamera camera2d;
    public CinemachineVirtualCamera camera3d;

    public Vector3 spawnOffset2d;

    public void transition(GameObject other)
    {
        if (other.gameObject.tag == "wallPieceStart")
        {
            if (other.gameObject.GetComponent<canSpawn>().canSpawnhere() == true)
            {
                if (other.GetComponent<MeshRenderer>().enabled == true)
                {
                    Debug.Log("voor" + player2d.transform.position);
                    Rigidbody rb = player3d.GetComponent<Rigidbody>();
                    rb.velocity = new Vector3(0, 0, 0);
                    GameObject crosshair = GameObject.Find("Crosshair");
                    crosshair.GetComponent<Image>().enabled = false;
                    player3d.GetComponent<FirstPersonAIO>().enabled = false;
                    player3d.GetComponent<playerController>().enabled = false;
                    camera2d.enabled = true;
                    camera3d.enabled = false;
                    player2d.SetActive(true);
                    player2d.transform.position = other.transform.position + spawnOffset2d;
                    player2d.transform.rotation = other.transform.rotation;
                    Debug.Log("other" + other.transform.position);
                    Debug.Log("na" + player2d.transform.position);
                    player2d.GetComponent<CharacterMovement2d>().groundPos = other.GetComponent<canSpawn>().groundPos;
                    player2d.GetComponent<CharacterMovement2d>().resetPosition = other.GetComponent<canSpawn>().resetPos;
                    player2d.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    Destroy(gameObject);

                }
            }
        }
    }
}