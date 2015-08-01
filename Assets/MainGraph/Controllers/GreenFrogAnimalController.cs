using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using uFrame.Serialization;
using uFrame.MVVM;
using uFrame.Kernel;
using uFrame.IOC;


public class GreenFrogAnimalController : GreenFrogAnimalControllerBase {
    
    public override void InitializeGreenFrogAnimal(GreenFrogAnimalViewModel viewModel) {
        base.InitializeGreenFrogAnimal(viewModel);
        // This is called when a GreenFrogAnimalViewModel is created
    }
}
