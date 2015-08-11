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
using uFrame.MVVM.Bindings;
using uFrame.Serialization;


public class LocBase : object {
    
    private Int32 _x;
    
    private Int32 _y;
    
    public Int32 x {
        get {
            return _x;
        }
        set {
            _x = value;
        }
    }
    
    public Int32 y {
        get {
            return _y;
        }
        set {
            _y = value;
        }
    }
}

public class CheckSameCountCommandBase : object {
    
    private AnimalViewModel _CenterAnimal;
    
    public AnimalViewModel CenterAnimal {
        get {
            return _CenterAnimal;
        }
        set {
            _CenterAnimal = value;
        }
    }
}

public class InitMapContainerCommandBase : object {
    
    private InGameRootViewModel _InGameRootViewModel;
    
    public InGameRootViewModel InGameRootViewModel {
        get {
            return _InGameRootViewModel;
        }
        set {
            _InGameRootViewModel = value;
        }
    }
}

public class AnimalPropBase : object {
    
    private AnimalType _AnimalType;
    
    private Loc _Loc;
    
    public AnimalType AnimalType {
        get {
            return _AnimalType;
        }
        set {
            _AnimalType = value;
        }
    }
    
    public Loc Loc {
        get {
            return _Loc;
        }
        set {
            _Loc = value;
        }
    }
}

public class MapInfoBase : object {
    
    private Int32 _xmin;
    
    private Int32 _xmax;
    
    private Int32 _ymin;
    
    private Int32 _ymax;
    
    private Int32 _TotalAnimalCount;
    
    public Int32 xmin {
        get {
            return _xmin;
        }
        set {
            _xmin = value;
        }
    }
    
    public Int32 xmax {
        get {
            return _xmax;
        }
        set {
            _xmax = value;
        }
    }
    
    public Int32 ymin {
        get {
            return _ymin;
        }
        set {
            _ymin = value;
        }
    }
    
    public Int32 ymax {
        get {
            return _ymax;
        }
        set {
            _ymax = value;
        }
    }
    
    public Int32 TotalAnimalCount {
        get {
            return _TotalAnimalCount;
        }
        set {
            _TotalAnimalCount = value;
        }
    }
}

public class RuleInfoBase : object {
    
    private Int32 _DestroyLimitCount;
    
    public Int32 DestroyLimitCount {
        get {
            return _DestroyLimitCount;
        }
        set {
            _DestroyLimitCount = value;
        }
    }
}
