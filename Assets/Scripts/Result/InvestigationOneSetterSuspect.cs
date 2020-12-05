using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class InvestigationOneSetterSuspect : MonoBehaviour
{

    public Investigation1 Investigation1;
    public String suspectNumber;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setSuspectInInvestigation(){
        if(Investigation1!=null){
            Investigation1.setSuspect(suspectNumber);
        }

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
