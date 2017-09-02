using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Alignment : MonoBehaviour {

    public static Alignment alignments;

    public class Alig {
        public string alignment;
        public string discription;

        public Alig(string name, string disc)
        {
            alignment = name;
            discription = disc;
        }
    }

    //holds all the alignments
    List<Alig> Allalignments;

    void Start()
    {
        Allalignments = new List<Alig>();

        DontDestroyOnLoad(this);
        if (alignments == null)
        {
            Allalignments.Add(new Alig("Lawful good", "Creatures can be counted on to do the right thing as expected by society."));
            Allalignments.Add(new Alig("Neutral good", "Folk do the best they can to help others according to their needs."));
            Allalignments.Add(new Alig("Chaotic good", "Creatures act as their conscience directs, with little regard for what others expect."));
            Allalignments.Add(new Alig("Lawful neutral", "Individuals act in accordance with law, tradition, or personal codes."));
            Allalignments.Add(new Alig("Neutral", "The alignment of those who perfer to steer clear of moral questions and don't take sides."));
            Allalignments.Add(new Alig("Chaotic neutral", "Creatures follow their whims, holding their personal freedom above all else."));
            Allalignments.Add(new Alig("Lawful good", "Creatures can be counted on to do the right thing as expected by society."));
            Allalignments.Add(new Alig("Lawful evil", "Creatures methodically take what they want, within the limits of a code of tradition, loyalty or order."));
            Allalignments.Add(new Alig("Neutral evil", "Alignment of those who do whatever they can get away with, without compassion or qualms"));
            Allalignments.Add(new Alig("Chaotic neutral", "Creatures act with arbitrary violence, spurred by their greed, hatred or bloodlust."));

            alignments = this;
        }
        else
        {
            Destroy(this);
        }
        
    }

}
