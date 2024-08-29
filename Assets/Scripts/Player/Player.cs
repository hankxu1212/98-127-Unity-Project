using System;
using UnityEngine;

public partial class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    
    private CharacterController controller;
    
    public enum PlayerState
    {
        Idle,
        Walking,
        Falling,
        Dead,
    }
    
    private PlayerState state;
    
    public bool IsIdle() => state == PlayerState.Idle;
    public bool IsWalking() => state == PlayerState.Walking;
    public bool IsFalling() => state == PlayerState.Falling;
    public bool IsDead() => state == PlayerState.Dead;
    
    private void ChangeStateTo(PlayerState nextState)
    {
        if (state == nextState || IsDead())
            return;
        state = nextState;
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
        
        // initiate state
        ChangeStateTo(PlayerState.Idle);
        
        // get controllers
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        HandleMovement();
    }
    
    /// <summary>
    /// Turn player towards a certain direction for a single frame
    /// </summary>
    /// <param name="direction">direction to move to</param>
    /// <param name="turnSpeed">slerp speed. If speed is negative, transform.forward is sync-ed instantly</param>
    private void Turn(Vector3 direction, float turnSpeed)
    {
        if (direction == Vector3.zero || turnSpeed == 0)
            return;
        
        if (turnSpeed < 0)
            transform.forward = direction; // signal to turn instantly    
        else
            transform.forward = Vector3.Slerp(transform.forward, direction, turnSpeed * Time.deltaTime);
    }

    public Vector3 RemapCameraAngle(Vector2 input)
    {
        Vector3 forward = Camera.main.transform.forward;
        forward.y = 0;
        Vector3 right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        forward *= input.y;
        right *= input.x;
        return (forward + right).normalized;
    }

    private void HandleMovement()
    {
        // TODO: A1.1 obtain game input vector2 and fix camera angle
        
        // TODO: A1.2 How do I use CharacterController..? You will need to handle both turning and moving
    }

    private void HandleFall()
    {
        // TODO: A1.3 Implement falling here

        if (controller.isGrounded) // is the controller grounded in this frame?
        {
            if (IsFalling())
            {
                
            }
            else
            {
                
            }
        }
        else
        {
            if (IsFalling())
            {
                
            }
            else
            {
                
            }
        }
    }
}