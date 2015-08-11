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


public partial class AnimalViewModel : AnimalViewModelBase {
	public Guid guid;

	public override bool ComputeShouldDestroy ()
	{
		return needDestroy;
	}

	public override bool ComputeShouldDrop ()
	{
		return needDrop;
	}

	public override bool ComputeShouldNotDrop ()
	{
		return !needDrop;
	}
}
