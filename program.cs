using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationProject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.right, Vector3.up, 40 * Time.deltaTime);
    }
}
