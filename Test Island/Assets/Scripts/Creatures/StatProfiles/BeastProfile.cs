using System;

public class BeastProfile : Profile
{
	public BeastProfile (GrowthRate spc = GrowthRate.SuperSlow,
	                     GrowthRate def = GrowthRate.Faster,
	                     GrowthRate atk = GrowthRate.SuperFast,
	                     GrowthRate spd = GrowthRate.Average,
	                     GrowthRate end = GrowthRate.Average,
	                     GrowthRate exp = GrowthRate.Fast)
		: base (spc, def, atk, spd, end, exp)
	{

	}
}