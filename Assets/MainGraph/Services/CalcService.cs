using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;
using UniRx;
using UnityEngine;


public class CalcService : CalcServiceBase {

	public override void CheckSameCountCommandHandler (CheckSameCountCommand data)
	{
		base.CheckSameCountCommandHandler (data);
		AnimalViewModel centerAnimal = data.CenterAnimal;

		GameObject MapContainerObj = GameObject.Find ("MapContainerObj");

	}
}
