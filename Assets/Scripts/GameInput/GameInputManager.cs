using UnityEngine;

public class GameInputManager : MonoBehaviour
{
    public static GameInputManager Instance { get; private set; }
    
    private GameInputAction gameInputAction;

    private void Awake()
    {
        InitializeInstance();
        InitializeGameInputAction();
    }

    private void InitializeInstance()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void InitializeGameInputAction()
    {
        gameInputAction = new GameInputAction();
        
        gameInputAction.Player.Enable();
    }
    
    public Vector2 GetMovementVector() => gameInputAction.Player.Move.ReadValue<Vector2>();
}
