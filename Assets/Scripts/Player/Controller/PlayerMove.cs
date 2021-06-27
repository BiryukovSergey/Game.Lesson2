using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void Info(string text);
public class PlayerMove : MonoBehaviour
{
    Constants constants = new Constants();

    //internal PlayerMove[] _player; // <- добавил, если сломаю убрать
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
     //  _player = GameObject.FindObjectsOfType<PlayerMove>(); // <- массив объектов
    }

    // попытка достать компаненты
    /*private void Update()
    {
        if (_player != null)
        {
            if (TryGetComponent(out PlayerMove player))
            {
               // if (player is BadBonusSpeedJump s)
                player.im();
                
            }
            
        }
    }*/
    
    // Коментирую 
   /* public IEnumerator im()
    {
        //var TimeCoolDawn = 0.0f;
        BadBonusSpeedJump s;
        
        var TimeBoost = 5.0f;
        if (TimeBoost <= 0.0)
        {
            TimeBoost -= Time.deltaTime;
            {
                
                if (_player.JumpForce > constants.MinJump && _player.Speed > constants.MinSpeed)
                {
                    _player.JumpForce -= constants.BadBonusJump;
                    _player.Speed -= constants.BadBonusSpeed;
                }

                yield return null;
            }
        }
    }*/

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    protected void Move()
    {
       _moveY = Input.GetAxis("Vertical");
       _moveX = Input.GetAxis("Horizontal");
       _move = new Vector3(-_moveY, 0, _moveX);
       //transform.Rotate(Vector3.up,Space.World);                <---------- мусор
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
   /* private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            infoConsole("Вы взяли бонус!");
            //NullSubscriber();                 <---------- мусор
        }
        if (other.GetComponent<IBonus>() != null)
        {
            other.GetComponent<IBonus>().Bonus();
        }
        
        if(other.GetComponent<IBadBonus>() != null)
        {
            other.GetComponent<IBadBonus>().BadBonus();
            //StartCoroutine(im());                    <---------- мусор
        }
    }*/

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
