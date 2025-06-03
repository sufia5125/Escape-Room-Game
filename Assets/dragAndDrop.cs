using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler,IDragHandler{
    private RectTransform rectTransform;
    [SerializeField] private Canvas canvas;
    
    CanvasGroup canvasGroup;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    
    public void OnDrag(PointerEventData eventData)
    {        
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; 
     }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false; //idk what this means is k beghair snap nahi horha tha 
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Drag ended");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

    }
}
