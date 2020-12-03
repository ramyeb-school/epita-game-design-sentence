using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InvestigationOneSetter : MonoBehaviour
{
    public Investigation1 Investigation1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setPeineInInvestigation(String peine){
        if(Investigation1!=null){
            Investigation1.setPeine(peine);
            Debug.Log(Investigation1.getPeine());
        }
    }

        public void setAmendeInInvestigation(String amende){
        if(Investigation1!=null){
            Investigation1.setAmende(amende);
            Debug.Log(Investigation1.getAmende());
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
