// GENERATED AUTOMATICALLY FROM 'Assets/Resources/EnoshimaActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @EnoshimaActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @EnoshimaActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""EnoshimaActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""bae401d7-6f31-4130-a424-16bc6cd855fe"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""19e6e823-0376-41ed-8268-47edcba9e24a"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""6ce5d787-89a0-480b-bebc-ac74b8d3a843"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""5440feb2-f283-44a3-9d69-87e4e9a6ac94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseView"",
                    ""type"": ""Value"",
                    ""id"": ""a22bbbdd-ca47-4f04-bea7-adbd8fcc5bc8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PhotoMode"",
                    ""type"": ""Button"",
                    ""id"": ""fd766c08-e675-4837-bda8-f66a630ac986"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TakePhoto"",
                    ""type"": ""Button"",
                    ""id"": ""f227fc0c-4924-477d-86fb-0e4ccbae91e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchFilter"",
                    ""type"": ""Button"",
                    ""id"": ""d84e441b-0c55-4cf3-befe-5123df43bf25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""fb099e07-2b98-4e8e-a358-2242ca144097"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interraction"",
                    ""type"": ""Button"",
                    ""id"": ""8c4882fd-46de-4829-a66b-03ef1e632e93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bb9b3136-669b-460b-bb8f-47f86ea9ce5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""02594d70-fd4a-431a-9fe7-0b045492b50b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""d039d9be-a172-45db-801d-450e8eb49f10"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8d0d19fe-11cd-48c7-87e8-72a13eaa0eb6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d0aae57a-57eb-4864-b40d-c20f0b455d4d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""89f36bd7-372d-4ac7-98fb-db608bbe3b50"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7ae2f90c-005a-4808-8719-9b54f0167265"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""304f903d-878e-43dd-b6d1-a4a1f2092def"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d6cd0ab-6856-4f58-b87c-ce62f05551b4"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50b3419c-70e4-48bf-aa7e-b584d257cf9b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a51a3773-bc82-4f25-9e29-ae64c428c6fd"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PhotoMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ed36d1f-a0ef-4504-a310-d568e7bf88ed"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakePhoto"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81ca8088-b41a-4d50-a865-3dbbb5cc280d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchFilter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e50614f-7669-4c0c-ae54-b5b81082c78e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""238931c8-15b5-49a1-bbae-134e934aad07"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interraction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48c3799e-f960-4259-add8-4178b50e51fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_MouseView = m_Player.FindAction("MouseView", throwIfNotFound: true);
        m_Player_PhotoMode = m_Player.FindAction("PhotoMode", throwIfNotFound: true);
        m_Player_TakePhoto = m_Player.FindAction("TakePhoto", throwIfNotFound: true);
        m_Player_SwitchFilter = m_Player.FindAction("SwitchFilter", throwIfNotFound: true);
        m_Player_Zoom = m_Player.FindAction("Zoom", throwIfNotFound: true);
        m_Player_Interraction = m_Player.FindAction("Interraction", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_MouseView;
    private readonly InputAction m_Player_PhotoMode;
    private readonly InputAction m_Player_TakePhoto;
    private readonly InputAction m_Player_SwitchFilter;
    private readonly InputAction m_Player_Zoom;
    private readonly InputAction m_Player_Interraction;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @EnoshimaActions m_Wrapper;
        public PlayerActions(@EnoshimaActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @MouseView => m_Wrapper.m_Player_MouseView;
        public InputAction @PhotoMode => m_Wrapper.m_Player_PhotoMode;
        public InputAction @TakePhoto => m_Wrapper.m_Player_TakePhoto;
        public InputAction @SwitchFilter => m_Wrapper.m_Player_SwitchFilter;
        public InputAction @Zoom => m_Wrapper.m_Player_Zoom;
        public InputAction @Interraction => m_Wrapper.m_Player_Interraction;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @MouseView.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseView;
                @MouseView.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseView;
                @MouseView.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseView;
                @PhotoMode.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPhotoMode;
                @PhotoMode.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPhotoMode;
                @PhotoMode.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPhotoMode;
                @TakePhoto.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakePhoto;
                @TakePhoto.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakePhoto;
                @TakePhoto.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakePhoto;
                @SwitchFilter.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchFilter;
                @SwitchFilter.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchFilter;
                @SwitchFilter.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchFilter;
                @Zoom.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnZoom;
                @Interraction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterraction;
                @Interraction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterraction;
                @Interraction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterraction;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @MouseView.started += instance.OnMouseView;
                @MouseView.performed += instance.OnMouseView;
                @MouseView.canceled += instance.OnMouseView;
                @PhotoMode.started += instance.OnPhotoMode;
                @PhotoMode.performed += instance.OnPhotoMode;
                @PhotoMode.canceled += instance.OnPhotoMode;
                @TakePhoto.started += instance.OnTakePhoto;
                @TakePhoto.performed += instance.OnTakePhoto;
                @TakePhoto.canceled += instance.OnTakePhoto;
                @SwitchFilter.started += instance.OnSwitchFilter;
                @SwitchFilter.performed += instance.OnSwitchFilter;
                @SwitchFilter.canceled += instance.OnSwitchFilter;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Interraction.started += instance.OnInterraction;
                @Interraction.performed += instance.OnInterraction;
                @Interraction.canceled += instance.OnInterraction;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnMouseView(InputAction.CallbackContext context);
        void OnPhotoMode(InputAction.CallbackContext context);
        void OnTakePhoto(InputAction.CallbackContext context);
        void OnSwitchFilter(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnInterraction(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
