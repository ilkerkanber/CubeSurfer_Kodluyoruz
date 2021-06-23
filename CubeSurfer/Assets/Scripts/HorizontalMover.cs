using Game.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Movements {
    public class HorizontalMover : MonoBehaviour
    {
        PlayerController _playerController;
        float boundary;

        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void HorMove(float speed)
        {
            float x = _playerController.transform.position.x;
            float y = _playerController.transform.position.y;
            float z = _playerController.transform.position.z;

            boundary = _playerController.HorizontalBoundary;

            z += Time.deltaTime * speed;
            z = Mathf.Clamp(z, -boundary, boundary);
            _playerController.transform.position = new Vector3(x, y, z);
        }
    }
}

