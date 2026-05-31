using UnityEngine;

public class ShakingEyes : MonoBehaviour
{
    public AnimationCurve curve;
    public float timer;
    public float duration;
    private Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Create starting position to store the current transform.position values
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //This is to have the timer increase at a steady rate
        timer += Time.deltaTime;
        //This is to move the eyes from left to right and I used the startPos varaible and added it to the curve.evaulate to take in the original position and add the curve values to it to move the eyes left and right
        transform.localPosition =  startPos + curve.Evaluate(timer/duration) * Vector3.right;
        
    }
}
