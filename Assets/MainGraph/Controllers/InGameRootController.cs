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


public class InGameRootController : InGameRootControllerBase {
    
    public override void InitializeInGameRoot(InGameRootViewModel viewModel) {
        base.InitializeInGameRoot(viewModel);
        // This is called when a InGameRootViewModel is created
    }

    public override void CreateAnimal(InGameRootViewModel viewModel) {
        base.CreateAnimal(viewModel);
		Debug.Log ("CreateAnimal func Called!");
    }
}
