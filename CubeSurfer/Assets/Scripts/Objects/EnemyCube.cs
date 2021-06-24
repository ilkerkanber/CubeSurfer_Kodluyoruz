using Game.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Objects
{
    public class EnemyCube : MonoBehaviour
    {
        RaycastHit target;
        void Update()
        {
           if( Physics.Raycast(transform.position, -Vector3.right, out target, 0.1f))
            {
                switch(target.collider.transform.parent.tag)
                {
                    case "Cube":
                    Destroy(target.collider.transform.parent.gameObject);
                    break;
                    
                    case "Player":
                    var player = target.collider.transform.parent.GetComponent<PlayerController>();
                    player.IsDead = true;
                    break;
                }
            }
        }
      

    }
}
