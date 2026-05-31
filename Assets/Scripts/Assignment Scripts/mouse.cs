using UnityEngine;
using UnityEngine.InputSystem;

public class mouse : MonoBehaviour
{
    public float distanceThreshold = 1f;
    public Transform mustacheTarget;
    public Vector3 startValue;
    public Vector3 endValue;
    public float durationValue;
    public Vector3 currentValue;
    
    private float progress = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Convert the mouse position from screen space to world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePosition.z = 0f;

        // Calculate the distance between the mouse position and the mustache
        float distance = Vector3.Distance(mousePosition, mustacheTarget.position);

        // If the distance is less than the threshold then move the eyes, eyebrows, and ears up using the lerp function
        if (distance < distanceThreshold)
        {
            // Debug.Log("it worked");

            // Increase the progress to allow the Lerp to work and move the object from the start value to the end value over time
            progress += Time.deltaTime;

            //Lerp the objects from the start postion to the end position
            currentValue = Vector3.Lerp (transform.localPosition, endValue, progress / durationValue);

            //Set the position of the objects to the current value variable which is the lerp values
            transform.localPosition = currentValue;
        }
    }
}
