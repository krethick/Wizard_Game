using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Weapon : MonoBehaviour means Weapon inherits from MonoBehaviour
public class Weapon : MonoBehaviour
{
    [SerializeField] // This show the rotationSpeed in the Inspector of the Game object(Weapon) but can't be modified.
    private int rotationSpeed = 200;
    // Start is called before the first frame update

    [SerializeField]
    private Vector3 rotationPoint = Vector3.zero;
    void Start()
    {
        
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
         
        float rotationAmount = rotationSpeed * Time.deltaTime;
        transform.RotateAround(rotationPoint, Vector3.forward, rotationAmount);
    }
}
