using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
            Debug.Log(Investigation1.getSuspect());
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
