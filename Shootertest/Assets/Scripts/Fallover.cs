using UnityEngine;

public class Fallover : MonoBehaviour
{
    public GameObject child;

    private void Update()
    {
        if(GetComponent<MeshRenderer>().enabled == true)
        {
            gameObject.layer = 12;
            child.layer = 12;
        }
    }
    public bool fallover()
    {
        return true;
    }
}
