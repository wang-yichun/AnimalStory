using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;
using UniRx;
using UnityEngine;

public class Common : CommonBase
{
	[Inject]
	public Locator
		Locator;
	public GameObject[] AnimalsPrefab;

	public override void InitMapContainerCommandHandler (InitMapContainerCommand data)
	{
		base.InitMapContainerCommandHandler (data);
		GameObject MapContainerObj = GameObject.Find ("MapContainerObj");
		for (int y = Locator.ymin; y <= Locator.ymax; y++) {
			for (int x = Locator.xmin; x <= Locator.xmax; x++) {
				string name = Locator.Loc2Name (new Loc (){ x = x, y = y });

				var animalVM = this.CreateViewModel<AnimalViewModel>();

				GameObject containerObj = MapContainerObj.transform.FindChild (name).gameObject;

//				containerObj.InitializeView(AnimalsPrefab[0], animalVM);

//				GameObject animalObj = InstantiateView("BlueBirdAnimal", "BlueBirdAnimal") as AnimalViewBase;

//				GameObject animalObj = Instantiate (AnimalsPrefab [UnityEngine.Random.Range (0, 3)]) as GameObject;
//				animalObj.transform.parent = containerObj.transform;
//				animalObj.transform.localPosition = Vector3.zero;
//
//				AnimalViewModel avm = animalObj.GetComponent<AnimalView> ().Animal;
//				avm.Loc = new Loc (){x = x, y = y};
//				avm.sameCount = 0;

//				data.InGameRootViewModel.AnimalCollections.Add (avm);
			}
		}
	}
}
