using System;
using UnityEngine;

public class testCreature : Creature
{
	void Start ()
	{
		this.growthProfile = new MythicalProfile ();
		this.baseStats = new testStats ();
	}

	void Update ()
	{
		
	}
}