using UnityEngine;
using Cinemachine;

public class canSpawn : MonoBehaviour
{
    public GameObject PreviousPortal;
    public CinemachineVirtualCamera camera2d;
    public GameObject groundPos;
    public GameObject resetPos;
    public bool canSpawnHere = false;

    public bool canSpawnhere()
    {
        if (PreviousPortal.GetComponent<Spawner3d>().HasTeleported == true || canSpawnHere)
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SpecialBullet")
        {
            other.gameObject.GetComponentInParent<SpecBullet>().camera2d = camera2d;
            Debug.Log("canSpawn Doet het");
            other.gameObject.GetComponentInParent<SpecBullet>().transition(this.gameObject);
            FindObjectOfType<CharacterMovement2d>().resetPosition = resetPos;
            FindObjectOfType<CharacterMovement2d>().groundPos = groundPos;
        }
    }
}