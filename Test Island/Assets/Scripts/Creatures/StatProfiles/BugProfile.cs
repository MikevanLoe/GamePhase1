using System;

public class BugProfile : Profile
{
	public BugProfile (GrowthRate spc = GrowthRate.Slower,
	                   GrowthRate def = GrowthRate.Faster,
	                   GrowthRate atk = GrowthRate.Slow,
	                   GrowthRate spd = GrowthRate.Average,
	                   GrowthRate end = GrowthRate.SuperFast,
	                   GrowthRate exp = GrowthRate.SuperFast)
		: base (spc, def, atk, spd, end, exp)
	{

	}
}