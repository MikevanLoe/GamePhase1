using System;

public enum GrowthRate
{
	SuperSlow = 25,
	Slower = 30,
	Slow = 50,
	Average = 100,
	Fast = 200,
	Faster = 300,
	SuperFast = 400
}

public class Profile
{
	private GrowthRate special;
	private GrowthRate defense;
	private GrowthRate attack;
	private GrowthRate speed;
	private GrowthRate endurance;
	private GrowthRate experience;

	public GrowthRate Special { get { return special; } }
	public GrowthRate Defense { get { return defense; } }
	public GrowthRate Attack { get { return attack; } }
	public GrowthRate Speed { get { return speed; } }
	public GrowthRate Endurance { get { return endurance; } }
	public GrowthRate Experience { get { return experience; } }

	public Profile (GrowthRate spc, GrowthRate def, GrowthRate atk, GrowthRate spd, GrowthRate end, GrowthRate exp)
	{
		this.special = spc;
		this.defense = def;
		this.attack = atk;
		this.speed = spd;
		this.endurance = end;
		this.experience = exp;
	}
}