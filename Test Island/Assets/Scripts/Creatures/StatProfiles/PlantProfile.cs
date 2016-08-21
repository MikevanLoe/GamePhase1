using System;

public class PlantProfile : Profile
{
	public PlantProfile (GrowthRate spc = GrowthRate.Fast,
	                     GrowthRate def = GrowthRate.SuperFast,
	                     GrowthRate atk = GrowthRate.Slow,
	                     GrowthRate spd = GrowthRate.SuperSlow,
	                     GrowthRate end = GrowthRate.Faster,
	                     GrowthRate exp = GrowthRate.Average)
		: base (spc, def, atk, spd, end, exp)
	{
		
	}
}