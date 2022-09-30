using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComportamento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        var xDir = Input.GetAxis("Horizontal");
        
        transform.Translate(xDir*0.005f,0,0.005f);
    }
}
