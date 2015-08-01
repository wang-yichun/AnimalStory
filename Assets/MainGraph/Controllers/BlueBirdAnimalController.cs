using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using uFrame.Serialization;
using uFrame.MVVM;
using uFrame.Kernel;
using uFrame.IOC;


public class BlueBirdAnimalController : BlueBirdAnimalControllerBase {
    
    public override void InitializeBlueBirdAnimal(BlueBirdAnimalViewModel viewModel) {
        base.InitializeBlueBirdAnimal(viewModel);
        // This is called when a BlueBirdAnimalViewModel is created
    }
}
