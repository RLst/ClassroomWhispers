using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

//2. Define the property drawers here

namespace pokoro
{
    [UnityEditor.CustomPropertyDrawer(typeof(PassDirectionStudentDictionary))]
    public class PassDirectionStudentDictionaryDrawer : SerializableDictionaryDrawer<PassDirection, Student>
    {
        protected override SerializableKeyValueTemplate<PassDirection, Student> GetTemplate()
        {
            return GetGenericTemplate<SerializablePassDirectionStudentTemplate>();
        }
    }
    internal class SerializablePassDirectionStudentTemplate : SerializableKeyValueTemplate<PassDirection, Student> {}

    // ---------------
    //  String => Int
    // ---------------
    [UnityEditor.CustomPropertyDrawer(typeof(StringIntDictionary))]
    public class StringIntDictionaryDrawer : SerializableDictionaryDrawer<string, int>
    {
        protected override SerializableKeyValueTemplate<string, int> GetTemplate()
        {
            return GetGenericTemplate<SerializableStringIntTemplate>();
        }
    }
    internal class SerializableStringIntTemplate : SerializableKeyValueTemplate<string, int> {}

    // ---------------
    //  GameObject => Float
    // ---------------
    [UnityEditor.CustomPropertyDrawer(typeof(GameObjectFloatDictionary))]
    public class GameObjectFloatDictionaryDrawer : SerializableDictionaryDrawer<GameObject, float>
    {
        protected override SerializableKeyValueTemplate<GameObject, float> GetTemplate()
        {
            return GetGenericTemplate<SerializableGameObjectFloatTemplate>();
        }
    }
    internal class SerializableGameObjectFloatTemplate : SerializableKeyValueTemplate<GameObject, float> {}

}