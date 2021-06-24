using Game.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Controllers {
    public class PlayerController : MonoBehaviour
    {
        VerticalMover _verticalMover;
        HorizontalMover _horizontalMover;
        [SerializeField] GameObject Body,Pool;

        [field: SerializeField]
        public float HorizontalBoundary { get; private set; }

        [field:SerializeField]
        public float VerticalSpeed{ get; private set; }

        [field: SerializeField]
        public float HorizontalSpeed { get; private set; }
        public bool IsLeft { get; set; }
        public bool IsRight { get; set; }

        void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
            _verticalMover = new VerticalMover(this);
        }
        void FixedUpdate()
        {
            _verticalMover.Run(VerticalSpeed);

            if (IsLeft)
            {
                _horizontalMover.HorMove(HorizontalSpeed);
                IsLeft = false;
            }
            if (IsRight)
            {
                _horizontalMover.HorMove(-HorizontalSpeed);
                IsRight = false;
            }
        }
        public void AddCube(GameObject spawnObject)
        {
                Body.transform.position += Vector3.up;
                Vector3 poz = Body.transform.position;
                poz.y = poz.y - 1;
                Instantiate(spawnObject, poz, transform.rotation, Pool.transform);
        }

    }
}

