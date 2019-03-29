using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wallPiece" || other.gameObject.tag == "wallPieceStart")
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
            BoxCollider child = other.gameObject.GetComponentInChildren<BoxCollider>();
            if (child != gameObject.GetComponent<BoxCollider>())
            {
                child.isTrigger = false;
            }
            Destroy(gameObject);
        }
    }
}
