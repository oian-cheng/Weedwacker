// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LoginRewardConfigType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LoginRewardConfigType.proto</summary>
  public static partial class LoginRewardConfigTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for LoginRewardConfigType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoginRewardConfigTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtMb2dpblJld2FyZENvbmZpZ1R5cGUucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8qZAoVTG9naW5SZXdhcmRDb25maWdUeXBlEicK",
            "I0xPR0lOX1JFV0FSRF9DT05GSUdfVFlQRV9JTU1FRElEQVRFEAASIgoeTE9H",
            "SU5fUkVXQVJEX0NPTkZJR19UWVBFX0ZJUlNUEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.LoginRewardConfigType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum LoginRewardConfigType {
    [pbr::OriginalName("LOGIN_REWARD_CONFIG_TYPE_IMMEDIDATE")] Immedidate = 0,
    [pbr::OriginalName("LOGIN_REWARD_CONFIG_TYPE_FIRST")] First = 1,
  }

  #endregion

}

#endregion Designer generated code
