using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Singletons;
using Game.Movements;
using Game.Controllers;

public class InputManager : SingletonSetup<InputManager> 
{
    PlayerController _playerController;
    void Awake()
    {
        Setup(this);
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _playerController.IsLeft = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerController.IsRight = true;
        }
       
    }
}
