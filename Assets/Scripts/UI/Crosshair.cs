using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Transform ship;
    public float boresightDistance = 1000f;

    private void Update()
    {
        if (ship != null)
        {
            Vector3 boresightPos = (ship.transform.forward * boresightDistance) + ship.transform.position;
            Vector3 screenPos = Camera.main.WorldToScreenPoint(boresightPos);
            screenPos.z = 0f;

            transform.position = screenPos;
        }
    }
}