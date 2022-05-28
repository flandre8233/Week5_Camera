using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x , transform.eulerAngles.y + (Time.deltaTime * 15) , transform.eulerAngles.z);
    }
}
