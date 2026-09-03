using UnityEngine;

public class MovingTrap : MonoBehaviour
{
    public float moveDistance = 6f;
    public float speed = 0.1f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float yOffset = Mathf.PingPong(Time.time * speed, moveDistance);

        transform.position = startPosition + Vector3.up * yOffset;
    }
}