using UnityEngine;

namespace Core
{
    public class Counter : MonoBehaviour
    {
        public int Correct;
        public int Miss;
        public GlobalEventString InputEvent, CorrectEvent, UncorrectEvent;

        private void OnEnable()
        {
            CorrectEvent.Event.AddListener(CorrectCount);
            UncorrectEvent.Event.AddListener(UnCorrectCount);
        }
        private void OnDisable()
        {
            CorrectEvent.Event.RemoveListener(CorrectCount);
            UncorrectEvent.Event.RemoveListener(UnCorrectCount);
        }

        public void CorrectCount(string charCorrect)
        {
            Correct += 1;
        }
        public void UnCorrectCount(string charUncorrect)
        {
            Miss += 1;
        }
    }
}
