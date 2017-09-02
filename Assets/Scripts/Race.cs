using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : ScriptableObject {

    public class SubRace
    {
        public string subRaceName ="";
        public int STR, CON, DEX, INT, WIS, CHA = 10;
        public List<GameObject> Bonus;
    }

    //fluf
    public string raceName = "";
    public string discription = "";
    public string history = "";
    public string alignment = "";
    //names
    public List<string> maleName = new List<string>();
    public List<string> femaleName = new List<string>();
    public List<string> lastName = new List<string>();
    //stats
    public int STR, CON, DEX, INT, WIS, CHA = 10;
    //age
    public int ageStart = 0;
    public int ageEnd = 0;
    //height
    public int heightStart = 0;
    public int heightEnd = 0;
    //speed
    public int speed = 30;
    public bool darkVision = true;
    public List<string> Bonus;
    public List<Language.Lang> languages = new List<Language.Lang>();
    public List<SubRace> subRaces;

    void Start()
    {

    }
    

}

