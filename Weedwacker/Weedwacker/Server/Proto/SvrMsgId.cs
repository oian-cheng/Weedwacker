// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SvrMsgId.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from SvrMsgId.proto</summary>
  public static partial class SvrMsgIdReflection {

    #region Descriptor
    /// <summary>File descriptor for SvrMsgId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SvrMsgIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5TdnJNc2dJZC5wcm90byqUAgoIU3ZyTXNnSWQSFgoSU1ZSX01TR19JRF9V",
            "TktOT1dOEAASJgoiU1ZSX01TR19JRF9CTE9DS19SRUZSRVNIX0NPVU5URE9X",
            "ThABEiYKIlNWUl9NU0dfSURfQVZBVEFSX1JFVklWRV9CWV9TVEFUVUUQAhIo",
            "CiRTVlJfTVNHX0lEX0RBSUxZX1RBU0tfUkVXQVJEX01BWF9OVU0QAxIkCiBT",
            "VlJfTVNHX0lEX1JPVVRJTkVfVFlQRV9OT1RfT1BFThAEEioKJlNWUl9NU0df",
            "SURfUk9VVElORV9UWVBFX1JFV0FSRF9NQVhfTlVNEAUSJAogU1ZSX01TR19J",
            "RF9NRUNIQU5JQ1VTX0NPSU5fTElNSVQQBkIaqgIXV2VlZHdhY2tlci5TZXJ2",
            "ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Server.Proto.SvrMsgId), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SvrMsgId {
    [pbr::OriginalName("SVR_MSG_ID_UNKNOWN")] Unknown = 0,
    [pbr::OriginalName("SVR_MSG_ID_BLOCK_REFRESH_COUNTDOWN")] BlockRefreshCountdown = 1,
    [pbr::OriginalName("SVR_MSG_ID_AVATAR_REVIVE_BY_STATUE")] AvatarReviveByStatue = 2,
    [pbr::OriginalName("SVR_MSG_ID_DAILY_TASK_REWARD_MAX_NUM")] DailyTaskRewardMaxNum = 3,
    [pbr::OriginalName("SVR_MSG_ID_ROUTINE_TYPE_NOT_OPEN")] RoutineTypeNotOpen = 4,
    [pbr::OriginalName("SVR_MSG_ID_ROUTINE_TYPE_REWARD_MAX_NUM")] RoutineTypeRewardMaxNum = 5,
    [pbr::OriginalName("SVR_MSG_ID_MECHANICUS_COIN_LIMIT")] MechanicusCoinLimit = 6,
  }

  #endregion

}

#endregion Designer generated code
