using System;

public class MythicalProfile : Profile
{
	public MythicalProfile ()
	{
		this.Special = GrowthRate.SuperFast;
		this.Defense = GrowthRate.Faster;
		this.Attack = GrowthRate.Fast;
		this.Speed = GrowthRate.Slow;
		this.Endurance = GrowthRate.Average;
	}
}