using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class buildsub : MonoBehaviour {

    private Race newrace;

    private float SCREENHEIGHT = 560;
    private float BUTTONWIDTH = 170;
    private float BUTTONHEIGHT = 45;
    private float RACESCROLLWIDTH = 915;
    private float TEXTHEIGHT = 30;

    private string test;

    //menu select
    private bool racemenu;
    private bool racemneulanguage;
    private bool classmenu;
    private bool abilitymenu;
    private bool featsmenu;


    //save condition bool
    private bool racesavebool;


    //ui scroll vector
    private Vector2 characterscroll;

    //styles
    GUIStyle titletext = new GUIStyle();
    Texture2D darkvisiontoggle;

    //race stats
    private string STR, CON, DEX, INT, WIS, CHA;
    private string MaleName, FemaleName, LastName;
    private string AgeStart, AgeEnd, HeightStart, HeightEnd, Speed;
    private string knownlanguage;

    void Start () {
        DontDestroyOnLoad(this);
        characterscroll = new Vector2();
        newrace = ScriptableObject.CreateInstance<Race>();
        test = "";

        //font
        titletext.fontSize = 20;
        titletext.fontStyle = FontStyle.Bold;

        //race defaults
        STR = CON = DEX = INT = WIS = CHA = "";
        MaleName = FemaleName = LastName = "";
        AgeStart = AgeEnd = HeightStart = HeightEnd = Speed = knownlanguage = "";
        racemneulanguage = false;
        
    }

    
    private void OnGUI()
    {

        GUILayout.BeginArea(new Rect(0, 0, Screen.width, SCREENHEIGHT));
        GUILayout.BeginHorizontal();
        GUILayout.BeginVertical();
        if(GUILayout.Button("Race", GUILayout.Height(BUTTONHEIGHT), GUILayout.Width(BUTTONWIDTH)))
        {
            racemenu = true;
            classmenu = false;
            abilitymenu = false;
            featsmenu = false;
        }
        if (GUILayout.Button("CLASSES", GUILayout.Height(BUTTONHEIGHT), GUILayout.Width(BUTTONWIDTH)))
        {
            racemenu = false;
            classmenu = true;
            abilitymenu = false;
            featsmenu = false;
        }
        if (GUILayout.Button("ABILITY", GUILayout.Height(BUTTONHEIGHT), GUILayout.Width(BUTTONWIDTH)))
        {
            racemenu = false;
            classmenu = false;
            abilitymenu = true;
            featsmenu = false;
        }
        if (GUILayout.Button("FEATS", GUILayout.Height(BUTTONHEIGHT), GUILayout.Width(BUTTONWIDTH)))
        {
            racemenu = false;
            classmenu = false;
            abilitymenu = false;
            featsmenu = true;
        }
        GUILayout.EndVertical();

        if (racemenu)
        {
            characterscroll = GUILayout.BeginScrollView(characterscroll, GUILayout.Width(RACESCROLLWIDTH), GUILayout.Height(SCREENHEIGHT));
            //contaner for the scroll
            GUILayout.BeginVertical();

            GUILayout.BeginHorizontal();
            //for the image/nav and name layout
            if (GUILayout.Button("imiage goes here", GUILayout.Width(BUTTONWIDTH), GUILayout.Height(265)))
            {

            }

            GUILayout.Space(5);

            //name input/discription
            GUILayout.BeginVertical();
            GUILayout.BeginHorizontal();
            
            GUILayout.TextField("Race Name:", titletext);
            newrace.raceName = GUILayout.TextField(newrace.raceName, GUILayout.Width(BUTTONWIDTH), GUILayout.Height(TEXTHEIGHT));
            GUILayout.Space(RACESCROLLWIDTH - 3*BUTTONWIDTH);
            GUILayout.EndHorizontal();
            GUILayout.Space(10);

            //race discription
            GUILayout.TextArea("Discription:", titletext);
            newrace.discription = GUILayout.TextArea(newrace.discription, GUILayout.Width(RACESCROLLWIDTH - 50 - BUTTONWIDTH), GUILayout.Height(TEXTHEIGHT * 5));
            GUILayout.Space(10);

            GUILayout.BeginHorizontal(GUILayout.Width(RACESCROLLWIDTH - 50 - BUTTONWIDTH));
            //STR
            GUILayout.TextField("STR", titletext);
            if (STR != null)
                STR = Regex.Replace(STR, "[^0-9]", "");
            STR = GUILayout.TextField(STR, 2, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.Space(20);
            //CON
            GUILayout.TextField("CON", titletext);
            if(CON != null)
                CON = Regex.Replace(CON, "[^0-9]", "");
            CON = GUILayout.TextField(CON, 2, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.Space(20);
            //DEX
            GUILayout.TextField("DEX", titletext);
            if(DEX != null)
                DEX = Regex.Replace(DEX, "[^0-9]", "");
            DEX = GUILayout.TextField(DEX, 2, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.Space(20);
            //INT
            GUILayout.TextField("INT", titletext);
            if(INT != null)
                INT = Regex.Replace(INT, "[^0-9]", "");
            INT = GUILayout.TextField(INT, 2, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.Space(20);
            //WIS
            GUILayout.TextField("WIS", titletext);
            if(WIS != null)
                WIS = Regex.Replace(WIS, "[^0-9]", "");
            WIS = GUILayout.TextField(WIS, 2, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.Space(20);
            //CHA
            GUILayout.TextField("CHA", titletext);
            if(CHA != null)
                CHA = Regex.Replace(CHA, "[^0-9]", "");
            CHA = GUILayout.TextField(CHA, 2, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
            GUILayout.Space(10);

            //names
            GUILayout.TextField("Tipical Names for this Race (each entry seperated by ,)", titletext);
            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            GUILayout.TextField("Male", titletext);
            MaleName = GUILayout.TextArea(MaleName, GUILayout.Width(RACESCROLLWIDTH / 3 - 20), GUILayout.Height(TEXTHEIGHT * 4));
            GUILayout.EndVertical();
            GUILayout.BeginVertical();
            GUILayout.TextField("Female", titletext);
            FemaleName = GUILayout.TextArea(FemaleName, GUILayout.Width(RACESCROLLWIDTH / 3 - 20), GUILayout.Height(TEXTHEIGHT * 4));
            GUILayout.EndVertical();
            GUILayout.BeginVertical();
            GUILayout.TextField("Last", titletext);
            LastName = GUILayout.TextArea(LastName, GUILayout.Width(RACESCROLLWIDTH / 3 - 20), GUILayout.Height(TEXTHEIGHT * 4));
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
            
            //Age Range
            GUILayout.BeginHorizontal(GUILayout.Width(200));
            GUILayout.TextField("Age", titletext);
            GUILayout.Space(26);
            if (AgeStart != null)
                AgeStart = Regex.Replace(AgeStart, "[^0-9]", "");
            AgeStart = GUILayout.TextField(AgeStart, 3, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.TextField("to", titletext);
            if (AgeEnd != null)
                AgeEnd = Regex.Replace(AgeEnd, "[^0-9]", "");
            AgeEnd = GUILayout.TextField(AgeEnd, 3, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.EndHorizontal();
           
            //Height Range
            GUILayout.BeginHorizontal(GUILayout.Width(200));
            GUILayout.TextField("Height", titletext);
            if (HeightStart != null)
                HeightStart = Regex.Replace(HeightStart, "[^0-9]", "");
            HeightStart = GUILayout.TextField(HeightStart, 3, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.TextField("to", titletext);
            if (HeightEnd != null)
                HeightEnd = Regex.Replace(HeightEnd, "[^0-9]", "");
            HeightEnd = GUILayout.TextField(HeightEnd, 3, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.EndHorizontal();

            //Speed
            GUILayout.BeginHorizontal(GUILayout.Width(100));
            GUILayout.TextField("Speed", titletext);
            GUILayout.Space(7);
            if (Speed != null)
                Speed = Regex.Replace(Speed, "[^0-9]", "");
            Speed = GUILayout.TextField(Speed, 2, GUILayout.Width(50), GUILayout.Height(TEXTHEIGHT));
            GUILayout.EndHorizontal();
            GUILayout.Space(10);

            //dark vision
            GUILayout.BeginHorizontal(GUILayout.Width(100));
            GUILayout.TextField("Darkvision", titletext);

            if (newrace.darkVision)
            {
                GUI.color = Color.green;
            }
            else
            {
                GUI.color = Color.grey;
            }
            if(GUILayout.Button(" "))
            {
                if (newrace.darkVision)
                    newrace.darkVision = false;
                else
                    newrace.darkVision = true;
            }
            GUI.color = Color.grey;
            GUILayout.EndHorizontal();
            GUILayout.Space(10);

            //language
            GUILayout.BeginHorizontal(GUILayout.Width(100));
            GUILayout.TextField("Language", titletext);
            if (GUILayout.Button("+"))
            {
                if (racemneulanguage == true)
                    racemneulanguage = false;
                else
                    racemneulanguage = true;
            }
            if (racemneulanguage)
            {
                GUILayout.BeginVertical();
                {
                    if (newrace.languages == null)
                    {
                        foreach (Language.Lang i in Language.languages.language)
                        {
                            if (GUILayout.Button(i.language, GUILayout.Width(100)))
                            {
                                newrace.languages.Add(i);
                            }                            
                        }
                    }
                    else
                    {
                        foreach (Language.Lang i in Language.languages.language)
                        {
                            if (!newrace.languages.Contains(i))
                            {
                                if (GUILayout.Button(i.language, GUILayout.Width(100)))
                                {
                                    newrace.languages.Add(i);
                                }
                            }
                        }
                    }
                }
                GUILayout.EndVertical();
            }
            if(GUILayout.Button("-"))
            {
                if (racemneulanguage == true)
                    racemneulanguage = false;
                else
                    racemneulanguage = true;
            }
            if(racemneulanguage)
            {
                GUILayout.BeginVertical();
                {
                    if (newrace.languages == null)
                    {
                       
                    }
                    else
                    {
                        foreach (Language.Lang i in newrace.languages)
                        {
                            if (GUILayout.Button(i.language, GUILayout.Width(100)))
                            {
                                newrace.languages.Remove(i);
                            }                                                        
                        }
                    }
                }
                GUILayout.EndVertical();
            }
            GUILayout.EndHorizontal();
            knownlanguage = "";
            if(newrace.languages != null)
            {
                foreach(Language.Lang i in newrace.languages)
                {
                    knownlanguage += i.language + " | ";
                }
            }
            GUILayout.TextField(knownlanguage);

            test = GUILayout.TextArea(test, GUILayout.Width(RACESCROLLWIDTH - 35), GUILayout.Height(2000));
            //save the character
            GUI.enabled = racesavebool;
            if (GUILayout.Button("Save", GUILayout.Width(BUTTONWIDTH), GUILayout.Height(BUTTONHEIGHT)))
            {

            }
            GUILayout.EndVertical();
            GUILayout.EndScrollView();
        }

        if (classmenu)
        {
            characterscroll = GUILayout.BeginScrollView(characterscroll, GUILayout.Width(918), GUILayout.Height(SCREENHEIGHT));
            GUILayout.BeginVertical();
            GUILayout.TextField("Class Name: ");
            test = GUILayout.TextArea(test, GUILayout.Width(918), GUILayout.Height(2000));
            GUILayout.EndVertical();
            GUILayout.EndScrollView();
        }

        if (abilitymenu)
        {

            GUILayout.Button(" ");

        }
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
