using Game.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Movements {
    public class VerticalMover : MonoBehaviour
    {
        PlayerController _playerController;
        public VerticalMover(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void Run(float Speed)
        {
            _playerController.transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }

    }
}

