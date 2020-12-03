using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Investigation1 : MonoBehaviour
{

    private String peine;
    private String amende;
    private String suspect;

    // Start is called before the first frame update
    void Start()
    {
        this.peine="0";
        this.amende="0";
        this.suspect="0";
    }

    public void setPeine(String peine){
        this.peine=peine;
    }
    
    public void setAmende(String amende){
        this.amende=amende;
    }
    
    public void setSuspect(String suspect){
        this.suspect=suspect;
    }

    public String getPeine(){
        return this.peine;
    }
    
    public String getAmende(){
       return this.amende;
    }
    
    public String getSuspect(){
        return this.suspect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
