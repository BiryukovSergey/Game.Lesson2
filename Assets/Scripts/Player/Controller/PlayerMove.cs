using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void Info(string text);
public class PlayerMove : MonoBehaviour
{
    Constants constants = new Constants();
    
    private float _moveX;
    private float _moveY;
    private Vector3 _move;
    private Rigidbody _rigidbody;
    private bool _ground;
    private string _text;
    event Info infoConsole;
    

    public float JumpForce;
    public float Speed;
    
    
    public void ConsoleInfo(string text)
    {
        _text = text;
        Debug.Log(_text);
    }

    public void NullSubscriber()
    {
        infoConsole -= ConsoleInfo;
    }
    private void Start()
    {
       _rigidbody = GetComponent<Rigidbody>();
       infoConsole += ConsoleInfo;
    }

    private void FixedUpdate()
    {
        Move();
        Jump();

        // Debug.Log("Speed =" + Speed);
        // Debug.Log("Jump =" + JumpForce);
    }

    protected void Move()
    {
       _moveY = Input.GetAxis("Vertical");
       _moveX = Input.GetAxis("Horizontal");
       _move = new Vector3(-_moveY, 0, _moveX);
       //transform.Rotate(Vector3.up,Space.World);
       _rigidbody.AddForce(_move * Speed,ForceMode.Force);
       
    }

    protected void Jump()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if(_ground)
            {
                _rigidbody.AddForce(Vector3.up * JumpForce);
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            infoConsole("Вы взяли бонус!");
            //NullSubscriber();
        }
        if (other.GetComponent<IBonus>() != null)
        {
            other.GetComponent<IBonus>().Bonus();
           
            
        }
        if(other.GetComponent<IBadBonus>() != null)
        {
            other.GetComponent<IBadBonus>().BadBonus();
            
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
}
