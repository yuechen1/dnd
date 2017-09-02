using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condition : MonoBehaviour {

    public static condition conditions;
    public string[] allconditions = { "Blinded", "Charmed", "Deafened", "Exhaustion", "Frightened", "Grappled", "Incapacitated", "Invisible", "Paralyzed", "Petrified", "Poisoned", "Prone", "Restrained", "Stunned", "Unconscious"};

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
        if (conditions == null)
            conditions = this;
        else
            Destroy(this);
	}
	
	
}
