using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class TriggerEvent : MonoBehaviour
    {
        public string Tag;
        public UnityEvent OnTrigger;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == Tag)
                OnTrigger.Invoke();
        }
    }
}
