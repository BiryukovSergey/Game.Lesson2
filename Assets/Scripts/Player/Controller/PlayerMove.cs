using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    internal delegate void Moving();
    internal event Moving moving;

    private float _moveX;
    private float _moveY;
    private Vector3 _move;
    private Rigidbody _rigidbody;
    private bool _ground;
    private float _resetTime = 5.0f;
    private bool _isResetTime = true;
    
    public float JumpForce;
    public float Speed;

    private void Awake()
    {
        moving += Move;
        moving += Jump;
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        moving?.Invoke();
    }

    protected void Move()
    {
        _moveY = Input.GetAxis("Vertical");
        _moveX = Input.GetAxis("Horizontal");
        _move = new Vector3(-_moveY, 0, _moveX);
        _rigidbody.AddForce(_move * Speed,ForceMode.Acceleration);
    }

    protected void Jump()
    {
        if (Input.GetAxis("Jump") > 0 && _isResetTime && _ground)
        {
            _rigidbody.AddForce(Vector3.up * JumpForce,ForceMode.Force);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Ground(other, true);
    }

    private void OnCollisionExit(Collision other)
    {
        Ground(other, false);
    }

    private void Ground(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _ground = value;
        }
    }

   

    ~PlayerMove()
    {
        moving += Move;
        moving += Jump;
    }
}