// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MapMarkFromType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from MapMarkFromType.proto</summary>
  public static partial class MapMarkFromTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MapMarkFromType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapMarkFromTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNYXBNYXJrRnJvbVR5cGUucHJvdG8qbAoPTWFwTWFya0Zyb21UeXBlEhsK",
            "F01BUF9NQVJLX0ZST01fVFlQRV9OT05FEAASHgoaTUFQX01BUktfRlJPTV9U",
            "WVBFX01PTlNURVIQARIcChhNQVBfTUFSS19GUk9NX1RZUEVfUVVFU1QQAkIa",
            "qgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Server.Proto.MapMarkFromType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MapMarkFromType {
    [pbr::OriginalName("MAP_MARK_FROM_TYPE_NONE")] None = 0,
    [pbr::OriginalName("MAP_MARK_FROM_TYPE_MONSTER")] Monster = 1,
    [pbr::OriginalName("MAP_MARK_FROM_TYPE_QUEST")] Quest = 2,
  }

  #endregion

}

#endregion Designer generated code
