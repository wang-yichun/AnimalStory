using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using uFrame.Serialization;
using uFrame.MVVM;
using uFrame.Kernel;
using uFrame.IOC;
using UnityEngine;

public class AnimalController : AnimalControllerBase
{
    
	[Inject("InGameRoot")]
	public InGameRootViewModel
		InGameRoot;

	public override void InitializeAnimal (AnimalViewModel viewModel)
	{
		base.InitializeAnimal (viewModel);
		// This is called when a CharacterViewModel is created
	}

	public override void Tapped (AnimalViewModel viewModel)
	{
		base.Tapped (viewModel);
		
		Debug.Log ("tapped: " + viewModel.AnimalType);
		InGameRoot.RefreshSameCount.OnNext (new RefreshSameCountCommand () {
			Argument = viewModel
		});

	}

    public override void DestroySelf(AnimalViewModel viewModel) {
        base.DestroySelf(viewModel);
		InGameRoot.RemoveAnimal.OnNext (new RemoveAnimalCommand (){
			Argument = new AnimalProp(viewModel)
		});
    }

}
