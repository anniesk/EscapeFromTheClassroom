// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/CursorControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CursorControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CursorControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CursorControls"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""80d78501-e43a-48ae-a09d-68d1dbfe1414"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""c293f84c-d11a-4069-ad87-a164929e81be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ed264158-8419-4e56-ac1b-6f7d7cd95e3b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""id"": ""edee4e0c-eaec-4324-ab03-a94f97de8ca5"",
            ""actions"": [
                {
                    ""name"": ""rightArrow"",
                    ""type"": ""Button"",
                    ""id"": ""23849f32-e947-41f5-8dc7-0863e588f6c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftArrow"",
                    ""type"": ""Button"",
                    ""id"": ""bc3b1d93-41a5-44e9-acfa-3360cad5b376"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""upArrow"",
                    ""type"": ""Button"",
                    ""id"": ""687bb365-1add-4a3f-8d88-b1600449df16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""downArrow"",
                    ""type"": ""Button"",
                    ""id"": ""79a0e640-7dde-4219-9345-8c172127a70d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ae14c5a9-aa4b-4c46-a9dc-aab7aec7756c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""rightArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e45dcf86-be04-47e1-bd59-b90097364e92"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""leftArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79ce74c5-0baf-4f8e-9a76-1549eb338844"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""upArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3ce6f50-7497-42ef-bcdc-717784fde744"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""downArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Click = m_Mouse.FindAction("Click", throwIfNotFound: true);
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_rightArrow = m_Keyboard.FindAction("rightArrow", throwIfNotFound: true);
        m_Keyboard_leftArrow = m_Keyboard.FindAction("leftArrow", throwIfNotFound: true);
        m_Keyboard_upArrow = m_Keyboard.FindAction("upArrow", throwIfNotFound: true);
        m_Keyboard_downArrow = m_Keyboard.FindAction("downArrow", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_Click;
    public struct MouseActions
    {
        private @CursorControls m_Wrapper;
        public MouseActions(@CursorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Mouse_Click;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_rightArrow;
    private readonly InputAction m_Keyboard_leftArrow;
    private readonly InputAction m_Keyboard_upArrow;
    private readonly InputAction m_Keyboard_downArrow;
    public struct KeyboardActions
    {
        private @CursorControls m_Wrapper;
        public KeyboardActions(@CursorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @rightArrow => m_Wrapper.m_Keyboard_rightArrow;
        public InputAction @leftArrow => m_Wrapper.m_Keyboard_leftArrow;
        public InputAction @upArrow => m_Wrapper.m_Keyboard_upArrow;
        public InputAction @downArrow => m_Wrapper.m_Keyboard_downArrow;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @rightArrow.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightArrow;
                @rightArrow.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightArrow;
                @rightArrow.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightArrow;
                @leftArrow.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftArrow;
                @leftArrow.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftArrow;
                @leftArrow.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftArrow;
                @upArrow.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUpArrow;
                @upArrow.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUpArrow;
                @upArrow.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUpArrow;
                @downArrow.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDownArrow;
                @downArrow.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDownArrow;
                @downArrow.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDownArrow;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @rightArrow.started += instance.OnRightArrow;
                @rightArrow.performed += instance.OnRightArrow;
                @rightArrow.canceled += instance.OnRightArrow;
                @leftArrow.started += instance.OnLeftArrow;
                @leftArrow.performed += instance.OnLeftArrow;
                @leftArrow.canceled += instance.OnLeftArrow;
                @upArrow.started += instance.OnUpArrow;
                @upArrow.performed += instance.OnUpArrow;
                @upArrow.canceled += instance.OnUpArrow;
                @downArrow.started += instance.OnDownArrow;
                @downArrow.performed += instance.OnDownArrow;
                @downArrow.canceled += instance.OnDownArrow;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    public interface IMouseActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
    public interface IKeyboardActions
    {
        void OnRightArrow(InputAction.CallbackContext context);
        void OnLeftArrow(InputAction.CallbackContext context);
        void OnUpArrow(InputAction.CallbackContext context);
        void OnDownArrow(InputAction.CallbackContext context);
    }
}
