using System.Linq;
using UnityEngine;

namespace pokoro
{
    public abstract class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
    {
        static T mInstance = null;
        public static T instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
                }
                return mInstance;
            }
        }
    }
}