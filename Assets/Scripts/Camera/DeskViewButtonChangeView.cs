using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeskViewButtonChangeView : MonoBehaviour
{

//    public GameObject Panel;
    public LevelCamera LevelCamera;
    public GameObject Panel;
    public GameObject BoardView;
    public int numInvestigation;



    
    // Start is called before the first frame update
    void Start()
    {
    }

    public void changeView(){
        if (numInvestigation==1 && LevelCamera != null){
            LevelCamera.MoveToBoard();

        }else if(numInvestigation==2 && LevelCamera != null){
            LevelCamera.MoveToBoard2();
        }

        if(Panel!=null){
            Panel.SetActive(false);
        }
        if(BoardView!=null){
            BoardView.SetActive(true);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
