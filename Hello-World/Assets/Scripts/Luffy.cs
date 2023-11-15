using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luffy : MonoBehaviour
{
    private bool on = true;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<MeshRenderer>().enabled = !on;
            on = !on;
        }
    }
}
