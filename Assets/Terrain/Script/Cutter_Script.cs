using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        // rotation des pièges rotatifs
        gameObject.transform.Rotate(new Vector3(0, 1, 0), 3.0f);
    }
}
