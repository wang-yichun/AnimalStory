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
	
	[Inject] public Locator Locator;

    public override void InitializeInGameRoot(InGameRootViewModel viewModel) {
        base.InitializeInGameRoot(viewModel);
        // This is called when a InGameRootViewModel is created
    }
}
 