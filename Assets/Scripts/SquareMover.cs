//WEEK ONE STUFF:

using UnityEngine;

public class SquareMover : MonoBehaviour
{
    public float xMax = 8;
    public float xMin = -8;
    public float moveSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //We can get access to the Transform component by typing "transform"

        //On the transform we can access the position which is a Vector3
        //Vector3 contains x y and z values grouped together
        //transform.position.x += 1f;

       

        //When assigning a value to a float, we want to append "f" to the end


    }

    // Update is called once per frame
    void Update()
    {


        Vector3 newPosition = transform.position;
        newPosition.x += moveSpeed;
        transform.position = newPosition;

        if (transform.position.x > xMax)
        {
          moveSpeed *= -1f;
        }
        
        if (transform.position.x < xMin)
        {
            moveSpeed *= -1f;
        }

    }
}
