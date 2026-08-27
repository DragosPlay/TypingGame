using TMPro;
using UnityEngine;

namespace Core
{
    public class TextUpdater : MonoBehaviour
    {
        TextMeshProUGUI textField;
        private void Start()
        {
            textField = GetComponent<TextMeshProUGUI>();
        }
        public void UpdateText(int Text)
        {
            textField.text = Text.ToString();
        }
    }
}
