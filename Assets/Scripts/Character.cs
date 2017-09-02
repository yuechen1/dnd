using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : ScriptableObject {

    //ability points
    private int STR;
    private int CON;
    private int DEX;
    private int INT;
    private int WIS;
    private int CHA;
    private int STRmod;
    private int CONmod;
    private int DEXmod;
    private int INTmod;
    private int WISmod;
    private int CHAmod;
    private int STRsave;
    private int CONsave;
    private int DEXsave;
    private int INTsave;
    private int WISsave;
    private int CHAsave;

    //skills in the same order as in the skills class
    private List<int> skills;
    private List<string> proficiency;
    private List<string> itemproficiency;
    private List<bool> resistance;
    private List<bool> vulnerbility;

    //physical info for the character
    private Race race;
    private string sex;
    private string charactername;
    private int height;
    private int weight;
    private string alignment;
    private List<Language.Lang> languages;
    private bool darkvision;
    private int speed;
    private int getup;
    private int size;
    private int maxHealth;
    private int resttime;

    //character fluf
    private string personality;
    private string ideals;
    private string bonds;
    private string flaws;
    private List<string> background; //TODO change to ability once thats done
    private List<string> profession; //TODO change to profession once thats done

    //equipment
    //TODO change to class item once thats done
    private List<string> items;
    private List<int> money;
    private string lefthand;
    private string righthand;
    private string body;
    private string neck;
    private List<string> rings;

    //spells and special abilitys
    //TODO change to class spells once thats done
    private List<string> spells;
    private List<string> powers;
    private List<string> feat;

    //Conditions
    private List<string> conditions; //TODO change to condition once thats done

    //combat
    private int armorClass;
    private int initiative;
    private int proficiencybonus;

    // Use this for initialization
    void Start () {
        skills = new List<int>(18);
	}
	
}
