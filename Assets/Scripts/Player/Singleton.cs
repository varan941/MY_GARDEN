using UnityEngine;

namespace Utils
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance
        {
            get
            {
                if (instance == null)
                    instance = FindObjectOfType<T>();
                return instance;
            }
        }

        public static T AutoInstance
        {
            get
            {
                if (instance == null)
                    instance = FindObjectOfType<T>();
                if (instance == null || !instance.gameObject)
                {
                    GameObject instObject = new GameObject(typeof(T).FullName, typeof(T));
                    instance = instObject.GetComponent<T>();
                    //instance.tag = "Persistent";
                }
                return instance;
            }
        }

        private static T instance;

        public void CheckAndCreateInstance()
        {

        }
    }
}