using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchGame : MonoBehaviour
{
    public LevelCamera LevelCamera;
    public GameObject DeskView;
    public GameObject PanelMenu;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Launch(){
        if(PanelMenu!=null){
            PanelMenu.SetActive(false);
        }
        if(DeskView!=null){
        DeskView.SetActive(true);
        }
        if(LevelCamera!=null){
        LevelCamera.startGame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
