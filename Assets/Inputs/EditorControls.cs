// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/EditorControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @EditorControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @EditorControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""EditorControls"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""dd42cce5-e479-469a-83f2-632f7149a4b6"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""63d40b5b-e955-49e7-a541-df3ce754f60a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""192a048a-c0fe-429a-a343-66ba2d681af1"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomStart"",
                    ""type"": ""Button"",
                    ""id"": ""552d8d11-e35d-4b6a-b8a5-7d8fca3d4ef3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateStart"",
                    ""type"": ""Button"",
                    ""id"": ""79dd1adc-4fa6-45a0-b972-c4f2691eaa05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnableCameraControls"",
                    ""type"": ""Button"",
                    ""id"": ""bb95b722-598c-4a96-9e08-20902b412b32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""180ec2b8-28ac-4cbf-88d8-f66f956f0536"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3dfab9f-7229-4800-bbcf-10da2be9a0e7"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eac8235-0b20-44e8-bc02-aa21d32c2441"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e74980bc-7d78-4529-a018-bb9a6c6d4dd0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91bf5bf3-a125-4663-983a-b9dcdbd6d9ce"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableCameraControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Edit"",
            ""id"": ""43481082-25fe-4eb9-bd74-bc726770584f"",
            ""actions"": [
                {
                    ""name"": ""EditPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e87e2a8a-4424-4348-b347-b500961cfa08"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Edit"",
                    ""type"": ""Button"",
                    ""id"": ""7dc6846e-0b39-455d-a03a-4650a1e91dc1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DisableEdits"",
                    ""type"": ""Button"",
                    ""id"": ""154a06f2-0546-428c-a860-12a8e1908f54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""500c444f-0353-4e23-b90b-568bff66681e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EditPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7e5faa3-b11f-439e-9d85-b4a89b18260a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Edit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97024b2b-2605-415d-bb93-00340974a47d"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DisableEdits"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Rotate = m_Camera.FindAction("Rotate", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
        m_Camera_ZoomStart = m_Camera.FindAction("ZoomStart", throwIfNotFound: true);
        m_Camera_RotateStart = m_Camera.FindAction("RotateStart", throwIfNotFound: true);
        m_Camera_EnableCameraControls = m_Camera.FindAction("EnableCameraControls", throwIfNotFound: true);
        // Edit
        m_Edit = asset.FindActionMap("Edit", throwIfNotFound: true);
        m_Edit_EditPosition = m_Edit.FindAction("EditPosition", throwIfNotFound: true);
        m_Edit_Edit = m_Edit.FindAction("Edit", throwIfNotFound: true);
        m_Edit_DisableEdits = m_Edit.FindAction("DisableEdits", throwIfNotFound: true);
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

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Rotate;
    private readonly InputAction m_Camera_Zoom;
    private readonly InputAction m_Camera_ZoomStart;
    private readonly InputAction m_Camera_RotateStart;
    private readonly InputAction m_Camera_EnableCameraControls;
    public struct CameraActions
    {
        private @EditorControls m_Wrapper;
        public CameraActions(@EditorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Camera_Rotate;
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
        public InputAction @ZoomStart => m_Wrapper.m_Camera_ZoomStart;
        public InputAction @RotateStart => m_Wrapper.m_Camera_RotateStart;
        public InputAction @EnableCameraControls => m_Wrapper.m_Camera_EnableCameraControls;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @ZoomStart.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoomStart;
                @ZoomStart.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoomStart;
                @ZoomStart.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoomStart;
                @RotateStart.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateStart;
                @RotateStart.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateStart;
                @RotateStart.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateStart;
                @EnableCameraControls.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnEnableCameraControls;
                @EnableCameraControls.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnEnableCameraControls;
                @EnableCameraControls.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnEnableCameraControls;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @ZoomStart.started += instance.OnZoomStart;
                @ZoomStart.performed += instance.OnZoomStart;
                @ZoomStart.canceled += instance.OnZoomStart;
                @RotateStart.started += instance.OnRotateStart;
                @RotateStart.performed += instance.OnRotateStart;
                @RotateStart.canceled += instance.OnRotateStart;
                @EnableCameraControls.started += instance.OnEnableCameraControls;
                @EnableCameraControls.performed += instance.OnEnableCameraControls;
                @EnableCameraControls.canceled += instance.OnEnableCameraControls;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Edit
    private readonly InputActionMap m_Edit;
    private IEditActions m_EditActionsCallbackInterface;
    private readonly InputAction m_Edit_EditPosition;
    private readonly InputAction m_Edit_Edit;
    private readonly InputAction m_Edit_DisableEdits;
    public struct EditActions
    {
        private @EditorControls m_Wrapper;
        public EditActions(@EditorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @EditPosition => m_Wrapper.m_Edit_EditPosition;
        public InputAction @Edit => m_Wrapper.m_Edit_Edit;
        public InputAction @DisableEdits => m_Wrapper.m_Edit_DisableEdits;
        public InputActionMap Get() { return m_Wrapper.m_Edit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EditActions set) { return set.Get(); }
        public void SetCallbacks(IEditActions instance)
        {
            if (m_Wrapper.m_EditActionsCallbackInterface != null)
            {
                @EditPosition.started -= m_Wrapper.m_EditActionsCallbackInterface.OnEditPosition;
                @EditPosition.performed -= m_Wrapper.m_EditActionsCallbackInterface.OnEditPosition;
                @EditPosition.canceled -= m_Wrapper.m_EditActionsCallbackInterface.OnEditPosition;
                @Edit.started -= m_Wrapper.m_EditActionsCallbackInterface.OnEdit;
                @Edit.performed -= m_Wrapper.m_EditActionsCallbackInterface.OnEdit;
                @Edit.canceled -= m_Wrapper.m_EditActionsCallbackInterface.OnEdit;
                @DisableEdits.started -= m_Wrapper.m_EditActionsCallbackInterface.OnDisableEdits;
                @DisableEdits.performed -= m_Wrapper.m_EditActionsCallbackInterface.OnDisableEdits;
                @DisableEdits.canceled -= m_Wrapper.m_EditActionsCallbackInterface.OnDisableEdits;
            }
            m_Wrapper.m_EditActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EditPosition.started += instance.OnEditPosition;
                @EditPosition.performed += instance.OnEditPosition;
                @EditPosition.canceled += instance.OnEditPosition;
                @Edit.started += instance.OnEdit;
                @Edit.performed += instance.OnEdit;
                @Edit.canceled += instance.OnEdit;
                @DisableEdits.started += instance.OnDisableEdits;
                @DisableEdits.performed += instance.OnDisableEdits;
                @DisableEdits.canceled += instance.OnDisableEdits;
            }
        }
    }
    public EditActions @Edit => new EditActions(this);
    public interface ICameraActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnZoomStart(InputAction.CallbackContext context);
        void OnRotateStart(InputAction.CallbackContext context);
        void OnEnableCameraControls(InputAction.CallbackContext context);
    }
    public interface IEditActions
    {
        void OnEditPosition(InputAction.CallbackContext context);
        void OnEdit(InputAction.CallbackContext context);
        void OnDisableEdits(InputAction.CallbackContext context);
    }
}
