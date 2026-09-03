using UnityEngine;

public class RestartOnTouch : MonoBehaviour
{
    public Transform startPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = startPoint.position;
        }
    }
}