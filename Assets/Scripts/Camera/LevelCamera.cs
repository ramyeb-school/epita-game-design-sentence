using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCamera : MonoBehaviour
{


    // Start is called before the first frame update
    public Transform currentPosition = null;
    public Transform deskPosition = null;
    public Transform boardPosition = null;
    public Transform startPosition = null;
    public float speed = 1;
 
    private GameObject mainCamera = null;

    void Update()
    {
        if (mainCamera != null)
        {
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, currentPosition.transform.position, speed * Time.deltaTime);
            mainCamera.transform.rotation =  Quaternion.Lerp (mainCamera.transform.rotation, currentPosition.transform.rotation, speed * Time.deltaTime);
        }
    }
    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
            mainCamera.transform.position = startPosition.transform.position;
            
        }
        MoveToDesk();
    }

    public void MoveToDesk()
    {
        currentPosition = deskPosition;
    }

    public void MoveToBoard()
    {
        currentPosition = boardPosition;
    }
}
