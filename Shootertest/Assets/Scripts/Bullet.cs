using UnityEngine;

public class Bullet : MonoBehaviour
{
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
