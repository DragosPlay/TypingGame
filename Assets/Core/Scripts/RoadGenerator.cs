using UnityEngine;

namespace Core
{
    public class RoadGenerator : MonoBehaviour
    {
        public string Chars;
        [SerializeField] GameObject CharPrefab;
        System.Random random = new System.Random();

        public void Generate()
        {
            Instantiate(CharPrefab, transform.position, CharPrefab.transform.rotation, transform).GetComponent<CharComponent>().Char = Chars[random.Next(Chars.Length)].ToString().ToUpper();
        }
    }
}
