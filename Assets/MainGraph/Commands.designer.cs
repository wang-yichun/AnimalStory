// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using uFrame.Kernel;
using uFrame.MVVM;
using uFrame.Serialization;


public partial class TappedCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class CreateAnimalCommand : uFrame.MVVM.ViewModelCommand {
    
    private AnimalProp _Argument;
    
    public AnimalProp Argument {
        get {
            return _Argument;
        }
        set {
            _Argument = value;
        }
    }
}

public partial class InitAllAnimalCommand : uFrame.MVVM.ViewModelCommand {
}
