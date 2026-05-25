using UnityEngine;

public class Bobbing : MonoBehaviour
{
    //This is the curve that I will adjust in the inspector to create the bobbing affect    
    public AnimationCurve curve;
    //This timer variable will be used to change the Y position of the Duck
    public float timer;
    //This variable is to control the speed of the bobbing affect in the inspector
    public float duration;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is to have the timer increase at a steady rate
        timer += Time.deltaTime;
        //This is to change the Y position of the Duck based on the curve and the timer
        transform.position =  curve.Evaluate(timer/duration) * Vector3.up;  

    }


}
