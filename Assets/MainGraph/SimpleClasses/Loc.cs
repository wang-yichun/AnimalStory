using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;

public class Loc : LocBase
{
	public static bool operator == (Loc a, Loc b)
	{
		// If both are null, or both are same instance, return true.
		if (System.Object.ReferenceEquals(a, b))
		{
			return true;
		}
		
		// If one is null, but not both, return false.
		if (((object)a == null) || ((object)b == null))
		{
			return false;
		}

		return a.x == b.x && a.y == b.y;
	}

	public static bool operator != (Loc a, Loc b) {
		return !(a == b);
	}
}
