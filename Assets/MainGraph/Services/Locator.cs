using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;
using UniRx;
using UnityEngine;

public class Locator : LocatorBase
{

	public int xmin, xmax;
	public int ymin, ymax;

	public bool IsInScope (Loc loc)
	{
		return loc.x >= xmin || loc.x <= xmax || loc.y >= ymin || loc.y <= ymax;
	}

	public string Loc2Name (Loc loc)
	{
		if (this.IsInScope (loc)) {
			return "0" + loc.y + "0" + loc.x;
		}
		return null;
	}


}
