using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkinSet
{
    public Sprite HeadRear;
    public Sprite HeadFace;
    public Sprite Arm;    
}

public class LookDatabase : MonoBehaviour {

    public List<SkinSet> SkinTypes = new List<SkinSet>();
    public List<Sprite> ShortHair = new List<Sprite>();
    public List<Sprite> LongHair = new List<Sprite>();
    public List<Sprite> TeacherHair = new List<Sprite>();
    public List<Sprite> TeacherFace = new List<Sprite>();

    public SkinSet GetRandomSkinSet()
    {
        int i = Random.Range(0, SkinTypes.Count);
        return SkinTypes[i];
    }

    public Sprite GetRandomHair()
    {
        List<Sprite> hairset = ShortHair;
        if (Random.Range(0,6) >= 3)
        {
            hairset = LongHair;
        }

        int i = Random.Range(0, hairset.Count);
        return hairset[i];
    }
    public Sprite GetRandomTeacherHair()
    {
        int i = Random.Range(0, TeacherHair.Count);
        return TeacherHair[i];
    }

    public Sprite GetRandomTeacherFace()
    {
        int i = Random.Range(0, TeacherFace.Count);
        return TeacherFace[i];
    }
}
