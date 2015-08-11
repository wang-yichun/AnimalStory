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

	public override void SameCountChanged (Int32 arg1)
	{
		gameObject.transform.FindChild ("Text").GetComponent<TextMesh> ().text = arg1.ToString ();
	}

//    public override void AnimalStateChanged(Invert.StateMachine.State arg1) {
//		Debug.Log ("AnimalStateChanged");
//		if (arg1 is Destroying) {
//			this.ExecuteDestroySelf();
//		}
//    }

//	public override void OnDestroying ()
//	{
//		base.OnDestroying ();
//		this.ExecuteDestroySelf ();
//	}

//    public override void AnimalStateChanged(Invert.StateMachine.State State) {
//    }

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
}
