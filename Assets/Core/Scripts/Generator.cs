using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Core
{
    public class Generator : MonoBehaviour
    {
        public List<RoadGenerator> Roads;
        System.Random random = new System.Random();
        public void Generate()
        {
            Roads[random.Next(Roads.Count)].Generate();
        }
    }
}
