// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassUnlockStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from BattlePassUnlockStatus.proto</summary>
  public static partial class BattlePassUnlockStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassUnlockStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassUnlockStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxCYXR0bGVQYXNzVW5sb2NrU3RhdHVzLnByb3RvKocBChZCYXR0bGVQYXNz",
            "VW5sb2NrU3RhdHVzEiUKIUJBVFRMRV9QQVNTX1VOTE9DS19TVEFUVVNfSU5W",
            "QUxJRBAAEiIKHkJBVFRMRV9QQVNTX1VOTE9DS19TVEFUVVNfRlJFRRABEiIK",
            "HkJBVFRMRV9QQVNTX1VOTE9DS19TVEFUVVNfUEFJRBACQhqqAhdXZWVkd2Fj",
            "a2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Server.Proto.BattlePassUnlockStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum BattlePassUnlockStatus {
    [pbr::OriginalName("BATTLE_PASS_UNLOCK_STATUS_INVALID")] Invalid = 0,
    [pbr::OriginalName("BATTLE_PASS_UNLOCK_STATUS_FREE")] Free = 1,
    [pbr::OriginalName("BATTLE_PASS_UNLOCK_STATUS_PAID")] Paid = 2,
  }

  #endregion

}

#endregion Designer generated code
