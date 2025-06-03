using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BookOrderManager : MonoBehaviour
{
    public int[] currentOrder ;  //im gonna index acc to correct order of books
    public int[] rightOrder;
    public GameObject panel;
    public GameObject vaseButton;
    public GameObject winBox;
    private const string EndReached = "AAAAAA";

    void Start()
    {
        currentOrder = new int[rightOrder.Length];  //initialize it to be 6 items long
        Debug.Log("List tayyar");
    }

    public void UpdateCurrentOrder(int index, int dropZoneIndex)
    {
        currentOrder[dropZoneIndex] = index;   //mtlb currentorder[1]=3 means 1st dropzone pr book no 3 hai  
        checkWinCondition();
    }
    private void checkWinCondition()
    {
        bool winCondition = true;
        for (int i = 0; i < rightOrder.Length; ++i)
        {
            if (currentOrder[i] != rightOrder[i])
            {
                winCondition = false;
                Debug.Log("you didnt win :<");
                break;
            }
        }
        if (winCondition)
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAaa");
            Debug.Log("YOU WIN");
            winBox.SetActive(true);
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                Debug.Log("Now go play piano LING LING");
                PlayerPrefs.SetInt(EndReached, 200); // 200 means true
                PlayerPrefs.Save();
                Debug.Log("EndReached is set to 200");
            }
            vaseButton.GetComponent<Button>().interactable=true;
            vaseButton.GetComponent<Button>().transition=Selectable.Transition.ColorTint;
            
        }
    }
}

