using UnityEngine;

namespace Core
{
    public class PauseChars : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out CharComponent component))
            {
                if(component.enabled)
                    Time.timeScale = 0f;
            }
        }
    }
}
