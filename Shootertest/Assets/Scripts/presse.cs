using UnityEngine;

public class presse : MonoBehaviour
{
    public GameObject OpenPanel;
    public GameObject player;
    public GameObject Lights;

    public int Maxrange;

    private bool inRange = false;

    private void OnMouseOver()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist <= Maxrange)
        {
            OpenPanel.SetActive(true);
            inRange = true;

        }
    }

    private void OnMouseExit()
    {
        OpenPanel.SetActive(false);
        inRange = false;
    }

    private void OnMouseDown()
    {
        if (inRange)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Lights.SetActive(true);
            }
        }
    }
}
