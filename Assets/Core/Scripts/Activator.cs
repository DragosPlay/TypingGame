using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Core
{
    public class Activator : MonoBehaviour
    {
        [SerializeField] LinkedList<CharComponent> chars = new LinkedList<CharComponent>();
        [SerializeField] CharComponent active = null;
        [SerializeField] Transform activePosition;
        CharComponent Active
        {
            get
            { 
                return active; 
            }
            set 
            {
                active = value;
                active.enabled = true;
                Rigidbody activeRB = active.GetComponent<Rigidbody>();
                Debug.Log($"{activeRB.position.z} > {activePosition.position.z}");
                if(activeRB.position.z > activePosition.position.z)
                {
                    activeRB.MovePosition(new Vector3(activeRB.position.x, activeRB.position.y, activePosition.position.z));
                    Debug.Log($"{activeRB.position.z} > {activePosition.position.z}");
                }
                active.Correct.AddListener(NextActive);
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out CharComponent component))
            {
                chars.AddLast(component);
                if (active == null)
                    Active = component;

                StringBuilder stringBuilder = new StringBuilder();
                foreach (CharComponent c in chars)
                {
                    stringBuilder.Append(c.Char);
                }
                Debug.Log(stringBuilder.ToString());
            }
        }

        void NextActive()
        {
            active.Correct.RemoveListener(NextActive);
            chars.RemoveFirst();

            if (chars.Count > 0)
                Active = chars.First.Value;
            else
                active = null;
        }
    }
}
