using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UnityEngine;


public class InGameRootViewHelper : InGameRootViewHelperBase {

	public static Vector3 Loc2Pos (Loc loc)
	{
		return new Vector3 ((float)((loc.x - 3) * 2), (float)((loc.y - 2) * 2));
	}
}
