using Heroicsolo.DI;
using UnityEngine;

namespace Heroicsolo.Examples
{
    public class InputManager : SystemBase, IInputManager
    {
        private Vector3 movementDirection;

        public GameObject GetGameObject()
        {
            return gameObject;
        }

        public Vector3 GetMovementDirection()
        {
            return movementDirection;
        }

        void Update()
        {
            movementDirection = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
            {
                movementDirection += Vector3.forward;
            }
            if (Input.GetKey(KeyCode.S))
            {
                movementDirection -= Vector3.forward;
            }
            if (Input.GetKey(KeyCode.D))
            {
                movementDirection += Vector3.right;
            }
            if (Input.GetKey(KeyCode.A))
            {
                movementDirection -= Vector3.right;
            }

            movementDirection.Normalize();
        }
    }
}