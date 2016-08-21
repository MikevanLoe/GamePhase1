using UnityEngine;
using System.Collections;

public class Creature : AI
{
	private int maxHealth;
	private int currentHealth;
	private int experience;
	private int level;

	public Profile growthProfile;
	public BaseStats baseStats;
	public BaseStats currentStats;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	private int GetLevel()
	{
		// stuff with experience

		// modify currentStats

		return 0;
	}
}