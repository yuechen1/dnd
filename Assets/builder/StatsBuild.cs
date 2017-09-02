using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsBuild : MonoBehaviour {

    public int pointby;
    //Strength, Dexterity, Consitution, Intelligence, Wisdom, Charisma
    private List<int> stats; 


	void Start () {
        pointby = 27;
        stats = new List<int>();
        stats.Add(8); stats.Add(8); stats.Add(8); stats.Add(8); stats.Add(8); stats.Add(8);
    }
	
    void setpointby(int i)
    {
        pointby = i;
    }
	
    public List<int> getstats()
    {
        return stats;
    }

	void add(int i)
    {
        if(stats[i] < 8)
        {
            stats[i]++;
        }
        else if (stats[i] < 12)
        {
            stats[i]++;
            pointby--;
        }
        else if (stats[i] < 16)
        {
            stats[i]++;
            pointby -= 2;
        }
        else if (stats[i] < 18)
        {
            stats[i]++;
            pointby -= 3;
        }
        else if (stats[i] > 18)
        { }

    }

    void rev(int i)
    {
        if (stats[i] < 8)
        {
        }
        else if (stats[i] < 12)
        {
            stats[i]--;
            pointby++;
        }
        else if (stats[i] < 16)
        {
            stats[i]--;
            pointby += 2;
        }
        else if (stats[i] < 18)
        {
            stats[i]--;
            pointby += 3;
        }

    }
}
