using Heroicsolo.DI;
using UnityEngine;

namespace Heroicsolo.Examples
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField][Min(0f)] private float moveSpeed = 5f;

        [Inject] private CameraController cameraController;
        [Inject] private IInputManager inputManager;

        private CharacterController characterController;

        void Start()
        {
            SystemsManager.InjectSystemsTo(this);

            cameraController.SetPlayerTransform(transform);

            characterController = GetComponent<CharacterController>();
        }

        void Update()
        {
            characterController.Move(moveSpeed * Time.deltaTime * cameraController.GetWorldDirection(inputManager.GetMovementDirection()));
        }
    }
}