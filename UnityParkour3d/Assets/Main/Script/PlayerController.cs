using System;
using UnityEngine;

namespace Main.Script
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private AnimatorController animatorController;
        [SerializeField] private CharacterController characterController;
        [SerializeField] private EnemyTestController testController;
        
        
        private float gravity = 9.8f; // Adjust the gravity value as needed
        private float verticalSpeed = 0f;


        void HandleGravity()
        {
            if (!characterController.isGrounded)
            {
                verticalSpeed -= gravity * Time.deltaTime;
            }
            else
            {
                verticalSpeed = -gravity * Time.deltaTime;
            }

       
            Vector3 gravityVector = new Vector3(0, verticalSpeed, 0);
            characterController.Move(gravityVector * Time.deltaTime);
        }


        private void Start()
        {
            testController = FindObjectOfType<EnemyTestController>();
        }

        private void Update()
        {
            characterController.Move(animatorController.AnimatorPositionChange);
            animatorController.AnimatorPositionChange = Vector3.zero;
            HandleGravity();


            if (Input.GetKeyDown(KeyCode.Space))
            {
                animatorController.PlayAttack();
                testController.PlayVictim(transform.position);
            }
        }
    }
}