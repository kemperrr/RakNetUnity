//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace RakNet {

public class RakNetListRakString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetListRakString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RakNetListRakString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetListRakString() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.CSharp_RakNet_delete_RakNetListRakString(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

    public RakString this[int index]  
    {  
        get   
        {
            return Get((uint)index); // use indexto retrieve and return another value.    
        }  
        set   
        {
            Replace(value, value, (uint)index, "Not used", 0);// use index and value to set the value somewhere.   
        }  
    } 

  public RakNetListRakString() : this(RakNetPINVOKE.CSharp_RakNet_new_RakNetListRakString__SWIG_0(), true) {
  }

  public RakNetListRakString(RakNetListRakString original_copy) : this(RakNetPINVOKE.CSharp_RakNet_new_RakNetListRakString__SWIG_1(RakNetListRakString.getCPtr(original_copy)), true) {
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetListRakString CopyData(RakNetListRakString original_copy) {
    RakNetListRakString ret = new RakNetListRakString(RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_CopyData(swigCPtr, RakNetListRakString.getCPtr(original_copy)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RakString Get(uint position) {
    RakString ret = new RakString(RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Get(swigCPtr, position), false);
    return ret;
  }

  public void Push(RakString input, string file, uint line) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Push(swigCPtr, RakString.getCPtr(input), file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakString Pop() {
    RakString ret = new RakString(RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Pop(swigCPtr), false);
    return ret;
  }

  public void Insert(RakString input, uint position, string file, uint line) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Insert__SWIG_0(swigCPtr, RakString.getCPtr(input), position, file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(RakString input, string file, uint line) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Insert__SWIG_1(swigCPtr, RakString.getCPtr(input), file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(RakString input, RakString filler, uint position, string file, uint line) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Replace__SWIG_0(swigCPtr, RakString.getCPtr(input), RakString.getCPtr(filler), position, file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(RakString input) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Replace__SWIG_1(swigCPtr, RakString.getCPtr(input));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAtIndex(uint position) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_RemoveAtIndex(swigCPtr, position);
  }

  public void RemoveAtIndexFast(uint position) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_RemoveAtIndexFast(swigCPtr, position);
  }

  public void RemoveFromEnd(uint num) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_RemoveFromEnd__SWIG_0(swigCPtr, num);
  }

  public void RemoveFromEnd() {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_RemoveFromEnd__SWIG_1(swigCPtr);
  }

  public uint GetIndexOf(RakString input) {
    uint ret = RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_GetIndexOf(swigCPtr, RakString.getCPtr(input));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint Size() {
    uint ret = RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Size(swigCPtr);
    return ret;
  }

  public void Clear(bool doNotDeallocateSmallBlocks, string file, uint line) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Clear(swigCPtr, doNotDeallocateSmallBlocks, file, line);
  }

  public void Preallocate(uint countNeeded, string file, uint line) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Preallocate(swigCPtr, countNeeded, file, line);
  }

  public void Compress(string file, uint line) {
    RakNetPINVOKE.CSharp_RakNet_RakNetListRakString_Compress(swigCPtr, file, line);
  }

}

}
