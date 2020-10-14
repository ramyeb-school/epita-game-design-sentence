using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paperScript : MonoBehaviour
{

        float spinSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){ 
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);

    }

    // Update is called once per frame
    void Update()
    {

    }

}
