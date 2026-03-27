using System;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillManager", menuName = "Skills/SkillManager")]
public class SkillManager : ScriptableObject
{
    public Skill[] allSkills;

    public static void Process<T>(T element, Action<T> action)
    {
        action(element);
    }

    public static TResult Transform<T, TResult>(T element, Func<T, TResult> func)
    {
        return func(element);
    }

    public static bool Validate<T>(T element, Func<T, bool> predicate)
    {
        if (element == null || predicate == null)
            return false;
        else
        {
            return predicate(element);
        }


    }
}