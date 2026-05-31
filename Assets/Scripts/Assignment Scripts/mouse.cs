using UnityEngine;
using UnityEngine.InputSystem;

public class mouse : MonoBehaviour
{
    public float mustacheTarget;
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
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePosition.z = 0f;

        float distance = Vector3.Distance(mousePosition, transform.position);

        if (distance < mustacheTarget)
        {
            Debug.Log("it worked");

            progress += Time.deltaTime;

            currentValue = Vector3.Lerp (startValue, endValue, progress / durationValue);

            transform.position = currentValue;
        }
    }
}
