using UnityEngine;

public class playerController : MonoBehaviour
{
    public Transform gunPosition;

    private Gun currentGun;

    void Update()
    {
        if (currentGun != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                currentGun.Shoot();
            }
            if (Input.GetMouseButtonDown(1))
            {
                currentGun.ShootSpecial();
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        Gun gun = col.gameObject.GetComponent<Gun>();
        if (gun != null)
        {
            currentGun = gun;
            currentGun.OnPickup(gunPosition);
        }
    }
}
