using System;

public class BaseStats
{
	private int baseSpecial;
	private int baseDefense;
	private int baseAttack;
	private int baseSpeed;
	private int baseEndurance;

	public int BaseSpecial { get { return baseSpecial; } }
	public int BaseDefense { get { return baseDefense; } }
	public int BaseAttack { get { return baseAttack; } }
	public int BaseSpeed { get { return baseSpeed; } }
	public int BaseEndurance { get { return baseEndurance; } }

	public BaseStats (int spc, int def, int atk, int spd, int end)
	{
		this.baseSpecial = spc;
		this.baseDefense = def;
		this.baseAttack = atk;
		this.baseSpeed = spd;
		this.baseEndurance = end;
	}
}