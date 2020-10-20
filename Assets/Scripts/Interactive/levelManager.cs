using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class levelManager : MonoBehaviour
{

    private GameObject panelDocument;
    // Start is called before the first frame update
    void Start()
    {
        if (panelDocument == null) { panelDocument = GameObject.FindGameObjectWithTag("panelDocument"); }
        HideDocument();
    }

    public void ShowDocument(string DocumentName, Sprite DocumentImage)
    {
        if (panelDocument != null)
        {
            TextMeshProUGUI PanelDocumentName = panelDocument.transform.Find("View/DocumentName").gameObject.GetComponent<TextMeshProUGUI>(); 
            Image PanelDocumentImage =  panelDocument.transform.Find("View/DocumentDisplay").gameObject.GetComponent<Image>();
            PanelDocumentName.text = DocumentName;
            PanelDocumentImage.sprite = DocumentImage;
            panelDocument.SetActive(true);
        }

    }

    public void HideDocument()
    {
        if (panelDocument != null)
            panelDocument.SetActive(false);

    }
}
