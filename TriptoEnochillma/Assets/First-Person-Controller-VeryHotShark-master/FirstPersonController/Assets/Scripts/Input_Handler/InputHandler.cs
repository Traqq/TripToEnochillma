using UnityEngine;
using NaughtyAttributes;
using UnityEngine.InputSystem;
using System;

namespace VHS
{    
    public class InputHandler : MonoBehaviour
    {
        private EnoshimaActions m_actions;
        private Vector2 m_movement;
        private Vector2 m_mouseMovement;
        #region Data
        [Space,Header("Input Data")]
            [SerializeField] private CameraInputData cameraInputData = null;
            [SerializeField] private MovementInputData movementInputData = null;
            [SerializeField] private InteractionInputData interactionInputData = null;
        #endregion

        #region BuiltIn Methods
        void Start()
        {
            cameraInputData.ResetInput();
            movementInputData.ResetInput();
            interactionInputData.ResetInput();
            m_actions = new EnoshimaActions();
            m_actions.Enable();
            m_actions.Player.Crouch.performed += CheckCrouch;
            m_actions.Player.Sprint.started += StartSprint;
            m_actions.Player.Sprint.canceled += StopSprint;
            m_actions.Player.Zoom.started += StartZoom;
            m_actions.Player.Zoom.canceled += StopZoom;
            m_actions.Player.Interraction.started += StartInterract;
            m_actions.Player.Interraction.canceled += StopInterract;
            m_actions.Player.Jump.performed += StartJump;
            m_actions.Player.PhotoMode.performed += StartPhotoMode;
            m_actions.Player.TakePhoto.performed += TakePhoto;
            m_actions.Player.SwitchFilter.performed += SwitchFilter;
        }

        private void SwitchFilter(InputAction.CallbackContext obj)
        {
            GetComponentInChildren<PhotoCapture>().SwitchFilter();
        }

        private void TakePhoto(InputAction.CallbackContext obj)
        {
            GetComponentInChildren<PhotoCapture>().TakePhoto();
        }

        private void StartJump(InputAction.CallbackContext obj)
        {
            movementInputData.JumpClicked = true;
        }

        private void StopInterract(InputAction.CallbackContext obj)
        {
            interactionInputData.InteractedClicked = false;
            interactionInputData.InteractedReleased = true;
        }

        private void StartInterract(InputAction.CallbackContext obj)
        {
            interactionInputData.InteractedClicked = true;
            interactionInputData.InteractedReleased = false;
        }

        private void StopZoom(InputAction.CallbackContext obj)
        {
            cameraInputData.ZoomClicked = false;
            cameraInputData.ZoomReleased = true;
            FindObjectOfType<CameraController>().cameraZoom.ChangeFOV(FindObjectOfType<CameraController>());
        }

        private void StartZoom(InputAction.CallbackContext obj)
        {
            cameraInputData.ZoomClicked = true;
            cameraInputData.ZoomReleased = false;
            FindObjectOfType<CameraController>().cameraZoom.ChangeFOV(FindObjectOfType<CameraController>());

        }

        private void StartPhotoMode(InputAction.CallbackContext obj)
        {
            GetComponentInChildren<PhotoCapture>().ActivePhotoMode();
        }

        private void StopSprint(InputAction.CallbackContext obj)
        {
            movementInputData.RunClicked = false;
            movementInputData.RunReleased = true;
        }

        private void StartSprint(InputAction.CallbackContext obj)
        {
            movementInputData.RunClicked = true;
            movementInputData.RunReleased = false;
        }

        private void CheckCrouch(InputAction.CallbackContext obj)
        {
            if(movementInputData.CrouchClicked == true)
            {
                movementInputData.CrouchClicked = false;
            }
            else if(movementInputData.CrouchClicked == false)
            {
                movementInputData.CrouchClicked = true;
            }
        }

        void Update()
            {
                GetCameraInput();
                GetMovementInputData();
                GetInteractionInputData();
            }
        #endregion

        #region Custom Methods
            void GetInteractionInputData()
            {
                /*interactionInputData.InteractedClicked = Input.GetKeyDown(KeyCode.E);
                interactionInputData.InteractedReleased = Input.GetKeyUp(KeyCode.E);*/
            }

            void GetCameraInput()
        {
                m_mouseMovement = m_actions.Player.MouseView.ReadValue<Vector2>();
                cameraInputData.InputVectorX = m_mouseMovement.x;// nput.GetAxis("Mouse X");
                cameraInputData.InputVectorY = m_mouseMovement.y; // Input.GetAxis("Mouse Y");

                /*cameraInputData.ZoomClicked = Input.GetMouseButtonDown(1);
                cameraInputData.ZoomReleased = Input.GetMouseButtonUp(1);*/
            }

            void GetMovementInputData()
        {
                m_movement = m_actions.Player.Move.ReadValue<Vector2>();
                movementInputData.InputVectorX = m_movement.x;// Input.GetAxisRaw("Horizontal");
                movementInputData.InputVectorY = m_movement.y; //Input.GetAxisRaw("Vertical");

                /*movementInputData.RunClicked = Input.GetKeyDown(KeyCode.LeftShift);
                movementInputData.RunReleased = Input.GetKeyUp(KeyCode.LeftShift);*/

                if(movementInputData.RunClicked)
                    movementInputData.IsRunning = true;

                if(movementInputData.RunReleased)
                    movementInputData.IsRunning = false;

                //movementInputData.JumpClicked = Input.GetKeyDown(KeyCode.Space);
                //movementInputData.CrouchClicked = Input.GetKeyDown(KeyCode.LeftControl);
            }



        private void OnDestroy()
        {
            m_actions.Player.Crouch.performed -= CheckCrouch;
            m_actions.Player.Sprint.started -= StartSprint;
            m_actions.Player.Sprint.canceled -= StopSprint;
            m_actions.Player.Zoom.started -= StartZoom;
            m_actions.Player.Zoom.canceled -= StopZoom;
            m_actions.Player.Interraction.started -= StartInterract;
            m_actions.Player.Interraction.canceled -= StopInterract;
            m_actions.Player.Jump.performed -= StartJump;
            m_actions.Player.PhotoMode.performed -= StartPhotoMode;
            m_actions.Player.TakePhoto.performed -= TakePhoto;
            m_actions.Player.SwitchFilter.performed -= SwitchFilter;
            m_actions.Disable();
            m_actions.Dispose();
        }
        #endregion
    }
}