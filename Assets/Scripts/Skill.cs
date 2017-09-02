using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour {

    public static Skill skillList;
    public List<string> skills;

    private void Start()
    {
        DontDestroyOnLoad(this);

        if(skillList == null)
        {
            skills = new List<string>();
            skills.Add("Athletics");
            skills.Add("Acrobatics");
            skills.Add("Sleight of Hand");
            skills.Add("Stealth");
            skills.Add("Arcana");
            skills.Add("History");
            skills.Add("Investigation");
            skills.Add("Nature");
            skills.Add("Religion");
            skills.Add("AnimalHandling");
            skills.Add("Insight");
            skills.Add("Medicine");
            skills.Add("Perception");
            skills.Add("Survival");
            skills.Add("Deception");
            skills.Add("Intimidation");
            skills.Add("Performance");
            skills.Add("Persuasion");
            skillList = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public List<string> getskills()
    {
        return skills;
    }

    public bool isskill(string skill)
    {
        return skills.Contains(skill);
    }
}
