using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    [CreateAssetMenu(fileName = "GlobalEvent", menuName = "Scriptable Objects/GlobalEvent")]
    public class GlobalEvent : ScriptableObject
    {
        public UnityEvent Event;    
    }
}
