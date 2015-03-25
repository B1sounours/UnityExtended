using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class LevelButton : MonoBehaviour
{
    public UnityEvent onInteract;

    public bool IsInteractable = true;

    public bool Interact()
    {
        // is the button disabled?
        if (!IsInteractable)
        {
            // failure
            return false;
        }

        onInteract.Invoke();
        return true;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
