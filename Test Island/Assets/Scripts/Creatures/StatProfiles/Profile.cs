using System;

enum GrowthRate
{
	SuperSlow = 0.25,
	Slower = 0.3,
	Slow = 0.5,
	Average = 1,
	Fast = 2,
	Faster = 3,
	SuperFast = 4
}

public class Profile
{
	public GrowthRate Special;
	public GrowthRate Defense;
	public GrowthRate Attack;
	public GrowthRate Speed;
	public GrowthRate Endurance;

	public Profile (GrowthRate spc, GrowthRate def, GrowthRate atk, GrowthRate spd, GrowthRate end)
	{
		Special = spc;
		Defense = def;
		Attack = atk;
		Speed = spd;
		Endurance = end;
	}
}