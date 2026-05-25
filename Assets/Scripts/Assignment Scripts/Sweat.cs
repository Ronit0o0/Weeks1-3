using UnityEngine;

public class Sweat : MonoBehaviour
{
    
    public Vector3 startValue;
    public Vector3 endValue;
    public float durationValue;
    public Vector3 currentValue;
    private float progress = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Increase the progress to allow the Lerp to work and move the object from the start value to the end value over time
        progress += Time.deltaTime;

        //Lerp the position of the object from the start value to the end value based on the progress and duration
        currentValue = Vector3.Lerp (startValue, endValue, progress / durationValue);

        //Sets the position of the object to currentValue which is the value from the Lerp function
        transform.position = currentValue;
        
    }
}
