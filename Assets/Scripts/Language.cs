using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour {

    public class Lang
    {
        public string language;
        string script;
        bool exotic;

        public Lang(string lan, string scr, bool ty)
        {
            language = lan;
            script = scr;
            exotic = ty;
        }
    }

    public static Language languages;

    public List<Lang> language;

    void Start () {
        

        DontDestroyOnLoad(this);
        if (languages == null)
        {
            language = new List<Lang>();

            //common languages
            language.Add(new Lang("Common", "Common", false));
            language.Add(new Lang("Dwarvish", "Dwarvish", false));
            language.Add(new Lang("Elvish", "Elvish", false));
            language.Add(new Lang("Giant", "Dwarvish", false));
            language.Add(new Lang("Gnomish", "Dwarvish", false));
            language.Add(new Lang("Goblin", "Dwarvish", false));
            language.Add(new Lang("Halfling", "Common", false));
            language.Add(new Lang("Orc", "Dwarvish", false));

            //Exotic languages
            language.Add(new Lang("Abyssal", "Infernal", true));
            language.Add(new Lang("Celestial", "Celestial", true));
            language.Add(new Lang("Draconic", "Draconic", true));
            language.Add(new Lang("Deep Speech", "", true));
            language.Add(new Lang("Infernal", "Infernal", true));
            language.Add(new Lang("Primordial", "Dwarvish", true));
            language.Add(new Lang("Sylvan", "Elvish", true));
            language.Add(new Lang("Undercommon", "Elvish", true));

            languages = this;
        }
        else
        {
            Destroy(this);
        }
    }
	
}
