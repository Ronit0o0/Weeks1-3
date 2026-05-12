using UnityEngine;

public class Timer : MonoBehaviour
{
    public float duration;
    float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;
        Debug.Log(progress);

        if(progress > duration)
        {
            Debug.Log("Timer is Up");
            transform.position = new Vector3 (Random.Range(0,9), Random.Range(0, 5), 0);
            progress = 0f;
            
        }
    }
}
