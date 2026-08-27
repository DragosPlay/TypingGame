using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
    public class CharInput : MonoBehaviour
    {
        Dictionary<KeyCode, string> translator = KeyCodeTranslator.Russian;
        public GlobalEventString InputEvent;

        private void OnGUI()
        {
            Event e = Event.current;

            if ((translator.TryGetValue(e.keyCode,out string inputChar)) && (e.type == EventType.KeyDown))
            { 
                Debug.Log(inputChar + " " + e.type);
                InputEvent.Event.Invoke(inputChar);
            }        
        }
    }
}
