using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class documentText : MonoBehaviour
{
    // Used for highligthing.
    [SerializeField] private string DocumentName;

    private string DocumentText;
    public string FileName;

    [SerializeField] private Color highlightColor = Color.yellow;

    private Renderer ownRenderer = null;
    private Color[] originalColors;

    // Used to display document.
    private GameObject levelManager;
    private void Start()
    {
        if (ownRenderer == null) { ownRenderer = GetComponent<Renderer>(); }
        StoreOriginalColor();
        if (levelManager == null) { levelManager = GameObject.FindGameObjectWithTag("levelManager"); }
                Debug.Log("Script lancé");
        
        string[] tableauDoc = System.IO.File.ReadAllLines(@"Assets/Scripts/Text/"+FileName);
        for(int i=0; i<tableauDoc.Length; i++){
            DocumentText += tableauDoc[i] + '\n';
        }
    }
    private void StoreOriginalColor()
    {
        if (ownRenderer != null)
        {
            Material[] materials = ownRenderer.materials;
            originalColors = new Color[materials.Length];
            for (int i = 0; i < materials.Length; ++i) { originalColors[i] = materials[i].color; }
        }
    }


    private void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        return;
        if (ownRenderer != null)
        {
            Material[] materials = ownRenderer.materials;
            for (int i = 0; i < materials.Length; ++i) { materials[i].color = Color.Lerp(materials[i].color, highlightColor, 0.5f); }
            ownRenderer.materials = materials;
        }
    }
    private void OnMouseExit()
    {
        if(EventSystem.current.IsPointerOverGameObject())
        return;
        if (ownRenderer != null)
        {
            Material[] materials = ownRenderer.materials;
            for (int i = 0; i < materials.Length; ++i) { materials[i].color = originalColors[i]; }
            ownRenderer.materials = materials;
        }
    }

        public void OnMouseDown()
    {
        OnMouseExit();
        if(EventSystem.current.IsPointerOverGameObject())
        return;

        if(levelManager != null) {
            levelManager.GetComponent<levelManager>().ShowDocumentText(DocumentName,DocumentText);
        }

    }
}

