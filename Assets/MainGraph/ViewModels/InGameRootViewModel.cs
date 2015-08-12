using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UnityEngine;
using UniRx;


public partial class InGameRootViewModel : InGameRootViewModelBase {

	public override void Bind ()
	{
		base.Bind ();
	}

	public override bool ComputeCanTap ()
	{
		if (MapInfo == null)
			return false;
		return IdleAnimalsCount == MapInfo.TotalAnimalCount && NullAnimalsCount == 0;
	}

	public override bool ComputeShouldCreateAndDrop ()
	{
		if (MapInfo == null) 
			return false;

		if (IsDropping) {
			return false;
		}

		return NullAnimalsCount > 0 && IdleAnimalsCount + NullAnimalsCount == MapInfo.TotalAnimalCount;
	}
}
