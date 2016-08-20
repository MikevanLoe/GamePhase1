using System;

public class PlantProfile : Profile
{
	public PlantProfile ()
	{
		this.Special = GrowthRate.Fast;
		this.Defense = GrowthRate.SuperFast;
		this.Attack = GrowthRate.Slow;
		this.Speed = GrowthRate.SuperSlow;
		this.Endurance = GrowthRate.Faster;
	}
}