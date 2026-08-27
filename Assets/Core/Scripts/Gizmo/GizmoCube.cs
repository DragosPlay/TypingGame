using UnityEditor;
using UnityEngine;

namespace Core
{
    public class GizmoCube : MonoBehaviour
    {
        public float Size = 3f;
        private void OnDrawGizmos()
        {
            Gizmos.DrawWireCube(transform.position, new Vector3(Size, Size, Size));
        }
    }
}
