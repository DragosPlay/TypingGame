using UnityEngine;

namespace Core
{
    public class DestroyOnTrigger : MonoBehaviour
    {

        public string Tag;
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == Tag)
                Destroy(other.gameObject);
        }
    }
}
