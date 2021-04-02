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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ControlMap
        m_ControlMap = asset.FindActionMap("ControlMap", throwIfNotFound: true);
        m_ControlMap_W_Press = m_ControlMap.FindAction("W_Press", throwIfNotFound: true);
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
    public struct ControlMapActions
    {
        private @PlayerControls m_Wrapper;
        public ControlMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @W_Press => m_Wrapper.m_ControlMap_W_Press;
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
            }
            m_Wrapper.m_ControlMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @W_Press.started += instance.OnW_Press;
                @W_Press.performed += instance.OnW_Press;
                @W_Press.canceled += instance.OnW_Press;
            }
        }
    }
    public ControlMapActions @ControlMap => new ControlMapActions(this);
    public interface IControlMapActions
    {
        void OnW_Press(InputAction.CallbackContext context);
    }
}
