using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    [CreateAssetMenu(fileName = "GlobalEventString", menuName = "Scriptable Objects/GlobalEventString")]
    public class GlobalEventString : ScriptableObject
    {
        public UnityEvent<string> Event;
    }
}
