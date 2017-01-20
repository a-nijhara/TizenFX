/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NUI {

using System;
using System.Runtime.InteropServices;


public class PanGestureDetector : GestureDetector {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PanGestureDetector(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.PanGestureDetector_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PanGestureDetector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PanGestureDetector() {
    DisposeQueue.Instance.Add(this);
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_PanGestureDetector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }




public class DetectedEventArgs : EventArgs
{
   private Actor _actor;
   private PanGesture _panGesture;

   public Actor Actor
   {
      get
      {
         return _actor;
      }
      set
      {
         _actor = value;
      }
   }

   public PanGesture PanGesture
   {
      get
      {
         return _panGesture;
      }
      set
      {
         _panGesture = value;
      }
   }
}

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate void DetectedCallbackDelegate(IntPtr actor, IntPtr panGesture);
  private DaliEventHandler<object,DetectedEventArgs> _panGestureEventHandler;
  private DetectedCallbackDelegate _panGestureCallbackDelegate;


  public event DaliEventHandler<object,DetectedEventArgs> Detected
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_panGestureEventHandler == null)
           {
              _panGestureEventHandler += value;

              _panGestureCallbackDelegate = new DetectedCallbackDelegate(OnPanGestureDetected);
              this.DetectedSignal().Connect(_panGestureCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_panGestureEventHandler != null)
           {
              this.DetectedSignal().Disconnect(_panGestureCallbackDelegate);
           }

           _panGestureEventHandler -= value;
        }
     }
  }

 private void OnPanGestureDetected(IntPtr actor, IntPtr panGesture)
  {
   DetectedEventArgs e = new DetectedEventArgs();

   // Populate all members of "e" (PanGestureEventArgs) with real data
   e.Actor = Actor.GetActorFromPtr(actor);
   e.PanGesture = NUI.PanGesture.GetPanGestureFromPtr(panGesture);

   if (_panGestureEventHandler != null)
   {
      //here we send all data to user event handlers
      _panGestureEventHandler(this, e);
   }

  }


public static PanGestureDetector GetPanGestureDetectorFromPtr(global::System.IntPtr cPtr) {
    PanGestureDetector ret = new PanGestureDetector(cPtr, false);
   if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }


  public class Property : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Property(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Property() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_PanGestureDetector_Property(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property() : this(NDalicPINVOKE.new_PanGestureDetector_Property(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int SCREEN_POSITION = NDalicPINVOKE.PanGestureDetector_Property_SCREEN_POSITION_get();
    public static readonly int SCREEN_DISPLACEMENT = NDalicPINVOKE.PanGestureDetector_Property_SCREEN_DISPLACEMENT_get();
    public static readonly int SCREEN_VELOCITY = NDalicPINVOKE.PanGestureDetector_Property_SCREEN_VELOCITY_get();
    public static readonly int LOCAL_POSITION = NDalicPINVOKE.PanGestureDetector_Property_LOCAL_POSITION_get();
    public static readonly int LOCAL_DISPLACEMENT = NDalicPINVOKE.PanGestureDetector_Property_LOCAL_DISPLACEMENT_get();
    public static readonly int LOCAL_VELOCITY = NDalicPINVOKE.PanGestureDetector_Property_LOCAL_VELOCITY_get();
    public static readonly int PANNING = NDalicPINVOKE.PanGestureDetector_Property_PANNING_get();
  
  }

  public static Radian DIRECTION_LEFT {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.PanGestureDetector_DIRECTION_LEFT_get();
      Radian ret = (cPtr == global::System.IntPtr.Zero) ? null : new Radian(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Radian DIRECTION_RIGHT {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.PanGestureDetector_DIRECTION_RIGHT_get();
      Radian ret = (cPtr == global::System.IntPtr.Zero) ? null : new Radian(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Radian DIRECTION_UP {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.PanGestureDetector_DIRECTION_UP_get();
      Radian ret = (cPtr == global::System.IntPtr.Zero) ? null : new Radian(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Radian DIRECTION_DOWN {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.PanGestureDetector_DIRECTION_DOWN_get();
      Radian ret = (cPtr == global::System.IntPtr.Zero) ? null : new Radian(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Radian DIRECTION_HORIZONTAL {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.PanGestureDetector_DIRECTION_HORIZONTAL_get();
      Radian ret = (cPtr == global::System.IntPtr.Zero) ? null : new Radian(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Radian DIRECTION_VERTICAL {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.PanGestureDetector_DIRECTION_VERTICAL_get();
      Radian ret = (cPtr == global::System.IntPtr.Zero) ? null : new Radian(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Radian DEFAULT_THRESHOLD {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.PanGestureDetector_DEFAULT_THRESHOLD_get();
      Radian ret = (cPtr == global::System.IntPtr.Zero) ? null : new Radian(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PanGestureDetector () : this (NDalicPINVOKE.PanGestureDetector_New(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public new static PanGestureDetector DownCast(BaseHandle handle) {
    PanGestureDetector ret = new PanGestureDetector(NDalicPINVOKE.PanGestureDetector_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PanGestureDetector(PanGestureDetector handle) : this(NDalicPINVOKE.new_PanGestureDetector__SWIG_1(PanGestureDetector.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public PanGestureDetector Assign(PanGestureDetector rhs) {
    PanGestureDetector ret = new PanGestureDetector(NDalicPINVOKE.PanGestureDetector_Assign(swigCPtr, PanGestureDetector.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMinimumTouchesRequired(uint minimum) {
    NDalicPINVOKE.PanGestureDetector_SetMinimumTouchesRequired(swigCPtr, minimum);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaximumTouchesRequired(uint maximum) {
    NDalicPINVOKE.PanGestureDetector_SetMaximumTouchesRequired(swigCPtr, maximum);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetMinimumTouchesRequired() {
    uint ret = NDalicPINVOKE.PanGestureDetector_GetMinimumTouchesRequired(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetMaximumTouchesRequired() {
    uint ret = NDalicPINVOKE.PanGestureDetector_GetMaximumTouchesRequired(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddAngle(Radian angle, Radian threshold) {
    NDalicPINVOKE.PanGestureDetector_AddAngle__SWIG_0(swigCPtr, Radian.getCPtr(angle), Radian.getCPtr(threshold));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddAngle(Radian angle) {
    NDalicPINVOKE.PanGestureDetector_AddAngle__SWIG_1(swigCPtr, Radian.getCPtr(angle));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddDirection(Radian direction, Radian threshold) {
    NDalicPINVOKE.PanGestureDetector_AddDirection__SWIG_0(swigCPtr, Radian.getCPtr(direction), Radian.getCPtr(threshold));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddDirection(Radian direction) {
    NDalicPINVOKE.PanGestureDetector_AddDirection__SWIG_1(swigCPtr, Radian.getCPtr(direction));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetAngleCount() {
    uint ret = NDalicPINVOKE.PanGestureDetector_GetAngleCount(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AngleThresholdPair GetAngle(uint index) {
    AngleThresholdPair ret = new AngleThresholdPair(NDalicPINVOKE.PanGestureDetector_GetAngle(swigCPtr, index), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ClearAngles() {
    NDalicPINVOKE.PanGestureDetector_ClearAngles(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAngle(Radian angle) {
    NDalicPINVOKE.PanGestureDetector_RemoveAngle(swigCPtr, Radian.getCPtr(angle));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveDirection(Radian direction) {
    NDalicPINVOKE.PanGestureDetector_RemoveDirection(swigCPtr, Radian.getCPtr(direction));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public PanGestureDetectedSignal DetectedSignal() {
    PanGestureDetectedSignal ret = new PanGestureDetectedSignal(NDalicPINVOKE.PanGestureDetector_DetectedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void SetPanGestureProperties(PanGesture pan) {
    NDalicPINVOKE.PanGestureDetector_SetPanGestureProperties(PanGesture.getCPtr(pan));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector2 ScreenPosition
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( PanGestureDetector.Property.SCREEN_POSITION).Get(  temp );
      return temp;
    }
}  public Vector2 ScreenDisplacement
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( PanGestureDetector.Property.SCREEN_DISPLACEMENT).Get(  temp );
      return temp;
    }
}  public Vector2 ScreenVelocity
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( PanGestureDetector.Property.SCREEN_VELOCITY).Get(  temp );
      return temp;
    }
}  public Vector2 LocalPosition
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( PanGestureDetector.Property.LOCAL_POSITION).Get(  temp );
      return temp;
    }
}  public Vector2 LocalDisplacement
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( PanGestureDetector.Property.LOCAL_DISPLACEMENT).Get(  temp );
      return temp;
    }
}  public Vector2 LocalVelocity
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( PanGestureDetector.Property.LOCAL_VELOCITY).Get(  temp );
      return temp;
    }
}  public bool Panning
  {
    get
    {
      bool temp = false;
      GetProperty( PanGestureDetector.Property.PANNING).Get( ref temp );
      return temp;
    }
}
}

}
