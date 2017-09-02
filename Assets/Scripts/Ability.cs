using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : ScriptableObject {

    public static string[] EFFECTTYPE = { "stats", "resistance", "skills", "proficiency", "itemproficiency", "physical", "languages", "darkvision", "character", "powers", "feat", "spell", "initiative", "Speed", "Getup", "maxHealth", "resttime" };
    public static string[] STATS = { "STR", "CON", "DEX", "INT", "WIS", "CHA" };

    //the one thing that this ability effects, can be other abilitys
    public string abilityname;
    public string effect;
    /*
     * different durations
     * once, only happen once, like increase INT by 1, gain a feat or language
     * 
     * permanent, is in effect all the time, like slowfall, +5 to saves vs poison
     * 
     * x turn, only last x number of turns
     */
    public string duration; //once, permanent
    
    //no rest, short rest, long rest
    public bool[] rest = { false, false, false };
    public int number = 0;
    public int magnitud = 0;

    public List<string> conditions;
    public List<string> resistance;
    public List<string> valnerbility;
    public List<string> skills;
    public List<string> lighting;
    public List<Language.Lang> language;

    public bool target;

    //andor, allow the user to chose between multiple of the same type that is stored in name
    //only used if names.count > 1
    public List<string> names = new List<string>();
    //keyword, if something only works on/against one thing
    public string keyword;
    //how many turns does it last, -1 to dissable
    public int turns;

    void Start()
    {

    }
}
