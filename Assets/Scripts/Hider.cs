using UnityEngine;
using UnityEngine.InputSystem;

public class Hider : MonoBehaviour
{
    public Vector3 hidePosition;
    public float hideDistanceThreshold;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //reads the position of the mouse in pixels
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        // changes the cursor pixel values into world space
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;

        //enter this section of code if the mouse is close to the object
        float distance = Vector3.Distance(worldMousePosition, transform.position);

        //Debug.Log(distance);

        if (distance < hideDistanceThreshold)
        {
            //sets the position of the square to the value manually inputed in unity
            transform.position = hidePosition;
        }

        
        
    }
}
