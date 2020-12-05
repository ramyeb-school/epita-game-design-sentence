using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class levelManager : MonoBehaviour
{

    private GameObject panelDocument;
    public GameObject DeskViewPanel;
    public GameObject BoardViewPanel;
    public GameObject PanelImage;
    public GameObject PanelText;
    public GameObject myText;
    private GameObject CurrentViewPanel;


    // Start is called before the first frame update
    void Start()
    {
        if (panelDocument == null) { panelDocument = GameObject.FindGameObjectWithTag("panelDocument"); }

        HideDocument();
    }

    public void ShowDocument(string DocumentName, Sprite DocumentImage)
    {

        if (PanelText != null && PanelText.activeSelf){
            PanelText.SetActive(false);
        }
        if (PanelImage != null && !PanelImage.activeSelf){
            PanelImage.SetActive(true);
        }

        if (panelDocument != null && !panelDocument.activeSelf)
        {
            TextMeshProUGUI PanelDocumentName = panelDocument.transform.Find("View/DocumentName").gameObject.GetComponent<TextMeshProUGUI>(); 
            Image PanelDocumentImage =  panelDocument.transform.Find("View/DocumentDisplay").gameObject.GetComponent<Image>();
            PanelDocumentName.text = DocumentName;
            PanelDocumentImage.sprite = DocumentImage;
            if(DeskViewPanel!= null && DeskViewPanel.activeSelf){
                CurrentViewPanel = DeskViewPanel;
                DeskViewPanel.SetActive(false);
            }
            else if(BoardViewPanel!= null && BoardViewPanel.activeSelf){
                CurrentViewPanel = BoardViewPanel;
                BoardViewPanel.SetActive(false);
            }
            panelDocument.SetActive(true);
        }
        }

    public void ShowDocumentText(string DocumentName, string DocumentText)
    {

        
        if (PanelText != null && !PanelText.activeSelf){
            PanelText.SetActive(true);
        }
        if (PanelImage != null && PanelImage.activeSelf){
            PanelImage.SetActive(false);
        }

        if (panelDocument != null && !panelDocument.activeSelf)
        {
            myText.GetComponent<UnityEngine.UI.Text>().text = DocumentText; 
            TextMeshProUGUI PanelDocumentName = panelDocument.transform.Find("View/DocumentName").gameObject.GetComponent<TextMeshProUGUI>(); 
            PanelDocumentName.text = DocumentName;
            if(DeskViewPanel!= null && DeskViewPanel.activeSelf){
                CurrentViewPanel = DeskViewPanel;
                DeskViewPanel.SetActive(false);
            }
            else if(BoardViewPanel!= null && BoardViewPanel.activeSelf){
                CurrentViewPanel = BoardViewPanel;
                BoardViewPanel.SetActive(false);
            }
            panelDocument.SetActive(true);
        }
    }


    public void HideDocument()
    {
        if (panelDocument != null)
            panelDocument.SetActive(false);
        if (CurrentViewPanel != null)
            CurrentViewPanel.SetActive(true);
    }
}
