using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class StartEvent : MonoBehaviour
    {
        public UnityEvent OnStart;
        private void Start()
        {
            OnStart.Invoke();
        }
    }
}
