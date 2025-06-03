using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PianoOrderManager : MonoBehaviour
{
    public int[] rightOrder = { 3, 5, 4, 2, 0 };
    public List<int> currentOrder = new List<int>();
    public GameObject winBox;
    public GameObject door;
    public GameObject doorOpen;
    void Start()
    {
        Debug.Log("Piano game initialized.");
    }

    private void AddToCurrentOrder(int numberToAdd)
    {
        if (currentOrder.Count >= rightOrder.Length)
        {
            currentOrder.RemoveAt(0);
            Debug.Log("Oldest element removed");
        }
        currentOrder.Add(numberToAdd);
        Debug.Log("Note added to list: " + numberToAdd);
        CheckWin();
    }

    private void CheckWin()
    {
        if (currentOrder.Count != rightOrder.Length)
        {
            return;
        }

        for (int i = 0; i < rightOrder.Length; i++)
        {
            if (rightOrder[i] != currentOrder[i])
            {
                Debug.Log("Not a match");
                return;
            }
        }
        Debug.Log("WINNNNNN");
        winBox.SetActive(true);
        door.GetComponent<Button>().interactable=true;
        doorOpen.SetActive(true);
    }

    // Note click handlers
    public void NoteAClicked(){ AddToCurrentOrder(0);}
    public void NoteBClicked(){AddToCurrentOrder(1);}
    public void NoteCClicked() {AddToCurrentOrder(2);}
    public void NoteDClicked(){AddToCurrentOrder(3);}
    public void NoteEClicked(){ AddToCurrentOrder(4); }
    public void NoteFClicked(){AddToCurrentOrder(5);}
    public void NoteGClicked(){AddToCurrentOrder(6);}
}
