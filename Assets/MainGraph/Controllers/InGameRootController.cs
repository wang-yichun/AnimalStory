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
		animalVM.SameCount = 0;
		animalVM.AnimalType = arg.AnimalType;
		animalVM.Loc = arg.Loc;

		viewModel.AnimalCollections.Add (animalVM);

		viewModel.CalcAnimalsCount.OnNext (new CalcAnimalsCountCommand ());
	}
	
	public override void RemoveAnimal (InGameRootViewModel viewModel, AnimalProp arg)
	{
		base.RemoveAnimal (viewModel, arg);

		AnimalViewModel vm = this.GetAnimalAtLoc (viewModel, arg.Loc);
		viewModel.AnimalCollections.Remove (vm);

		viewModel.CalcAnimalsCount.OnNext (new CalcAnimalsCountCommand ());
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

	public override void TestCommand (InGameRootViewModel viewModel)
	{
		base.TestCommand (viewModel);

		var locList = viewModel.AnimalCollections
			.Where (vm => vm.AnimalType == AnimalType.BLUE_BIRD)
				.Select (vm => vm.Loc)
				.ToDictionary (loc => Locator.Loc2Name (loc), loc => "x:" + loc.x.ToString ());

		foreach (var v in locList) {
			Debug.Log (v.Key + " - " + v.Value);
		}

	}

	public override void RefreshSameCount (InGameRootViewModel viewModel, AnimalViewModel arg)
	{
		base.RefreshSameCount (viewModel, arg);


		List <AnimalViewModel> list1 = new List<AnimalViewModel> ();
		List <AnimalViewModel> list2 = new List<AnimalViewModel> ();
		
		Loc loc0 = arg.Loc;
		AnimalType type0 = arg.AnimalType;
		Guid guid = Guid.NewGuid ();

		arg.guid = guid;
		list1.Add (arg);

		while (list1.Count > 0) {
			AnimalViewModel vm = list1 [0];
			list1.RemoveAt (0);
			list2.Add (vm);

			List<Loc> locList = Locator.AroundLoc (vm.Loc);
			foreach (Loc loc in locList) {
				AnimalViewModel _vm = this.GetAnimalAtLoc (viewModel, loc);
				if (_vm != null) {
					if (_vm.guid != guid) {
						if (_vm.AnimalType == type0) {
							_vm.guid = guid;
							list1.Add (_vm);
						}
					}
				}
			}
		}

		foreach (AnimalViewModel _vm in list2) {
			_vm.SameCount = list2.Count;

			if (_vm.SameCount >= viewModel.RuleInfo.DestroyLimitCount) {
				_vm.needDestroy = true;
			}
		}

		viewModel.CalcAnimalsCount.OnNext (new CalcAnimalsCountCommand ());
	}

	public AnimalViewModel GetAnimalAtLoc (InGameRootViewModel viewModel, Loc loc)
	{
		return viewModel.AnimalCollections.Where (vm => vm.Loc == loc).SingleOrDefault ();
	}

	public override void CalcAnimalsCount (InGameRootViewModel viewModel)
	{
		base.CalcAnimalsCount (viewModel);

		int nullCounn = viewModel.MapInfo.TotalAnimalCount - viewModel.AnimalCollections.Count;

		viewModel.NullAnimalsCount = nullCounn;

		int idleCount = viewModel.AnimalCollections
			.Where (animal => animal.AnimalState is Idle && animal.needDestroy == false)
				.Count ();
		
		viewModel.IdleAnimalsCount = idleCount;
	}

	public override void CreateAndDrop (InGameRootViewModel viewModel)
	{
		base.CreateAndDrop (viewModel);
		Debug.Log ("todo: CreateAndDrop");

		Dictionary<int, int> existColInfo = GetExistCountByCol (viewModel);
		for (int x = viewModel.MapInfo.xmin; x <= viewModel.MapInfo.xmax; x++) {
			int existCount;
			if (existColInfo.TryGetValue (x, out existCount)) {
				int needAddCount = viewModel.MapInfo.ymax - existCount;
				int nully = 0;
				for (int y = viewModel.MapInfo.ymin; y <= viewModel.MapInfo.ymax; y++) {

					AnimalViewModel animal = GetAnimalAtLoc (viewModel, new Loc (x, y));

					if (animal == null) {
						nully = y;
						break;
					} else {
						if (nully != 0) { // haven't got null space, yet.
							animal.TargetProp = new AnimalProp () {
								AnimalType = animal.AnimalType,
								Loc = new Loc(x, nully)
							};

							nully++;
						}
					}

				}
			}
			
			Debug.Log ("existCount: " + existCount);

		}
	}

	/**
	 * return: 1:x1 2:x1 3:x1 4:x4 5:x1
	 * */
	public Dictionary<int, int> GetExistCountByCol (InGameRootViewModel viewModel)
	{
		var dictionary = viewModel.AnimalCollections
			.GroupBy (animal => new {animal.Loc.x})
				.ToDictionary (it => it.Key.x, it => it.Count ());


//		foreach (var it in dictionary) {
//			Debug.Log(it.Key + " : " + it.Value);
//		}

		return dictionary;
	}

	public override void AnimalDropTo (InGameRootViewModel viewModel, AnimalDropToCommand arg)
	{
		base.AnimalDropTo (viewModel, arg);
	}
}
