using System;

public class MythicalProfile : Profile
{
	public MythicalProfile ()
	{
		this.Special = GrowthRate.SuperSlow;
		this.Defense = GrowthRate.Faster;
		this.Attack = GrowthRate.SuperFast;
		this.Speed = GrowthRate.Average;
		this.Endurance = GrowthRate.Average;
	}
}