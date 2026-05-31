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
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //This is to have the timer increase at a steady rate
        timer += Time.deltaTime;
        //This is to move the sweat around on the spot
        transform.localPosition =  startPos + curve.Evaluate(timer/duration) * Vector3.right;
        
    }
}
