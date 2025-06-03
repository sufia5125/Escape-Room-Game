using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book1 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color mouseOverColor = Color.blue;
    private Color originalColor;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }
    }
    void OnMouseEnter()
    {
        spriteRenderer.color = mouseOverColor;
    }
    void OnMouseExit()
    {
        
        spriteRenderer.color = originalColor;
       
    }
}
