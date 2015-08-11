using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;
using UniRx;
using UnityEngine;
using Random = UnityEngine.Random;

public class Locator : LocatorBase
{
	[Inject("InGameRoot")]
	static public InGameRootViewModel
		InGameRoot;
	
	public static bool IsInScope (Loc loc)
	{
		return loc.x >= InGameRoot.MapInfo.xmin || loc.x <= InGameRoot.MapInfo.xmax || loc.y >= InGameRoot.MapInfo.ymin || loc.y <= InGameRoot.MapInfo.ymax;
	}

	public static string Loc2Name (Loc loc)
	{
		if (Locator.IsInScope (loc)) {
			return "0" + loc.y + "0" + loc.x;
		}
		return null;
	}

	public static AnimalType RandomGetAnimalType ()
	{
		AnimalType[] types = new AnimalType[]{
			AnimalType.BLUE_BIRD,
			AnimalType.COFFEE_COW,
			AnimalType.GREEN_FROG
		};

		return types [Random.Range (0, types.Length)];
	}

}
