using System;

public class BirdProfile : Profile
{
	public BirdProfile (GrowthRate spc = GrowthRate.Slow,
	                    GrowthRate def = GrowthRate.Slower,
	                    GrowthRate atk = GrowthRate.Average,
	                    GrowthRate spd = GrowthRate.SuperFast,
	                    GrowthRate end = GrowthRate.Faster,
	                    GrowthRate exp = GrowthRate.Faster)
		: base (spc, def, atk, spd, end, exp)
	{

	}
}