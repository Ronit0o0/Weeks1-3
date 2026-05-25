using UnityEngine;

public class Guard : MonoBehaviour
{
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
        progress += Time.deltaTime;
        currentValue = Vector3.Lerp (startValue, endValue, progress / durationValue);
        //Debug.Log(currentValue);
        transform.position = currentValue;
        //Debug.Log("progress: " + progress + " duration: " + durationValue);
        if (progress > durationValue)
        { 
            progress = 0f;
        }
    }
}
