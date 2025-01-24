using Fusion;
using UnityEngine;
using System.Collections;

public class PlayerMovement : NetworkBehaviour
{
    public Vector3 _velocity;
    private bool _jumpPressed;

    private CharacterController _controller;

    public float PlayerSpeed = 2f;
    public float WindStrength = 5f;

    public float JumpForce = 5f;
    public float GravityValue = -9.81f;
    public float GravityAmplifier = 2.5f;

    public Camera Camera;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _jumpPressed = true;
        }
    }

    public override void Spawned()
    {
        if (HasStateAuthority)
        {
            Camera = Camera.main;
            Camera.GetComponent<FirstPersonCamera>().Target = transform;
        }
    }

    public override void FixedUpdateNetwork()
    {
        if (_controller.isGrounded)
        {
            _velocity.y = -1f;
        }


        Quaternion cameraRotationY = Quaternion.Euler(0, Camera.transform.rotation.eulerAngles.y, 0);
        Vector3 move = cameraRotationY * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Runner.DeltaTime * PlayerSpeed;

        if (_velocity.y < 0)
        {
            _velocity.y += GravityValue * GravityAmplifier * Runner.DeltaTime;
        }
        else
        {
            _velocity.y += GravityValue * Runner.DeltaTime;
        }

        if (_jumpPressed && _controller.isGrounded)
        {
            _velocity.y += JumpForce;
        }

        _controller.Move(move + _velocity * Runner.DeltaTime);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        _jumpPressed = false;
    }
}
