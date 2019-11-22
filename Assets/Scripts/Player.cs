using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -30)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * 10.0f);

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * 10.0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * 10.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * 10.0f, ForceMode.Impulse);
        }
    }
}
