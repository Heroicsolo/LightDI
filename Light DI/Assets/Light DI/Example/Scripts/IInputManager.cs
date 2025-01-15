using Heroicsolo.DI;
using UnityEngine;

namespace Heroicsolo.Examples
{
    public interface IInputManager : ISystem
    {
        Vector3 GetMovementDirection();
    }
}