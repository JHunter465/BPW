using UnityEngine;
using Cinemachine;

public class canSpawn : MonoBehaviour
{
    public GameObject PreviousPortal;
    public CinemachineVirtualCamera camera2d;
    public GameObject groundPos;
    public GameObject resetPos;
    public GameObject InvisiWall;
    public bool canSpawnHere = false;
    public Vector3 spawnOffset2d;

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
            if(canSpawnhere() == true)
            {
                other.gameObject.GetComponentInParent<SpecBullet>().camera2d = camera2d;
                Debug.Log("canSpawn Doet het");
                other.gameObject.GetComponentInParent<SpecBullet>().transition(this.gameObject);
                other.gameObject.GetComponentInParent<SpecBullet>().spawnOffset2d = spawnOffset2d;
                GameObject charactermovement = GameObject.Find("2dPlayer");
                charactermovement.GetComponent<CharacterMovement2d>().resetPosition = resetPos;
                charactermovement.GetComponent<CharacterMovement2d>().groundPos = groundPos;
                charactermovement.GetComponent<CharacterMovement2d>().camera2d = camera2d;
                charactermovement.GetComponent<CharacterMovement2d>().Start = gameObject;
                InvisiWall.SetActive(true);
            }
        }
    }
}