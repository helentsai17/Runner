using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //run one time 
    }

    // Update is called once per frame
    void Update()
    {
        //happen every frame per seconds
        transform.Rotate(45.0f * Time.deltaTime, 0, 0);
    }
}
