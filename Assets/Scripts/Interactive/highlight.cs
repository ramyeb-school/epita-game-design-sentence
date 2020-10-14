using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlight : MonoBehaviour
{
[SerializeField] private Color highlightColor = Color.yellow;
     [SerializeField] private Renderer ownRenderer = null;
 
     private Color[] originalColors;
     private void Start() {
         if (ownRenderer == null) { ownRenderer = GetComponent<Renderer>(); }
         StoreOriginalColor();
     }
     private void StoreOriginalColor () {
         if (ownRenderer != null) {
             Material[] materials = ownRenderer.materials;
             originalColors = new Color[materials.Length];
             for (int i = 0; i < materials.Length; ++i) { originalColors[i] = materials[i].color; }
         }
     }


     private void OnMouseEnter() {
         if (ownRenderer != null) {
             Material[] materials = ownRenderer.materials;
             for (int i = 0; i < materials.Length; ++i) { materials[i].color = Color.Lerp(materials[i].color,highlightColor,0.5f ) ; }
             ownRenderer.materials = materials;
         }
     }
     private void OnMouseExit() {
         if (ownRenderer != null) {
             Material[] materials = ownRenderer.materials;
             for (int i = 0; i < materials.Length; ++i) { materials[i].color = originalColors[i]; }
             ownRenderer.materials = materials;
         }        
     }
}