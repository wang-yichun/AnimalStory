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
using TouchScript.Gestures;

public class AnimalView : AnimalViewBase
{
    
	protected override void InitializeViewModel (uFrame.MVVM.ViewModel model)
	{
		base.InitializeViewModel (model);
		// NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
		// var vm = model as AnimalViewModel;
		// This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.

		AnimalViewModel viewModel = model as AnimalViewModel;
		viewModel.TargetProp = null;
	}
    
	public override void Bind ()
	{
		base.Bind ();
		// Use this.Animal to access the viewmodel.
		// Use this method to subscribe to the view-model.
		// Any designer bindings are created in the base implementation.
	}

	private void OnEnable ()
	{
		// subscribe to gesture's Tapped event
		GetComponent<TapGesture> ().Tapped += tappedHandler;
	}
	
	private void OnDisable ()
	{
		// don't forget to unsubscribe
		GetComponent<TapGesture> ().Tapped -= tappedHandler;
	}
	
	private void tappedHandler (object sender, EventArgs e)
	{
		this.ExecuteTapped ();
	}

	public override void AnimalStateChanged (Invert.StateMachine.State arg1)
	{
		base.AnimalStateChanged (arg1);
	}
	 
	public override void OnDestroying ()
	{
		base.OnDestroying ();
		gameObject.GetComponent<Animator> ().SetBool ("Disappear", true);
//		this.ExecuteDestroySelf();
	}

	public void DestroyingEnd ()
	{
		this.ExecuteDestroySelf ();
	}
	
	public override void OnDropping ()
	{
		base.OnDropping ();

		Hashtable para = new Hashtable ();
		para.Add ("name", "drop");
		para.Add ("position", InGameRootViewHelper.Loc2Pos (Animal.TargetProp.Loc));
		para.Add ("time", 0.4f);
		para.Add ("easetype", iTween.EaseType.easeInOutBack);
		para.Add ("oncomplete", "OnDropCompleted");
		para.Add ("oncompletetarget", this.gameObject);
		iTween.MoveTo (this.gameObject, para);

	}
	
	public void OnDropCompleted ()
	{
		iTween.StopByName (this.gameObject, "drop");

		Animal.Loc = Animal.TargetProp.Loc;
		Animal.AnimalType = Animal.TargetProp.AnimalType;

		Animal.TargetProp = null;

		this.ExecuteGotDropTarget ();
		
//		Debug.Log (Locator.Loc2Name (this.gameObject.GetComponent<AnimalView> ().Animal.Loc));
	}

	public override void OnIdle() {
		this.ExecuteGotIdle ();
	}
}
