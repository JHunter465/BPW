using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class CharacterMovement2d : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 1f;
    private float horizontalmove;
    private bool jump = false;
    public GameObject resetPosition;
    public GameObject groundPos;
    public Rigidbody rb;
    public int coins = 0;
    public GameObject player3d;
    public CinemachineVirtualCamera camera3d;
    public CinemachineVirtualCamera camera2d;
    public GameObject Start;

    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (transform.position.y <= groundPos.transform.position.y)
        {
            Invoke("resetPos", 1);
        }
        if (Input.GetButtonDown("Exit1"))
        {
            gameObject.SetActive(false);
            player3d.GetComponent<FirstPersonAIO>().enabled = true;
            player3d.GetComponent<playerController>().enabled = true;
            camera3d.enabled = true;
            camera2d.enabled = false;
            GameObject crosshair = GameObject.Find("Crosshair");
            crosshair.GetComponent<Image>().enabled = true;
            Start.GetComponent<canSpawn>().InvisiWall.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    private void resetPos()
    {
        transform.position = new Vector3(resetPosition.transform.position.x, resetPosition.transform.position.y, resetPosition.transform.position.z);
        rb.velocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coins")
        {
            Destroy(other.gameObject);
            coins++;
            FindObjectOfType<SceneManagert>().Addcoins(coins);
        }
        if (other.gameObject.GetComponent<Fallover>() != null)
        {
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
