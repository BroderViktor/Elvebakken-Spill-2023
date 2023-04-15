
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public AudioSource footsteps;
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float turnSensitivity = 4;
    public Transform head;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 curEuler = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        //rotate head on x-axis (Up and down)
        float XturnAmount = Input.GetAxis("Mouse Y") * Time.deltaTime * turnSensitivity;
        curEuler = Vector3.right * Mathf.Clamp(curEuler.x - XturnAmount, -90f, 90f);
        head.localRotation = Quaternion.Euler(curEuler);

        //rotate body on y-axis (Sideways)
        float YturnAmount = Input.GetAxis("Mouse X") * Time.deltaTime * turnSensitivity;
        transform.Rotate(Vector3.up * YturnAmount);

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        Vector3 movedir = Vector3Int.RoundToInt(new Vector3(moveDirection.x, moveDirection.y, moveDirection.z));
        if (movedir.x != 0 && movedir.z != 0 && movedir.y == 0)
        {
            if (!footsteps.isPlaying)
                footsteps.Play();

        }
        else
        {
            if (footsteps.isPlaying)
                footsteps.Pause();
        }
        characterController.Move(moveDirection * Time.deltaTime);
    }
}