using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("YOU WIN!");
        }
    }
}