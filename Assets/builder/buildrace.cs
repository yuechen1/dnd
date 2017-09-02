using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buildrace : MonoBehaviour {

    public string raceName;
    public string discription;
    public string history;
    public string alignment;
    //names
    public string maleName;
    public string femaleName;
    public string lastName;
    //stats
    public string STR;
    public string CON;
    public string DEX;
    public string INT;
    public string WIS;
    public string CHA;
    //age
    public string ageStart;
    public string ageEnd;
    //height
    public string heightStart;
    public string heightEnd;
    //speed
    public string speed;
    public bool darkVision;
    public string Bonus;
    public List<Language.Lang> languages;
    public string lang;
    public List<Race.SubRace> subRaces;
    public string subrace;

    //some size and stuff for ui
    Vector2 race_menu_panel_start= new Vector2(170, 0);
    Vector2 race_menu_panel_size = new Vector2(918, 558);
    Vector2 scrollPosition;

    //styles for tittle text and buttons
    GUIStyle titletext = new GUIStyle();

    //save control
    private bool saveactive;

    void Start()
    {
        raceName = discription = history = alignment = maleName = femaleName = lastName = STR = CON = DEX = INT = WIS = CHA 
            = ageStart = ageEnd = heightEnd = heightStart = speed = Bonus = lang = subrace = "";

        saveactive = false;
        scrollPosition = new Vector2();
        speed = "30";

        //create the styles
        titletext.fontSize = 20;
        titletext.fontStyle = FontStyle.Bold;
    }
	
    public void setscroll(float y)
    {
        scrollPosition.y = y;
    }


	void OnGUI()
    {
        //race building selection menu
        GUILayout.BeginArea(new Rect(new Vector2(170, 0), new Vector2(918, 558)));


        
        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(718), GUILayout.Height(558));

        GUILayout.BeginVertical(GUILayout.Width(186), GUILayout.Height(558));
        if (GUILayout.Button("imiage goes here", GUILayout.Width(186), GUILayout.Height(265)))
        {

        }
        if (GUILayout.Button("Discription", GUILayout.Width(186), GUILayout.Height(44)))
        {

        }
        if (GUILayout.Button("Names", GUILayout.Width(186), GUILayout.Height(44)))
        {

        }
        if (GUILayout.Button("Traits", GUILayout.Width(186), GUILayout.Height(44)))
        {

        }
        if (GUILayout.Button("Sub Race", GUILayout.Width(186), GUILayout.Height(44)))
        {

        }
        if (GUILayout.Button("History", GUILayout.Width(186), GUILayout.Height(44)))
        {

        }
        GUI.enabled = saveactive;
        if (GUILayout.Button("Save", GUILayout.Width(186), GUILayout.Height(44)))
        {

        }
        GUILayout.EndVertical();


        //race name
        GUILayout.TextArea("Race Name:", titletext);
        raceName = GUILayout.TextField(raceName, GUILayout.Width(160), GUILayout.Height(30));


        //race discription
        GUILayout.TextArea("Discription:", titletext);
        discription = GUILayout.TextField(discription, GUILayout.Width(650), GUILayout.Height(350));


        //posible names to choose from
        //male, female and last names
        GUILayout.TextArea("Male Name (Seperated by ',')", titletext);
        maleName = GUILayout.TextArea(maleName, GUILayout.Width(650), GUILayout.Height(120));
        GUILayout.TextArea("Feale Name (Seperated by ',')", titletext);
        femaleName = GUILayout.TextArea(femaleName, GUILayout.Width(650), GUILayout.Height(120));
        GUILayout.TextArea("Clan Name (Seperated by ',')", titletext);
        lastName = GUILayout.TextArea(lastName, GUILayout.Width(650), GUILayout.Height(120));


        //Ability score changes
        GUILayout.TextArea("Ability Score", titletext);
        GUILayout.BeginHorizontal();
        //STR
        GUILayout.TextArea("STR", titletext);
        STR = Regex.Replace(STR, "[^0-9]", "");
        STR = GUILayout.TextField(STR, 2, GUILayout.Width(50), GUILayout.Height(30));
        //CON
        GUILayout.TextArea("CON", titletext);
        CON = Regex.Replace(CON, "[^0-9]", "");
        CON = GUILayout.TextField(CON, 2, GUILayout.Width(50), GUILayout.Height(30));
        //DEX
        GUILayout.TextArea("DEX", titletext);
        DEX = Regex.Replace(DEX, "[^0-9]", "");
        DEX = GUILayout.TextField(DEX, 2, GUILayout.Width(50), GUILayout.Height(30));
        //INT
        GUILayout.TextArea("INT", titletext);
        INT = Regex.Replace(INT, "[^0-9]", "");
        INT = GUILayout.TextField(INT, 2, GUILayout.Width(50), GUILayout.Height(30));
        //WIS
        GUILayout.TextArea("WIS", titletext);
        WIS = Regex.Replace(WIS, "[^0-9]", "");
        GUILayout.TextField(WIS, 2, GUILayout.Width(50), GUILayout.Height(30));
        //CHA
        GUILayout.TextArea("CHA", titletext);
        CHA = Regex.Replace(CHA, "[^0-9]", "");
        GUILayout.TextField(CHA, 2, GUILayout.Width(50), GUILayout.Height(30));
        GUILayout.EndHorizontal();


        //Age range
        GUILayout.TextField("Age Range", titletext);
        GUILayout.BeginHorizontal();
        ageStart = GUILayout.TextField(ageStart);
        GUILayout.TextField("-", titletext);
        ageEnd = GUILayout.TextField(ageEnd);
        GUILayout.EndHorizontal();

        //Alignment
        GUILayout.TextField("Alignment (Is the race good? evil?", titletext);
        alignment = GUILayout.TextArea(alignment, GUILayout.Width(650), GUILayout.Height(120));

        //height
        GUILayout.TextField("Height Range", titletext);
        GUILayout.BeginHorizontal();
        heightStart = GUILayout.TextField(heightStart);
        GUILayout.TextField("-", titletext);
        heightEnd = GUILayout.TextField(heightEnd);
        GUILayout.EndHorizontal();

        //weight
        GUILayout.TextField("Weight Range", titletext);
        GUILayout.BeginHorizontal();
        heightStart = GUILayout.TextField(heightStart);
        GUILayout.TextField("-", titletext);
        heightEnd = GUILayout.TextField(heightEnd);
        GUILayout.EndHorizontal();

        //speed
        GUILayout.TextField("Speed (how fast does this race move. 30 is the normal speed, change incriments of 5)", titletext);
        speed = Regex.Replace(speed, "[^0-9]", "");
        speed = GUILayout.TextField(speed, GUILayout.Width(50), GUILayout.Height(30));

        //darkvision
        darkVision = GUILayout.Toggle(darkVision, "Darkvision (can this race see in the dark)", titletext);

        //Raceal bonus
        GUILayout.BeginHorizontal();
        GUILayout.TextField("Raceal Bonus", titletext);
        if (GUILayout.Button("+"))
        {

        }
        GUILayout.EndHorizontal();
        GUILayout.TextArea(Bonus, GUILayout.Width(650), GUILayout.Height(120));

        //languages
        GUILayout.BeginHorizontal();
        GUILayout.TextField("Languages (what languages does this race speak)", titletext);
        if (GUILayout.Button("+"))
        {

        }
        GUILayout.EndHorizontal();
        GUILayout.TextArea(lang, GUILayout.Width(650), GUILayout.Height(30));

        //Sub races TODO
        GUILayout.BeginHorizontal();
        GUILayout.TextField("Sub Race", titletext);
        if (GUILayout.Button("+"))
        {

        }
        GUILayout.EndHorizontal();
        GUILayout.TextArea(subrace, GUILayout.Width(650), GUILayout.Height(120));

        //History
        GUILayout.TextField("History (backstory for the race", titletext);
        history = GUILayout.TextArea(history, GUILayout.Width(650), GUILayout.Height(600));

        GUILayout.EndScrollView();

        GUILayout.EndArea();
    }
}
