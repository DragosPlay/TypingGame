using UnityEngine;

namespace Core
{
    public class Move : MonoBehaviour
    {
        public float Speed = 1f;
        [SerializeField] Vector3 direction = Vector3.back;
        Rigidbody rb;
        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }
        private void FixedUpdate()
        {
            rb.linearVelocity = direction * Speed;
        }
    }
}
