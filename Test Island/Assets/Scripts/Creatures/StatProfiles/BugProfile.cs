using System;

public class BugProfile : Profile
{
	public BugProfile ()
	{
		this.Special = GrowthRate.Slower;
		this.Defense = GrowthRate.Faster;
		this.Attack = GrowthRate.Slow;
		this.Speed = GrowthRate.Average;
		this.Endurance = GrowthRate.SuperFast;
	}
}