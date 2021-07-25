using System;
using Bonus;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public sealed class PlayerMove : MonoBehaviour
{ 
    internal event Action moving = () => {};

    private float _moveX;
    private float _moveY;
    private Vector3 _move;
    private Rigidbody _rigidbody;
    private bool _ground;
    private bool inAir;
    
    public float JumpForce;
    public float Speed;
    public Text Text;
    
    private void Awake()
    {
       moving += Move;
       _rigidbody = GetComponent<Rigidbody>();
      
    }

    private void Update()
    {
        Text.text = $"Скорость шара:  {Speed.ToString()}" + $"\n Сила прыжка: {JumpForce.ToString()}";
        moving += Jump;
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
        /*if (Input.GetAxis("Jump") > 0 && _isResetTime && _ground)
        {
            _rigidbody.AddForce(Vector3.up * JumpForce,ForceMode.Force);
        }*/
        
        if (Input.GetKey(KeyCode.Space) && !inAir)
        {
            inAir = true;
            _rigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Force);
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
            //_ground = value;
            inAir = false;
        }
    }

    ~PlayerMove()
    {
        moving += Move;
        moving += Jump;
    }
}