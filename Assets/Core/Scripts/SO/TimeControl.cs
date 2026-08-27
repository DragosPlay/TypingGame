using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "TimeControl", menuName = "Scriptable Objects/TimeControl")]
    public class TimeControl : ScriptableObject
    {
        public void Pause()
        {
            Time.timeScale = 0;
        }

        public void Continue()
        {
            Time.timeScale = 1;
        }
    }
}
