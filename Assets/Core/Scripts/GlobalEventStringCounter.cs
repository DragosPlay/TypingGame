using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class GlobalEventStringCounter : MonoBehaviour
    {
        public int Count;
        public GlobalEventString Event;
        public UnityEvent<int> OnUpdate;

        private void Start()
        {
            OnUpdate.Invoke(Count);
        }
        private void OnEnable()
        {
            Event.Event.AddListener(GlobalEvent);
        }
        private void OnDisable()
        {
            Event.Event.RemoveListener(GlobalEvent);
        }

        public void GlobalEvent(string charCorrect)
        {
            Count += 1;
            OnUpdate.Invoke(Count);
        }
    }
}
