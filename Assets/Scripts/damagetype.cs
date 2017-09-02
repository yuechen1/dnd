using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagetype : MonoBehaviour {

    public static damagetype damagetypes;
    public string[] damageType = { "Acid", "Bludgeoning", "Cold", "Fire", "Force", "Lightning", "Necrotic", "Piercing", "Poison", "Psychic", "Radiant", "Slashing", "Thunder" };

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
        if (damagetypes == null)
            damagetypes = this;
        else
            Destroy(this);
	}
	
}
