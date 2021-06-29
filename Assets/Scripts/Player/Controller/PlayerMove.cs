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
    private float _resetTime = 0.0f;
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

    private void Update()
    {
        // ResetTime();
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
        _rigidbody.AddForce(_move * Speed);
    }

    protected void Jump()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            // if (isResetTime) <------------ не работает (флаг )

            if (_ground)
            {
                _rigidbody.AddForce(Vector3.up * JumpForce);
            }
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

    /// <summary>
    /// Не работает
    /// </summary>
    /*public void ResetTime()
    {
        while (_resetTime != 5.0f)
        {
            _resetTime += Time.deltaTime;
            _isResetTime = false;
        }
    }*/
    ~PlayerMove()
    {
        moving += Move;
        moving += Jump;
    }
}