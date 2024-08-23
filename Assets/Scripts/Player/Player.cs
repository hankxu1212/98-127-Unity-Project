using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    
    private CharacterController controller;
    
    public enum PlayerState
    {
        Idle
        // TODO: A1 add more states here! 
    }
    
    private void Awake()
    {
        // initiate player instance
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        
        // get controllers
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // TODO: A1 obtain game input vector2
        // .. How do I use CharacterController..?
    }
}