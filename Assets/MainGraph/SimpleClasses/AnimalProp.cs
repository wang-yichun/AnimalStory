using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;

public class AnimalProp : AnimalPropBase
{
	public AnimalProp ()
	{
	}

	public AnimalProp (AnimalViewModel animal)
	{
		this.AnimalType = animal.AnimalType;
		this.Loc = animal.Loc;
	}
}
