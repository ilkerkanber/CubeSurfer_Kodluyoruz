using Game.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Objects
{ 
    public class Cube : MonoBehaviour
    {
        RaycastHit target;
        void Update()
        {
            if (Physics.Raycast(transform.position, -Vector3.right, out target, 0.5f))
            {
                var playerController = target.collider.GetComponentInParent<PlayerController>();
                if (playerController)
                {
                    playerController.AddCube(this.gameObject);
                    Destroy(this.gameObject);
                }
            }
        }    
    }

}

