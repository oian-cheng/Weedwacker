// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetSlotOp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from WidgetSlotOp.proto</summary>
  public static partial class WidgetSlotOpReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetSlotOp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetSlotOpReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJXaWRnZXRTbG90T3AucHJvdG8qRAoMV2lkZ2V0U2xvdE9wEhkKFVdJREdF",
            "VF9TTE9UX09QX0FUVEFDSBAAEhkKFVdJREdFVF9TTE9UX09QX0RFVEFDSBAB",
            "QhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Server.Proto.WidgetSlotOp), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum WidgetSlotOp {
    [pbr::OriginalName("WIDGET_SLOT_OP_ATTACH")] Attach = 0,
    [pbr::OriginalName("WIDGET_SLOT_OP_DETACH")] Detach = 1,
  }

  #endregion

}

#endregion Designer generated code
