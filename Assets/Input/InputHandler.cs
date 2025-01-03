using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputHandler : MonoBehaviour
{
    // Define events for input actions
    public event Action<Vector2> OnLeftStick;
    public event Action<Vector2> OnRightStick;
    public event Action OnButtonNorth;
    public event Action OnButtonSouth;
    public event Action OnButtonEast;
    public event Action OnButtonWest;
    public event Action<float> OnLeftTrigger;
    public event Action<float> OnRightTrigger;
    public event Action OnLeftShoulder;
    public event Action OnRightShoulder;
    public event Action OnLeftStickPress;
    public event Action OnRightStickPress;
    public event Action OnPadLeft;
    public event Action OnPadRight;
    public event Action OnPadUp;
    public event Action OnPadDown;
    public event Action OnLeftStickLeft;
    public event Action OnLeftStickRight;
    public event Action OnLeftStickUp;
    public event Action OnLeftStickDown;
    public event Action OnButtonStart;
    public event Action OnButtonSelect;

    // Reference to the Input Actions asset
    [SerializeField] private InputActionAsset inputActions;

    // Cached input actions
    private InputAction leftStickAction;
    private InputAction rightStickAction;
    
    private InputAction buttonNorthAction;
    private InputAction buttonSouthAction;
    private InputAction buttonEastAction;
    private InputAction buttonWestAction;
    
    private InputAction leftTriggerAction;
    private InputAction rightTriggerAction;

    private InputAction leftShoulderAction;
    private InputAction rightShoulderAction;
    
    private InputAction leftStickPressAction;
    private InputAction rightStickPressAction;
    
    private InputAction padLeftAction;
    private InputAction padRightAction;
    private InputAction padUpAction;
    private InputAction padDownAction;
    
    private InputAction leftStickLeftAction;
    private InputAction leftStickRightAction;
    private InputAction leftStickUpAction;
    private InputAction leftStickDownAction;
    
    private InputAction buttonStartAction;
    private InputAction buttonSelectAction;

    private void Awake()
    {
        // Get individual input actions
        var playerInputMap = inputActions.FindActionMap("Player"); // Replace "Player" with your action map name
        
        leftStickAction = playerInputMap.FindAction("LeftStick");
        rightStickAction = playerInputMap.FindAction("RightStick");

        buttonWestAction = playerInputMap.FindAction("ButtonWest");
        buttonSouthAction = playerInputMap.FindAction("ButtonSouth");
        buttonNorthAction = playerInputMap.FindAction("ButtonNorth");
        buttonEastAction = playerInputMap.FindAction("ButtonEast");

        leftTriggerAction = playerInputMap.FindAction("LeftTrigger");
        rightTriggerAction = playerInputMap.FindAction("RightTrigger");

        leftShoulderAction = playerInputMap.FindAction("LeftShoulder");
        rightShoulderAction = playerInputMap.FindAction("RightShoulder");
        leftStickPressAction = playerInputMap.FindAction("LeftStickPress");
        rightStickPressAction = playerInputMap.FindAction("RightStickPress");

        padLeftAction = playerInputMap.FindAction("PadLeft");
        padRightAction = playerInputMap.FindAction("PadRight");
        padUpAction = playerInputMap.FindAction("PadUp");
        padDownAction = playerInputMap.FindAction("PadDown");

        leftStickLeftAction = playerInputMap.FindAction("LeftStickLeft");
        leftStickRightAction = playerInputMap.FindAction("LeftStickRight");
        leftStickUpAction = playerInputMap.FindAction("LeftStickUp");
        leftStickDownAction = playerInputMap.FindAction("LeftStickDown");

        buttonStartAction = playerInputMap.FindAction("ButtonStart");
        buttonSelectAction = playerInputMap.FindAction("ButtonSelect");
    }

    private void OnEnable()
    {
        // Enable input actions
        leftStickAction.Enable();
        rightStickAction.Enable();
        buttonWestAction.Enable();
        buttonSouthAction.Enable();
        buttonNorthAction.Enable();
        buttonEastAction.Enable();
        leftTriggerAction.Enable();
        rightTriggerAction.Enable();
        leftShoulderAction.Enable();
        rightShoulderAction.Enable();
        leftStickPressAction.Enable();
        rightStickPressAction.Enable();
        padLeftAction.Enable();
        padRightAction.Enable();
        padUpAction.Enable();
        padDownAction.Enable();
        leftStickLeftAction.Enable();
        leftStickRightAction.Enable();
        leftStickUpAction.Enable();
        leftStickDownAction.Enable();
        buttonStartAction.Enable();
        buttonSelectAction.Enable();

        // Subscribe to input action callbacks
        leftStickAction.performed += HandleLeftStick;
        leftStickAction.canceled += HandleLeftStick; // To detect stop moving
        rightStickAction.performed += HandleRightStick;
        rightStickAction.canceled += HandleRightStick; // To detect stop looking
        buttonWestAction.performed += HandleButtonWest;
        buttonSouthAction.performed += HandleButtonSouth;
        buttonNorthAction.performed += HandleButtonNorth;
        buttonEastAction.performed += HandleButtonEast;
        leftTriggerAction.performed += HandleLeftTrigger;
        rightTriggerAction.performed += HandleRightTrigger;
        leftShoulderAction.performed += HandleLeftShoulder;
        rightShoulderAction.performed += HandleRightShoulder;
        leftStickPressAction.performed += HandleLeftStickPress;
        rightStickPressAction.performed += HandleRightStickPress;
        padLeftAction.performed += HandlePadLeft;
        padRightAction.performed += HandlePadRight;
        padUpAction.performed += HandlePadUp;
        padDownAction.performed += HandlePadDown;
        leftStickLeftAction.performed += HandleLeftStickLeft;
        leftStickRightAction.performed += HandleLeftStickRight;
        leftStickUpAction.performed += HandleLeftStickUp;
        leftStickDownAction.performed += HandleLeftStickDown;
        buttonStartAction.performed += HandleButtonStart;
        buttonSelectAction.performed += HandleButtonSelect;
    }

    private void OnDisable()
    {
        // Unsubscribe to avoid memory leaks
        leftStickAction.performed -= HandleLeftStick;
        leftStickAction.canceled -= HandleLeftStick;
        rightStickAction.performed -= HandleRightStick;
        rightStickAction.canceled -= HandleRightStick;
        buttonWestAction.performed -= HandleButtonWest;
        buttonSouthAction.performed -= HandleButtonSouth;
        buttonNorthAction.performed -= HandleButtonNorth;
        buttonEastAction.performed -= HandleButtonEast;
        leftTriggerAction.performed -= HandleLeftTrigger;
        rightTriggerAction.performed -= HandleRightTrigger;
        leftShoulderAction.performed -= HandleLeftShoulder;
        rightShoulderAction.performed -= HandleRightShoulder;
        leftStickPressAction.performed -= HandleLeftStickPress;
        rightStickPressAction.performed -= HandleRightStickPress;
        padLeftAction.performed -= HandlePadLeft;
        padRightAction.performed -= HandlePadRight;
        padUpAction.performed -= HandlePadUp;
        padDownAction.performed -= HandlePadDown;
        leftStickLeftAction.performed -= HandleLeftStickLeft;
        leftStickRightAction.performed -= HandleLeftStickRight;
        leftStickUpAction.performed -= HandleLeftStickUp;
        leftStickDownAction.performed -= HandleLeftStickDown;
        buttonStartAction.performed -= HandleButtonStart;
        buttonSelectAction.performed -= HandleButtonSelect;

        // Disable input actions
        leftStickAction.Disable();
        rightStickAction.Disable();
        buttonWestAction.Disable();
        buttonSouthAction.Disable();
        buttonNorthAction.Disable();
        buttonEastAction.Disable();
        leftTriggerAction.Disable();
        rightTriggerAction.Disable();
        leftShoulderAction.Disable();
        rightShoulderAction.Disable();
        leftStickPressAction.Disable();
        rightStickPressAction.Disable();
        padLeftAction.Disable();
        padRightAction.Disable();
        padUpAction.Disable();
        padDownAction.Disable();
        leftStickLeftAction.Disable();
        leftStickRightAction.Disable();
        leftStickUpAction.Disable();
        leftStickDownAction.Disable();
        buttonStartAction.Disable();
        buttonSelectAction.Disable();
    }

    // Input event handlers
    private void HandleLeftStick(InputAction.CallbackContext context)
    {
        var input = context.ReadValue<Vector2>();
        OnLeftStick?.Invoke(input);
    }

    private void HandleRightStick(InputAction.CallbackContext context)
    {
        var input = context.ReadValue<Vector2>();
        OnRightStick?.Invoke(input);
    }

    private void HandleButtonWest(InputAction.CallbackContext context)
    {
        OnButtonWest?.Invoke();
    }

    private void HandleButtonSouth(InputAction.CallbackContext context)
    {
        OnButtonSouth?.Invoke();
    }

    private void HandleButtonNorth(InputAction.CallbackContext context)
    {
        OnButtonNorth?.Invoke();
    }

    private void HandleButtonEast(InputAction.CallbackContext context)
    {
        OnButtonEast?.Invoke();
    }
    
    private void HandleLeftTrigger(InputAction.CallbackContext context)
    {
        var input = context.ReadValue<float>();
        OnLeftTrigger?.Invoke(input);
    }
    
    private void HandleRightTrigger(InputAction.CallbackContext context)
    {
        var input = context.ReadValue<float>();
        OnRightTrigger?.Invoke(input);
    }
    
    private void HandleLeftShoulder(InputAction.CallbackContext context)
    {
        OnLeftShoulder?.Invoke();
    }
    
    private void HandleRightShoulder(InputAction.CallbackContext context)
    {
        OnRightShoulder?.Invoke();
    }
    
    private void HandleLeftStickPress(InputAction.CallbackContext context)
    {
        OnLeftStickPress?.Invoke();
    }
    
    private void HandleRightStickPress(InputAction.CallbackContext context)
    {
        OnRightStickPress?.Invoke();
    }
    
    private void HandlePadLeft(InputAction.CallbackContext context)
    {
        OnPadLeft?.Invoke();
    }
    
    private void HandlePadRight(InputAction.CallbackContext context)
    {
        OnPadRight?.Invoke();
    }
    
    private void HandlePadUp(InputAction.CallbackContext context)
    {
        OnPadUp?.Invoke();
    }
    
    private void HandlePadDown(InputAction.CallbackContext context)
    {
        OnPadDown?.Invoke();
    }
    
    private void HandleLeftStickLeft(InputAction.CallbackContext context)
    {
        OnLeftStickLeft?.Invoke();
    }
    
    private void HandleLeftStickRight(InputAction.CallbackContext context)
    {
        OnLeftStickRight?.Invoke();
    }
    
    private void HandleLeftStickUp(InputAction.CallbackContext context)
    {
        OnLeftStickUp?.Invoke();
    }
    
    private void HandleLeftStickDown(InputAction.CallbackContext context)
    {
        OnLeftStickDown?.Invoke();
    }
    
    private void HandleButtonStart(InputAction.CallbackContext context)
    {
        OnButtonStart?.Invoke();
    }
    
    private void HandleButtonSelect(InputAction.CallbackContext context)
    {
        OnButtonSelect?.Invoke();
    }
}
