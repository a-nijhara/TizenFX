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

public class Window : BaseHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Window(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Window_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Window obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Window() {
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
          NDalicPINVOKE.delete_Window(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }


  public Window (RectInteger windowPosition, string name, bool isTransparent) : this (NDalicPINVOKE.Window_New__SWIG_0(RectInteger.getCPtr(windowPosition), name, isTransparent), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public Window (RectInteger windowPosition, string name) : this (NDalicPINVOKE.Window_New__SWIG_1(RectInteger.getCPtr(windowPosition), name), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public Window (RectInteger windowPosition, string name, string className, bool isTransparent) : this (NDalicPINVOKE.Window_New__SWIG_2(RectInteger.getCPtr(windowPosition), name, className, isTransparent), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public Window (RectInteger windowPosition, string name, string className) : this (NDalicPINVOKE.Window_New__SWIG_3(RectInteger.getCPtr(windowPosition), name, className), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public Window(Window handle) : this(NDalicPINVOKE.new_Window__SWIG_1(Window.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Window Assign(Window rhs) {
    Window ret = new Window(NDalicPINVOKE.Window_Assign(swigCPtr, Window.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ShowIndicator(Window.IndicatorVisibleMode visibleMode) {
    NDalicPINVOKE.Window_ShowIndicator(swigCPtr, (int)visibleMode);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetIndicatorBgOpacity(Window.IndicatorBgOpacity opacity) {
    NDalicPINVOKE.Window_SetIndicatorBgOpacity(swigCPtr, (int)opacity);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RotateIndicator(Window.WindowOrientation orientation) {
    NDalicPINVOKE.Window_RotateIndicator(swigCPtr, (int)orientation);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetClass(string name, string klass) {
    NDalicPINVOKE.Window_SetClass(swigCPtr, name, klass);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Raise() {
    NDalicPINVOKE.Window_Raise(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Lower() {
    NDalicPINVOKE.Window_Lower(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Activate() {
    NDalicPINVOKE.Window_Activate(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddAvailableOrientation(Window.WindowOrientation orientation) {
    NDalicPINVOKE.Window_AddAvailableOrientation(swigCPtr, (int)orientation);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAvailableOrientation(Window.WindowOrientation orientation) {
    NDalicPINVOKE.Window_RemoveAvailableOrientation(swigCPtr, (int)orientation);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPreferredOrientation(Window.WindowOrientation orientation) {
    NDalicPINVOKE.Window_SetPreferredOrientation(swigCPtr, (int)orientation);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Window.WindowOrientation GetPreferredOrientation() {
    Window.WindowOrientation ret = (Window.WindowOrientation)NDalicPINVOKE.Window_GetPreferredOrientation(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DragAndDropDetector GetDragAndDropDetector() {
    DragAndDropDetector ret = new DragAndDropDetector(NDalicPINVOKE.Window_GetDragAndDropDetector(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Any GetNativeHandle() {
    Any ret = new Any(NDalicPINVOKE.Window_GetNativeHandle(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Dali__SignalT_void_fboolF_t IndicatorVisibilityChangedSignal() {
    SWIGTYPE_p_Dali__SignalT_void_fboolF_t ret = new SWIGTYPE_p_Dali__SignalT_void_fboolF_t(NDalicPINVOKE.Window_IndicatorVisibilityChangedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum WindowOrientation {
    PORTRAIT = 0,
    LANDSCAPE = 90,
    PORTRAIT_INVERSE = 180,
    LANDSCAPE_INVERSE = 270
  }

  public enum IndicatorBgOpacity {
    OPAQUE = 100,
    TRANSLUCENT = 50,
    TRANSPARENT = 0
  }

  public enum IndicatorVisibleMode {
    INVISIBLE = 0,
    VISIBLE = 1,
    AUTO = 2
  }

}

}
