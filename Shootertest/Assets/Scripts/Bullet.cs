using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int increment = 0;

    private void Update()
    {
        if (increment == 2)
        {
            Destroy(gameObject);
        }
        Destroy(gameObject, 5.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        increment += 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wallPiece" || other.gameObject.tag == "wallPieceStart")
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
            other.gameObject.GetComponentsInChildren<BoxCollider>()[1].isTrigger = false;
            Destroy(gameObject);
        }
    }
}
