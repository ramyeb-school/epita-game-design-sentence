using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeskViewButtonChangeView : MonoBehaviour
{

//    public GameObject Panel;
    public LevelCamera LevelCamera;
    public GameObject Panel;
    public GameObject BoardView;



    
    // Start is called before the first frame update
    void Start()
    {
    }

    public void changeView(){

        if(LevelCamera != null) {
            LevelCamera.MoveToBoard();
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
