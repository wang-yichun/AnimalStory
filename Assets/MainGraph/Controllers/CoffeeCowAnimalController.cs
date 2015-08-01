using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using uFrame.Serialization;
using uFrame.MVVM;
using uFrame.Kernel;
using uFrame.IOC;


public class CoffeeCowAnimalController : CoffeeCowAnimalControllerBase {
    
    public override void InitializeCoffeeCowAnimal(CoffeeCowAnimalViewModel viewModel) {
        base.InitializeCoffeeCowAnimal(viewModel);
        // This is called when a CoffeeCowAnimalViewModel is created
    }
}
