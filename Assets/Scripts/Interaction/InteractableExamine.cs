using UnityEngine;

public class InteractableExamine : InteractableObject
{
    public override void Interact()
    {
        Debug.Log($"Interacted with {gameObject}");
    }
}
