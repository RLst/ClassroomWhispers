using System;
using UnityEngine;

//1. Make custom dictionary definitions here

namespace pokoro
{
    [Serializable]
    public class PassDirectionStudentDictionary : SerializableDictionary<PassDirection, Student> {}

    // ---------------
    //  String => Int
    // ---------------
    [Serializable]
    public class StringIntDictionary : SerializableDictionary<string, int> {}

    // ---------------
    //  GameObject => Float
    // ---------------
    [Serializable]
    public class GameObjectFloatDictionary : SerializableDictionary<GameObject, float> {}
}