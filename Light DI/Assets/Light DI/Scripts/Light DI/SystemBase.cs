using UnityEngine;

namespace Heroicsolo.DI
{
    public class SystemBase : MonoBehaviour, ISystem
    {
        private void Start()
        {
            SystemsManager.RegisterSystem(this);
        }

        private void OnDestroy()
        {
            SystemsManager.UnregisterSystem(this);
        }
    }
}