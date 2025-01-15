using Heroicsolo.DI;
using UnityEngine;

namespace Heroicsolo.Examples
{
    public class CameraController : SystemBase
    {
        [SerializeField][Min(0f)] private float cameraFollowSpeed = 8f;

        private Transform _cameraTransform;
        private Transform _playerTransform;

        private Vector3 _offset;

        public GameObject GetGameObject()
        {
            return gameObject;
        }

        public void SetPlayerTransform(Transform playerTransform)
        {
            _cameraTransform ??= Camera.main.transform;
            _playerTransform = playerTransform;
            _offset = _cameraTransform.position - _playerTransform.position;
        }

        public Vector3 GetWorldDirection(Vector3 viewportDirection)
        {
            return transform.TransformDirection(viewportDirection);
        }

        void Start()
        {
            _cameraTransform = Camera.main.transform;
        }

        void Update()
        {
            if (_playerTransform != null)
            {
                _cameraTransform.position = Vector3.Lerp(_cameraTransform.position,
                    _playerTransform.position + _offset,
                    cameraFollowSpeed * Time.deltaTime);
            }
        }
    }
}