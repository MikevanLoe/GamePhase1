using System;

public class MythicalProfile : Profile
{
	public MythicalProfile (GrowthRate spc = GrowthRate.SuperFast,
							GrowthRate def = GrowthRate.Faster,
	                        GrowthRate atk = GrowthRate.Fast,
	                        GrowthRate spd = GrowthRate.Slow,
	                        GrowthRate end = GrowthRate.Average,
	                        GrowthRate exp = GrowthRate.Slow)
		: base (spc, def, atk, spd, end, exp)
	{

	}
}