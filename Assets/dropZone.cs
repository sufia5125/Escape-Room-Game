using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler
{
    public int dropZoneIndex; 
    BookOrderManager bookOrderManager;
    private void Start()
    {
        bookOrderManager = FindObjectOfType<BookOrderManager>();     //this is just this program looking for the right bookordermanager class in the scene
    }
    public void OnDrop(PointerEventData eventData)
    {
        
        if(eventData.pointerDrag != null)
        {
            Debug.Log("Item dropped!");
            RectTransform droppedBook = eventData.pointerDrag.GetComponent<RectTransform>();     //this is the consistent positions of our book while being dragged 
            droppedBook.anchoredPosition=GetComponent<RectTransform>().anchoredPosition;  //this is to make it snap(drop) to centre of dropzone
            int index = droppedBook.GetComponent<Index>().index;      //get the index of book you just dropped

            bookOrderManager.UpdateCurrentOrder(index, dropZoneIndex); //assign the bookIndex to the dropzone it is on
            
        }
    }
}
