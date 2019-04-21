using UnityEngine;
using Cinemachine;

public class Gun : MonoBehaviour
{
    public GameObject specialBulletPrefab;
    public GameObject bulletPrefab;
    public Transform shootingPosition;

    public GameObject player2d;
    public CinemachineVirtualCamera camera2d;
    public CinemachineVirtualCamera camera3d;

    public GameObject player3d;
    public GameObject gunny;
    public Vector3 SpawnOffset2d;

    public float shootingForce = 1000;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootingPosition.position, shootingPosition.rotation);
        Rigidbody bulletRigidBody = bullet.GetComponent<Rigidbody>();
        bulletRigidBody.AddForce(shootingForce * bullet.transform.forward);
    }
    public void ShootSpecial()
    {
        GameObject specialBullet = Instantiate(specialBulletPrefab, shootingPosition.position, shootingPosition.rotation);
        SpecBullet _specBulScript = specialBullet.GetComponent<SpecBullet>();
        _specBulScript.player2d = player2d;
        _specBulScript.camera3d = camera3d;
        _specBulScript.player3d = player3d;
        _specBulScript.Gun = gunny;
        _specBulScript.spawnOffset2d = SpawnOffset2d;


        Rigidbody specialBulletRigibody = specialBullet.GetComponent<Rigidbody>();
        specialBulletRigibody.AddForce(shootingForce * specialBullet.transform.forward);
    }

    public void OnPickup(Transform parentTransform)
    {
        transform.SetParent(parentTransform);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
}
