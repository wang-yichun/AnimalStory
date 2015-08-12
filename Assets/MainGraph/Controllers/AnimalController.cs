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

		if (InGameRoot.CanTap) {
			InGameRoot.RefreshSameCount.OnNext (new RefreshSameCountCommand () {
				Argument = viewModel
			});
		} else {
			Debug.Log ("can not tap");
		}

	}

	public override void DestroySelf (AnimalViewModel viewModel)
	{
		base.DestroySelf (viewModel);
		InGameRoot.RemoveAnimal.OnNext (new RemoveAnimalCommand (){
			Argument = new AnimalProp(viewModel)
		});
	}

    public override void GotDropTarget(AnimalViewModel viewModel) {
        base.GotDropTarget(viewModel);
    }

    public override void StartDrop(AnimalViewModel viewModel) {
        base.StartDrop(viewModel);
    }

    public override void DebugCommand(AnimalViewModel viewModel) {
        base.DebugCommand(viewModel);
		Debug.Log (String.Format ("({0},{1})", viewModel.Loc.x, viewModel.Loc.y));
    }

    public override void GotIdle(AnimalViewModel viewModel) {
        base.GotIdle(viewModel);
		InGameRoot.CalcAnimalsCount.OnNext (new CalcAnimalsCountCommand ());
    }
}
