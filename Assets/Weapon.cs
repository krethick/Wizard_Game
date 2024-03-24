using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Weapon : MonoBehaviour means Weapon inherits from MonoBehaviour
public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        // Transform is allows us to move objects in 2d or 3d space which has Position,Rotation and Scale
        // Vector3.zero is the center point for rotation
        // Vector3.forward moves around z axis
        // deltaTime=> The amount of time that passed from the last frame.
        
        // Right click ans select go to definition to check out the variable required

        // Using .(dot) allows us to access data and behaviors of any object defined in our scripts
        transform.RotateAround(Vector3.zero, Vector3.forward, 200 * Time.deltaTime);
    }
}
