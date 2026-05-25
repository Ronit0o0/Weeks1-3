using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float xMax = 8f;
    public float xMin = -8f;
    public float yMax = 4.5f;
    public float yMin = -4.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += moveSpeed;
        newPosition.y += moveSpeed;
        transform.position = newPosition;

        if (transform.position.x > xMax)
        {
            moveSpeed *= -1f;
        }

        if (transform.position.x < xMin)
        {
            moveSpeed *= -1f;
        }

        if(transform.position.y > yMax)
        {
            moveSpeed *= -1f;
        }

        if (transform.position.y < yMin)
        {
            moveSpeed *= -1f;
        }
    }
}
