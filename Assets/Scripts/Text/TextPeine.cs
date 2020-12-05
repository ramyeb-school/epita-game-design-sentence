using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPeine : MonoBehaviour
{

    public GameObject myText;
    public Investigation1 Investigation1;


    // Start is called before the first frame update
    void Start()
    {
        myText.GetComponent<UnityEngine.UI.Text>().text = "La peine que vous avez définit est de " + Investigation1.getPeine() + " années."; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
