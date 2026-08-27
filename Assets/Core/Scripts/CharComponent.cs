using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class CharComponent : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI textBox;
        public UnityEvent Correct, Uncorrect;
        public GlobalEventString InputEvent, CorrectEvent, UncorrectEvent;

        private void OnEnable()
        {
            InputEvent.Event.AddListener(OnCharInput); //Подписка на глобальное событие ввода
        }
        private void OnDisable()
        {
            InputEvent.Event.RemoveListener(OnCharInput); //Отписка от глобального события ввода
        }

        public string Char
        {
            get
            { 
                return textBox.text; 
            }
            set
            {
                textBox.text = value;
            }
        }

        public void OnCharInput(string charInput)
        {
            if (Char.ToUpper() == charInput.ToUpper())
            {
                Correct.Invoke();
                CorrectEvent.Event.Invoke(Char); //Вызов глобального события корректного ввода
                enabled = false;
            } else
            {
                Uncorrect.Invoke();
                UncorrectEvent.Event.Invoke(Char); //Вызов глобального события некорректного ввода
            }
        }
    }
}
