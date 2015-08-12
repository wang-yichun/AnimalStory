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
using uFrame.MVVM.Services;
using uFrame.MVVM.Bindings;
using uFrame.Serialization;
using UniRx;
using UnityEngine;


public class BlueBirdAnimalViewBase : AnimalView {
    
    public override string DefaultIdentifier {
        get {
            return base.DefaultIdentifier;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(BlueBirdAnimalViewModel);
        }
    }
    
    public BlueBirdAnimalViewModel BlueBirdAnimal {
        get {
            return (BlueBirdAnimalViewModel)ViewModelObject;
        }
    }
    
    protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as BlueBirdAnimalViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
    }
    
    public override void Bind() {
        base.Bind();
        // Use this.BlueBirdAnimal to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
    }
}

public class CoffeeCowAnimalViewBase : AnimalView {
    
    public override string DefaultIdentifier {
        get {
            return base.DefaultIdentifier;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(CoffeeCowAnimalViewModel);
        }
    }
    
    public CoffeeCowAnimalViewModel CoffeeCowAnimal {
        get {
            return (CoffeeCowAnimalViewModel)ViewModelObject;
        }
    }
    
    protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as CoffeeCowAnimalViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
    }
    
    public override void Bind() {
        base.Bind();
        // Use this.CoffeeCowAnimal to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
    }
}

public class GreenFrogAnimalViewBase : AnimalView {
    
    public override string DefaultIdentifier {
        get {
            return base.DefaultIdentifier;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(GreenFrogAnimalViewModel);
        }
    }
    
    public GreenFrogAnimalViewModel GreenFrogAnimal {
        get {
            return (GreenFrogAnimalViewModel)ViewModelObject;
        }
    }
    
    protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as GreenFrogAnimalViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
    }
    
    public override void Bind() {
        base.Bind();
        // Use this.GreenFrogAnimal to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
    }
}

public class InGameRootViewBase : uFrame.MVVM.ViewBase {
    
    [UnityEngine.SerializeField()]
    private InGameRootViewHelper _InGameRootViewHelper;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public MapInfo _MapInfo;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public RuleInfo _RuleInfo;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _IdleAnimalsCount;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _NullAnimalsCount;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Boolean _IsDropping;
    
    [UFToggleGroup("InGameState")]
    [UnityEngine.HideInInspector()]
    public bool _BindInGameState = true;
    
    [UFGroup("InGameState")]
    [UnityEngine.SerializeField()]
    [UnityEngine.HideInInspector()]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute("_InGameStateonlyWhenChanged")]
    protected bool _InGameStateOnlyWhenChanged;
    
    [UFToggleGroup("AnimalCollections")]
    [UnityEngine.HideInInspector()]
    public bool _BindAnimalCollections = true;
    
    [UFGroup("AnimalCollections")]
    [UnityEngine.SerializeField()]
    [UnityEngine.HideInInspector()]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute("_AnimalCollectionsparent")]
    protected UnityEngine.Transform _AnimalCollectionsParent;
    
    [UFGroup("AnimalCollections")]
    [UnityEngine.SerializeField()]
    [UnityEngine.HideInInspector()]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute("_AnimalCollectionsviewFirst")]
    protected bool _AnimalCollectionsViewFirst;
    
    [UFToggleGroup("IdleAnimalsCount")]
    [UnityEngine.HideInInspector()]
    public bool _BindIdleAnimalsCount = true;
    
    [UFGroup("IdleAnimalsCount")]
    [UnityEngine.SerializeField()]
    [UnityEngine.HideInInspector()]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute("_IdleAnimalsCountonlyWhenChanged")]
    protected bool _IdleAnimalsCountOnlyWhenChanged;
    
    [UFToggleGroup("ShouldCreateAndDrop")]
    [UnityEngine.HideInInspector()]
    public bool _BindShouldCreateAndDrop = true;
    
    [UFGroup("ShouldCreateAndDrop")]
    [UnityEngine.SerializeField()]
    [UnityEngine.HideInInspector()]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute("_ShouldCreateAndDroponlyWhenChanged")]
    protected bool _ShouldCreateAndDropOnlyWhenChanged;
    
    public override string DefaultIdentifier {
        get {
            return "InGameRoot";
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(InGameRootViewModel);
        }
    }
    
    public InGameRootViewModel InGameRoot {
        get {
            return (InGameRootViewModel)ViewModelObject;
        }
    }
    
    public virtual InGameRootViewHelper InGameRootViewHelper {
        get {
            return _InGameRootViewHelper ?? (_InGameRootViewHelper = this.gameObject.EnsureComponent<InGameRootViewHelper>());
        }
    }
    
    protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as InGameRootViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        var ingamerootview = ((InGameRootViewModel)model);
        ingamerootview.MapInfo = this._MapInfo;
        ingamerootview.RuleInfo = this._RuleInfo;
        ingamerootview.IdleAnimalsCount = this._IdleAnimalsCount;
        ingamerootview.NullAnimalsCount = this._NullAnimalsCount;
        ingamerootview.IsDropping = this._IsDropping;
    }
    
    public override void Bind() {
        base.Bind();
        // Use this.InGameRoot to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
        if (_BindInGameState) {
            this.BindStateProperty(this.InGameRoot.InGameStateProperty, this.InGameStateChanged, _InGameStateOnlyWhenChanged);
        }
        if (_BindAnimalCollections) {
            this.BindToViewCollection(this.InGameRoot.AnimalCollections, this.AnimalCollectionsCreateView, this.AnimalCollectionsAdded, this.AnimalCollectionsRemoved, _AnimalCollectionsParent, _AnimalCollectionsViewFirst);
        }
        if (_BindIdleAnimalsCount) {
            this.BindProperty(this.InGameRoot.IdleAnimalsCountProperty, this.IdleAnimalsCountChanged, _IdleAnimalsCountOnlyWhenChanged);
        }
        if (_BindShouldCreateAndDrop) {
            this.BindProperty(this.InGameRoot.ShouldCreateAndDropProperty, this.ShouldCreateAndDropChanged, _ShouldCreateAndDropOnlyWhenChanged);
        }
    }
    
    public virtual void InGameStateChanged(Invert.StateMachine.State arg1) {
        if (arg1 is Ready) {
            this.OnReady();
        }
        if (arg1 is Ongoing) {
            this.OnOngoing();
        }
        if (arg1 is Stop) {
            this.OnStop();
        }
    }
    
    public virtual void OnReady() {
    }
    
    public virtual void OnOngoing() {
    }
    
    public virtual void OnStop() {
    }
    
    public virtual uFrame.MVVM.ViewBase AnimalCollectionsCreateView(uFrame.MVVM.ViewModel viewModel) {
        return InstantiateView(viewModel);
    }
    
    public virtual void AnimalCollectionsAdded(uFrame.MVVM.ViewBase view) {
    }
    
    public virtual void AnimalCollectionsRemoved(uFrame.MVVM.ViewBase view) {
    }
    
    public virtual void IdleAnimalsCountChanged(Int32 arg1) {
    }
    
    public virtual void ShouldCreateAndDropChanged(Boolean arg1) {
    }
    
    public virtual void ExecuteCreateAndDrop() {
        InGameRoot.CreateAndDrop.OnNext(new CreateAndDropCommand() { Sender = InGameRoot });
    }
    
    public virtual void ExecuteInitAllAnimal() {
        InGameRoot.InitAllAnimal.OnNext(new InitAllAnimalCommand() { Sender = InGameRoot });
    }
    
    public virtual void ExecuteCalcAnimalsCount() {
        InGameRoot.CalcAnimalsCount.OnNext(new CalcAnimalsCountCommand() { Sender = InGameRoot });
    }
    
    public virtual void ExecuteCreateAnimal(CreateAnimalCommand command) {
        command.Sender = InGameRoot;
        InGameRoot.CreateAnimal.OnNext(command);
    }
    
    public virtual void ExecuteRemoveAnimal(RemoveAnimalCommand command) {
        command.Sender = InGameRoot;
        InGameRoot.RemoveAnimal.OnNext(command);
    }
    
    public virtual void ExecuteCreateAndDrop(CreateAndDropCommand command) {
        command.Sender = InGameRoot;
        InGameRoot.CreateAndDrop.OnNext(command);
    }
    
    public virtual void ExecuteInitAllAnimal(InitAllAnimalCommand command) {
        command.Sender = InGameRoot;
        InGameRoot.InitAllAnimal.OnNext(command);
    }
    
    public virtual void ExecuteRefreshSameCount(RefreshSameCountCommand command) {
        command.Sender = InGameRoot;
        InGameRoot.RefreshSameCount.OnNext(command);
    }
    
    public virtual void ExecuteCalcAnimalsCount(CalcAnimalsCountCommand command) {
        command.Sender = InGameRoot;
        InGameRoot.CalcAnimalsCount.OnNext(command);
    }
    
    public virtual void ExecuteCreateAnimal(AnimalProp arg) {
        InGameRoot.CreateAnimal.OnNext(new CreateAnimalCommand() { Sender = InGameRoot, Argument = arg });
    }
    
    public virtual void ExecuteRemoveAnimal(AnimalProp arg) {
        InGameRoot.RemoveAnimal.OnNext(new RemoveAnimalCommand() { Sender = InGameRoot, Argument = arg });
    }
    
    public virtual void ExecuteRefreshSameCount(AnimalViewModel arg) {
        InGameRoot.RefreshSameCount.OnNext(new RefreshSameCountCommand() { Sender = InGameRoot, Argument = arg });
    }
}

public class AnimalViewBase : uFrame.MVVM.ViewBase {
    
    [UnityEngine.SerializeField()]
    private InGameRootViewHelper _InGameRootViewHelper;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public AnimalType _AnimalType;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Int32 _SameCount;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Loc _Loc;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public Boolean _needDestroy;
    
    [UnityEngine.SerializeField()]
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public AnimalProp _TargetProp;
    
    [UFToggleGroup("AnimalState")]
    [UnityEngine.HideInInspector()]
    public bool _BindAnimalState = true;
    
    [UFGroup("AnimalState")]
    [UnityEngine.SerializeField()]
    [UnityEngine.HideInInspector()]
    [UnityEngine.Serialization.FormerlySerializedAsAttribute("_AnimalStateonlyWhenChanged")]
    protected bool _AnimalStateOnlyWhenChanged;
    
    public override string DefaultIdentifier {
        get {
            return base.DefaultIdentifier;
        }
    }
    
    public override System.Type ViewModelType {
        get {
            return typeof(AnimalViewModel);
        }
    }
    
    public AnimalViewModel Animal {
        get {
            return (AnimalViewModel)ViewModelObject;
        }
    }
    
    public virtual InGameRootViewHelper InGameRootViewHelper {
        get {
            return _InGameRootViewHelper ?? (_InGameRootViewHelper = this.gameObject.EnsureComponent<InGameRootViewHelper>());
        }
    }
    
    protected override void InitializeViewModel(uFrame.MVVM.ViewModel model) {
        base.InitializeViewModel(model);
        // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
        // var vm = model as AnimalViewModel;
        // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        var animalview = ((AnimalViewModel)model);
        animalview.AnimalType = this._AnimalType;
        animalview.SameCount = this._SameCount;
        animalview.Loc = this._Loc;
        animalview.needDestroy = this._needDestroy;
        animalview.TargetProp = this._TargetProp;
    }
    
    public override void Bind() {
        base.Bind();
        // Use this.Animal to access the viewmodel.
        // Use this method to subscribe to the view-model.
        // Any designer bindings are created in the base implementation.
        if (_BindAnimalState) {
            this.BindStateProperty(this.Animal.AnimalStateProperty, this.AnimalStateChanged, _AnimalStateOnlyWhenChanged);
        }
    }
    
    public virtual void AnimalStateChanged(Invert.StateMachine.State arg1) {
        if (arg1 is Idle) {
            this.OnIdle();
        }
        if (arg1 is Destroying) {
            this.OnDestroying();
        }
        if (arg1 is Dropping) {
            this.OnDropping();
        }
    }
    
    public virtual void OnIdle() {
    }
    
    public virtual void OnDestroying() {
    }
    
    public virtual void OnDropping() {
    }
    
    public virtual void ExecuteTapped() {
        Animal.Tapped.OnNext(new TappedCommand() { Sender = Animal });
    }
    
    public virtual void ExecuteDestroySelf() {
        Animal.DestroySelf.OnNext(new DestroySelfCommand() { Sender = Animal });
    }
    
    public virtual void ExecuteStartDrop() {
        Animal.StartDrop.OnNext(new StartDropCommand() { Sender = Animal });
    }
    
    public virtual void ExecuteGotDropTarget() {
        Animal.GotDropTarget.OnNext(new GotDropTargetCommand() { Sender = Animal });
    }
    
    public virtual void ExecuteGotIdle() {
        Animal.GotIdle.OnNext(new GotIdleCommand() { Sender = Animal });
    }
    
    public virtual void ExecuteDebugCommand() {
        Animal.DebugCommand.OnNext(new DebugCommandCommand() { Sender = Animal });
    }
    
    public virtual void ExecuteTapped(TappedCommand command) {
        command.Sender = Animal;
        Animal.Tapped.OnNext(command);
    }
    
    public virtual void ExecuteDestroySelf(DestroySelfCommand command) {
        command.Sender = Animal;
        Animal.DestroySelf.OnNext(command);
    }
    
    public virtual void ExecuteStartDrop(StartDropCommand command) {
        command.Sender = Animal;
        Animal.StartDrop.OnNext(command);
    }
    
    public virtual void ExecuteGotDropTarget(GotDropTargetCommand command) {
        command.Sender = Animal;
        Animal.GotDropTarget.OnNext(command);
    }
    
    public virtual void ExecuteGotIdle(GotIdleCommand command) {
        command.Sender = Animal;
        Animal.GotIdle.OnNext(command);
    }
    
    public virtual void ExecuteDebugCommand(DebugCommandCommand command) {
        command.Sender = Animal;
        Animal.DebugCommand.OnNext(command);
    }
}
