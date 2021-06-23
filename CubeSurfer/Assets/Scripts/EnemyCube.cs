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
           if( Physics.Raycast(transform.position, -Vector3.right, out target, 0.5f))
            {
                if (target.collider.gameObject.tag == "Cube")
                {
                    Debug.Log(target.collider.gameObject.name);
                    Destroy(target.collider.gameObject);
                }
            }
        }
      

    }
}
