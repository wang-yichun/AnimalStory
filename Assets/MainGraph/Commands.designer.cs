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
using UnityEngine;


public partial class TappedCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class DestroySelfCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class StartDropCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class GotDropTargetCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class GotIdleCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class DebugCommandCommand : uFrame.MVVM.ViewModelCommand {
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

public partial class RemoveAnimalCommand : uFrame.MVVM.ViewModelCommand {
    
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

public partial class CreateAndDropCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class InitAllAnimalCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class TestCommandCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class RefreshSameCountCommand : uFrame.MVVM.ViewModelCommand {
    
    private AnimalViewModel _Argument;
    
    public AnimalViewModel Argument {
        get {
            return _Argument;
        }
        set {
            _Argument = value;
        }
    }
}

public partial class CalcAnimalsCountCommand : uFrame.MVVM.ViewModelCommand {
}

public partial class AnimalDropToCommand : ViewModelCommand {
    
    private AnimalViewModel _Animal;
    
    private AnimalProp _Target;
    
    public AnimalViewModel Animal {
        get {
            return _Animal;
        }
        set {
            _Animal = value;
        }
    }
    
    public AnimalProp Target {
        get {
            return _Target;
        }
        set {
            _Target = value;
        }
    }
}
