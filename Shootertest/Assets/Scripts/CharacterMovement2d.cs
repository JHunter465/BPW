using UnityEngine;

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
            FindObjectOfType<SceneManager>().Addcoins(coins);
        }
    }
}
