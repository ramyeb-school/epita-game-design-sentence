using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardViewButtonChangeView : MonoBehaviour
{

    public LevelCamera LevelCamera;
    public GameObject Panel;
    public GameObject DeskView;
    public int numInvestigation;


    // Start is called before the first frame update
    void Start()
    {
    }

    
    public void changeView(){

        if (numInvestigation==1 && LevelCamera != null){
            LevelCamera.MoveToDesk();

        }else if(numInvestigation==2 && LevelCamera != null){
            LevelCamera.MoveToDesk2();
        }
        if(Panel!=null){
            Panel.SetActive(false);
        }
        if(DeskView!=null){
            DeskView.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
