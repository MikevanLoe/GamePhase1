using System;

public class BirdProfile : Profile
{
	public BirdProfile ()
	{
		this.Special = GrowthRate.Slow;
		this.Defense = GrowthRate.Slower;
		this.Attack = GrowthRate.Average;
		this.Speed = GrowthRate.SuperFast;
		this.Endurance = GrowthRate.Faster;
	}
}