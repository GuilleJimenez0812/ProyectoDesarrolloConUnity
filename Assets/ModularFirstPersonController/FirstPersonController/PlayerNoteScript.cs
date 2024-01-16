using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNoteScript : MonoBehaviour
{
    private NoteScript activeNote;
    private SubsScript activeSub;
    private GameObject interactMessage;  
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        interactMessage = GameObject.Find("InteractMessage");
        interactMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (activeNote)
        {
            if (Input.GetKeyDown("e"))
            {
                activeNote.ToggleNote();
            }
        }
        if (activeSub)
        {
            activeSub.ToggleSub(num);
            activeSub = null;
        }
    }

    private void OnTriggerEnter(Collider other) {     
        switch (other.gameObject.tag){
            case "Note":
                other.gameObject.TryGetComponent(out activeNote);
                interactMessage.SetActive(true);
                break;
            case "Sub1":
                other.gameObject.TryGetComponent(out activeSub);
                num = 1;               
                break;
            case "Sub2":
                other.gameObject.TryGetComponent(out activeSub);
                num = 2;               
                break;
            case "Sub3":
                other.gameObject.TryGetComponent(out activeSub);
                num = 3;               
                break;
            case "Sub4":
                other.gameObject.TryGetComponent(out activeSub);
                num = 4;               
                break;
            case "Sub5":
                other.gameObject.TryGetComponent(out activeSub);
                num = 5;               
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Note")
        {
            if(activeNote.GetNoteStatus())
            {
                activeNote.ToggleNote();
            }
            activeNote = null;
            interactMessage.SetActive(false);
        }
    }
}
