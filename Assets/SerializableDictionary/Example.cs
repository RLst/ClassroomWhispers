using System.Collections.Generic;
using UnityEngine;

namespace pokoro
{

    [CreateAssetMenu(menuName = "Example Asset")]
    public class Example : ScriptableObject
    {

        [SerializeField]
        private PassDirectionStudentDictionary passDirectionStudentStore = PassDirectionStudentDictionary.New<PassDirectionStudentDictionary>();
        private Dictionary<PassDirection, Student> passDirectionStudents
        {
            get { return passDirectionStudentStore.dictionary; }
        }

        [SerializeField]
        private StringIntDictionary stringIntegerStore = StringIntDictionary.New<StringIntDictionary>();
        private Dictionary<string, int> stringIntegers
        {
            get { return stringIntegerStore.dictionary; }
        }

        [SerializeField]
        private GameObjectFloatDictionary gameObjectFloatStore = GameObjectFloatDictionary.New<GameObjectFloatDictionary>();
        private Dictionary<GameObject, float> screenshots
        {
            get { return gameObjectFloatStore.dictionary; }
        }
    }
}