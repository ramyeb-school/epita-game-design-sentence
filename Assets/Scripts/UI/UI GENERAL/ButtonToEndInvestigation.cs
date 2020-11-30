using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonToEndInvestigation : MonoBehaviour
{

        public LevelCamera LevelCamera;
        public GameObject EndIvestigation;
        public GameObject DeskView;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShowEndIvestigation(){
        if (EndIvestigation != null){
         EndIvestigation.SetActive(true);
        }
        if(DeskView != null){
         DeskView.SetActive(false);
        }
        if(LevelCamera != null) {
            LevelCamera.MoveToDesk2();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
