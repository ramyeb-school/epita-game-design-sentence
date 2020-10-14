using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{

    private GameObject panelDocument;
    // Start is called before the first frame update
    void Start()
    {
        if (panelDocument == null) { panelDocument = GameObject.FindGameObjectWithTag("panelDocument"); }
        HideDocument();
    }

    public void ShowDocument()
    {
        if (panelDocument != null)
            panelDocument.SetActive(true);

    }

    public void HideDocument()
    {
        if (panelDocument != null)
            panelDocument.SetActive(false);

    }
}
