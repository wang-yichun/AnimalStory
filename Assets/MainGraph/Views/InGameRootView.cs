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

public class InGameRootView : InGameRootViewBase
{
	public GameObject MapContainerObj;
	public GameObject[] AnimalsPrefab;

	protected override void InitializeViewModel (uFrame.MVVM.ViewModel model)
	{
		base.InitializeViewModel (model);
		// NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
		// var vm = model as InGameRootViewModel;
		// This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
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

//		GameObject bb = Instantiate (AnimalsPrefab[0]) as GameObject;
//		bb.transform.parent = this.MapContainerObj.transform;
//		var bbvm = bb.GetViewModel<BlueBirdAnimalViewModel> ();
//		this.InGameRoot.AnimalCollections.Add (bbvm);

//		this.createAnimal ();

//		this.ExecuteCreateAnimal ();

//		Publish (new InitMapContainerCommand () {
//			InGameRootViewModel = this.InGameRoot
//		});

		this.ExecuteCreateAnimal (new AnimalProp () {
			AnimalType = AnimalType.COFFEE_COW,
			Loc = new Loc() {x = 1, y = 1}
		});
	}

//	public void createAnimal ()
//	{
//		for (int idx = 0; idx < MapContainerObj.transform.childCount; idx++) {
//			GameObject containerObj = MapContainerObj.transform.GetChild (idx).gameObject;
//					
//			GameObject animalObj = Instantiate (AnimalsPrefab [UnityEngine.Random.Range (0, 3)]) as GameObject;
//			animalObj.transform.parent = containerObj.transform;
//			animalObj.transform.localPosition = Vector3.zero;
//
//			var avm = animalObj.GetViewModel<AnimalViewModel> ();
//			avm.Loc = new Loc();
//			this.InGameRoot.AnimalCollections.Add (avm);
//		}
//	}

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

//		string name = new Locator().Loc2Name (new Loc (){ x = animalVM.Loc.x, y = animalVM.Loc.y });
		string name = "0101";
		Debug.Log (name);

		GameObject containerObj = MapContainerObj.transform.FindChild (name).gameObject;

		ViewBase animalV = InstantiateView (prefabSelected, viewModel);
		animalV.gameObject.transform.position = containerObj.transform.localPosition;

//		return animalV;  // err parent!!
		return animalV;
	}
}
