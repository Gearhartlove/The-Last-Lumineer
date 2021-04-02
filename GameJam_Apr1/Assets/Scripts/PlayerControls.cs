// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""ControlMap"",
            ""id"": ""f4646fbb-314c-4e26-98b7-32de10b41e50"",
            ""actions"": [
                {
                    ""name"": ""W_Press"",
                    ""type"": ""Button"",
                    ""id"": ""56d655b6-d3a9-4355-8c8a-d677b8fb24d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A_Press"",
                    ""type"": ""Button"",
                    ""id"": ""d46b8c8a-a244-4f57-b4c4-767280c1f1f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D_Press"",
                    ""type"": ""Button"",
                    ""id"": ""198fea7a-ff2a-4d5f-8539-05f15050fa82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Space_Press"",
                    ""type"": ""Button"",
                    ""id"": ""be20ab4d-665c-4cac-8f58-8ce2be5a0fd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""75692c84-3918-46c2-bb01-dfa363a7b5db"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""W_Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad5d5d94-6ba5-41cb-9c7e-2a74c251cad6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A_Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb2d9e4b-7268-46a1-96aa-d544f4c1eb2a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D_Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f0c1df6-9fc7-44ed-9837-83bcd0635086"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space_Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ControlMap
        m_ControlMap = asset.FindActionMap("ControlMap", throwIfNotFound: true);
        m_ControlMap_W_Press = m_ControlMap.FindAction("W_Press", throwIfNotFound: true);
        m_ControlMap_A_Press = m_ControlMap.FindAction("A_Press", throwIfNotFound: true);
        m_ControlMap_D_Press = m_ControlMap.FindAction("D_Press", throwIfNotFound: true);
        m_ControlMap_Space_Press = m_ControlMap.FindAction("Space_Press", throwIfNotFound: true);
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

    // ControlMap
    private readonly InputActionMap m_ControlMap;
    private IControlMapActions m_ControlMapActionsCallbackInterface;
    private readonly InputAction m_ControlMap_W_Press;
    private readonly InputAction m_ControlMap_A_Press;
    private readonly InputAction m_ControlMap_D_Press;
    private readonly InputAction m_ControlMap_Space_Press;
    public struct ControlMapActions
    {
        private @PlayerControls m_Wrapper;
        public ControlMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @W_Press => m_Wrapper.m_ControlMap_W_Press;
        public InputAction @A_Press => m_Wrapper.m_ControlMap_A_Press;
        public InputAction @D_Press => m_Wrapper.m_ControlMap_D_Press;
        public InputAction @Space_Press => m_Wrapper.m_ControlMap_Space_Press;
        public InputActionMap Get() { return m_Wrapper.m_ControlMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlMapActions set) { return set.Get(); }
        public void SetCallbacks(IControlMapActions instance)
        {
            if (m_Wrapper.m_ControlMapActionsCallbackInterface != null)
            {
                @W_Press.started -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnW_Press;
                @W_Press.performed -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnW_Press;
                @W_Press.canceled -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnW_Press;
                @A_Press.started -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnA_Press;
                @A_Press.performed -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnA_Press;
                @A_Press.canceled -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnA_Press;
                @D_Press.started -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnD_Press;
                @D_Press.performed -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnD_Press;
                @D_Press.canceled -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnD_Press;
                @Space_Press.started -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnSpace_Press;
                @Space_Press.performed -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnSpace_Press;
                @Space_Press.canceled -= m_Wrapper.m_ControlMapActionsCallbackInterface.OnSpace_Press;
            }
            m_Wrapper.m_ControlMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @W_Press.started += instance.OnW_Press;
                @W_Press.performed += instance.OnW_Press;
                @W_Press.canceled += instance.OnW_Press;
                @A_Press.started += instance.OnA_Press;
                @A_Press.performed += instance.OnA_Press;
                @A_Press.canceled += instance.OnA_Press;
                @D_Press.started += instance.OnD_Press;
                @D_Press.performed += instance.OnD_Press;
                @D_Press.canceled += instance.OnD_Press;
                @Space_Press.started += instance.OnSpace_Press;
                @Space_Press.performed += instance.OnSpace_Press;
                @Space_Press.canceled += instance.OnSpace_Press;
            }
        }
    }
    public ControlMapActions @ControlMap => new ControlMapActions(this);
    public interface IControlMapActions
    {
        void OnW_Press(InputAction.CallbackContext context);
        void OnA_Press(InputAction.CallbackContext context);
        void OnD_Press(InputAction.CallbackContext context);
        void OnSpace_Press(InputAction.CallbackContext context);
    }
}
