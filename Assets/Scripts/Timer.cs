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
        //Start Increasing the progress at a steady rate with Time.deltaTime
        progress += Time.deltaTime;
        Debug.Log(progress);

        //Created a condition that once progress reaches the duration spawn the gameobject somewhere random in the gameview
        if(progress > duration)
        {
            //Show timer is up so player knows that the gameobject is gonna spawn somewhere random
            Debug.Log("Timer is Up");
            //Create a new position for the game object to randomly spawn in game view with a random x and y value 
            transform.position = new Vector3 (Random.Range(0,9), Random.Range(0, 5), 0);
            //after the progress reaches the duration reset the progress to have the gameobject keep on spawning over and over
            progress = 0f;
            
        }
    }
}
