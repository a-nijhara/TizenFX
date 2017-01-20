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

public class DefaultRuler : Ruler {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DefaultRuler(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.DefaultRuler_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DefaultRuler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DefaultRuler() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_DefaultRuler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public DefaultRuler() : this(NDalicPINVOKE.new_DefaultRuler(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public override float Snap(float x, float bias) {
    float ret = NDalicPINVOKE.DefaultRuler_Snap(swigCPtr, x, bias);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float GetPositionFromPage(uint page, out uint volume, bool wrap) {
    float ret = NDalicPINVOKE.DefaultRuler_GetPositionFromPage(swigCPtr, page, out volume, wrap);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint GetPageFromPosition(float position, bool wrap) {
    uint ret = NDalicPINVOKE.DefaultRuler_GetPageFromPosition(swigCPtr, position, wrap);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint GetTotalPages() {
    uint ret = NDalicPINVOKE.DefaultRuler_GetTotalPages(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
