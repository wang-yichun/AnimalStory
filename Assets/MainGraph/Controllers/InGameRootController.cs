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

public class InGameRootController : InGameRootControllerBase
{
	
	[Inject]
	public Locator
		Locator;

	public override void InitializeInGameRoot (InGameRootViewModel viewModel)
	{
		base.InitializeInGameRoot (viewModel);
		// This is called when a InGameRootViewModel is created
	}

	public override void CreateAnimal (InGameRootViewModel viewModel, AnimalProp arg)
	{
		base.CreateAnimal (viewModel, arg);

		AnimalViewModel animalVM = this.CreateViewModel<AnimalViewModel> ();
		animalVM.sameCount = 0;
		animalVM.AnimalType = arg.AnimalType;
		animalVM.Loc = arg.Loc;

		viewModel.AnimalCollections.Add (animalVM);
	}

	public override void InitAllAnimal (InGameRootViewModel viewModel)
	{
		base.InitAllAnimal (viewModel);

		for (int y = viewModel.MapInfo.ymin; y <= viewModel.MapInfo.ymax; y++) {
			for (int x = viewModel.MapInfo.xmin; x <= viewModel.MapInfo.xmax; x++) {

				viewModel.CreateAnimal.OnNext (new CreateAnimalCommand () {
					Argument = new AnimalProp () {
						AnimalType = Locator.RandomGetAnimalType(),
						Loc = new Loc() {x = x, y = y}
					}
				});

			}
		}


	}
}
