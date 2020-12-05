using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextInvestigation : MonoBehaviour
{

        public GameObject Panel;
        public GameObject NextPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoToNextInvestigation(){
            
        if(Panel!=null){
            Panel.SetActive(false);
        }
        if(NextPanel!=null){
            NextPanel.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
