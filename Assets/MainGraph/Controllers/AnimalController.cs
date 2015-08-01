using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using uFrame.Serialization;
using uFrame.MVVM;
using uFrame.Kernel;
using uFrame.IOC;


public class AnimalController : AnimalControllerBase {
    
	public override void InitializeAnimal (AnimalViewModel viewModel)
	{
		base.InitializeAnimal (viewModel);
		// This is called when a CharacterViewModel is created
	}
}
