using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.MVVM.Services;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class InGameRootView : InGameRootViewBase
{
	public GameObject MapContainerObj;
	public GameObject[] AnimalsPrefab;

	public GameObject IdleAnimalsCountText;


	protected override void InitializeViewModel (uFrame.MVVM.ViewModel model)
	{
		base.InitializeViewModel (model);
		// NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
		// var vm = model as InGameRootViewModel;
		// This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.

		InGameRootViewModel viewModel = model as InGameRootViewModel;
		viewModel.MapInfo = new MapInfo (){
			xmax = 5,
			xmin = 1,
			ymax = 3,
			ymin = 1,
			TotalAnimalCount = 15
		};

		viewModel.RuleInfo = new RuleInfo () {
			DestroyLimitCount = 3
		};
	}
    
	public override void Bind ()
	{
		base.Bind ();
		// Use this.InGameRoot to access the viewmodel.
		// Use this method to subscribe to the view-model.
		// Any designer bindings are created in the base implementation.
	}

	public override void OnReady ()
	{
		base.OnReady ();

//		this.InGameRoot.InitAllAnimal.OnNext (new InitAllAnimalCommand());
		this.ExecuteInitAllAnimal ();
	}

	public override ViewBase AnimalCollectionsCreateView (ViewModel viewModel)
	{
		AnimalViewModel animalVM = viewModel as AnimalViewModel;

		GameObject prefabSelected = null;
		switch (animalVM.AnimalType) {
		case AnimalType.BLUE_BIRD:
			prefabSelected = this.AnimalsPrefab [0];
			break;
		case AnimalType.COFFEE_COW:
			prefabSelected = this.AnimalsPrefab [1];
			break;
		case AnimalType.GREEN_FROG:
			prefabSelected = this.AnimalsPrefab [2];
			break;
		default:
			break;
		}

		string name = Locator.Loc2Name (new Loc (){ x = animalVM.Loc.x, y = animalVM.Loc.y });

		GameObject containerObj = MapContainerObj.transform.FindChild (name).gameObject;

		ViewBase animalV = InstantiateView (prefabSelected, viewModel);
		animalV.gameObject.transform.position = containerObj.transform.localPosition;

		return animalV;
	}

	public override void AnimalCollectionsRemoved (ViewBase view)
	{
		base.AnimalCollectionsRemoved (view);
		Destroy (view.gameObject);
	}

    public override void IdleAnimalsCountChanged(Int32 arg1) {
		IdleAnimalsCountText.GetComponent<Text>().text = "IdleAnimalsCountText: " + arg1;
    }

    public override void ShouldCreateAndDropChanged(Boolean arg1) {
		if (arg1) {
			this.ExecuteCreateAndDrop();
		}
    }
}
