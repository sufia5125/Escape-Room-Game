using UnityEngine;

public class KeyClick : MonoBehaviour
{
    public PianoOrderManager pianoManager;
    public void clickA(){ pianoManager.NoteAClicked();  }
    public void clickB() { pianoManager.NoteBClicked(); }
    public void clickC() { pianoManager.NoteCClicked(); }       
    public void clickD() { pianoManager.NoteDClicked(); } 
    public void clickE() { pianoManager.NoteEClicked(); }
    public void clickF() {pianoManager.NoteFClicked(); }
    public void clickG() { pianoManager.NoteGClicked(); }
}
