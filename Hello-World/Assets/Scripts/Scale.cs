using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            transform.localScale = transform.localScale + new Vector3(5, 5, 5);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            transform.localScale = transform.localScale + new Vector3(-5, -5, -5);
        }
    }
}
