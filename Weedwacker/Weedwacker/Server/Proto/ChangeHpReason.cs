// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeHpReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ChangeHpReason.proto</summary>
  public static partial class ChangeHpReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeHpReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeHpReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDaGFuZ2VIcFJlYXNvbi5wcm90byqsCAoOQ2hhbmdlSHBSZWFzb24SGQoV",
            "Q0hBTkdFX0hQX1JFQVNPTl9OT05FEAASHwobQ0hBTkdFX0hQX1JFQVNPTl9T",
            "VUJfQVZBVEFSEAESIAocQ0hBTkdFX0hQX1JFQVNPTl9TVUJfTU9OU1RFUhAC",
            "Eh0KGUNIQU5HRV9IUF9SRUFTT05fU1VCX0dFQVIQAxIeChpDSEFOR0VfSFBf",
            "UkVBU09OX1NVQl9FTlZJUhAEEh0KGUNIQU5HRV9IUF9SRUFTT05fU1VCX0ZB",
            "TEwQBRIeChpDSEFOR0VfSFBfUkVBU09OX1NVQl9EUkFXThAGEh4KGkNIQU5H",
            "RV9IUF9SRUFTT05fU1VCX0FCWVNTEAcSIAocQ0hBTkdFX0hQX1JFQVNPTl9T",
            "VUJfQUJJTElUWRAIEh8KG0NIQU5HRV9IUF9SRUFTT05fU1VCX1NVTU1PThAJ",
            "Eh8KG0NIQU5HRV9IUF9SRUFTT05fU1VCX1NDUklQVBAKEhsKF0NIQU5HRV9I",
            "UF9SRUFTT05fU1VCX0dNEAsSIgoeQ0hBTkdFX0hQX1JFQVNPTl9TVUJfS0lM",
            "TF9TRUxGEAwSJQohQ0hBTkdFX0hQX1JFQVNPTl9TVUJfQ0xJTUFURV9DT0xE",
            "EA0SKAokQ0hBTkdFX0hQX1JFQVNPTl9TVUJfU1RPUk1fTElHSFROSU5HEA4S",
            "KwonQ0hBTkdFX0hQX1JFQVNPTl9TVUJfS0lMTF9TRVJWRVJfR0FER0VUEA8S",
            "IAocQ0hBTkdFX0hQX1JFQVNPTl9TVUJfUkVQTEFDRRAQEiUKIUNIQU5HRV9I",
            "UF9SRUFTT05fU1VCX1BMQVlFUl9MRUFWRRAREigKJENIQU5HRV9IUF9SRUFT",
            "T05fVW5rMjcwMF9DSUtDREJPSkdESxASEigKJENIQU5HRV9IUF9SRUFTT05f",
            "VW5rMjcwMF9IRUtMQkxGQkpKSxATEhsKF0NIQU5HRV9IUF9SRUFTT05fQllf",
            "TFVBEDMSIAocQ0hBTkdFX0hQX1JFQVNPTl9BRERfQUJJTElUWRBlEh0KGUNI",
            "QU5HRV9IUF9SRUFTT05fQUREX0lURU0QZhIfChtDSEFOR0VfSFBfUkVBU09O",
            "X0FERF9SRVZJVkUQZxIgChxDSEFOR0VfSFBfUkVBU09OX0FERF9VUEdSQURF",
            "EGgSHwobQ0hBTkdFX0hQX1JFQVNPTl9BRERfU1RBVFVFEGkSIwofQ0hBTkdF",
            "X0hQX1JFQVNPTl9BRERfQkFDS0dST1VORBBqEhsKF0NIQU5HRV9IUF9SRUFT",
            "T05fQUREX0dNEGsSLgoqQ0hBTkdFX0hQX1JFQVNPTl9BRERfVFJJQUxfQVZB",
            "VEFSX0FDVElWSVRZEGwSKgomQ0hBTkdFX0hQX1JFQVNPTl9BRERfUk9VR1VF",
            "TElLRV9TUFJJTkcQbUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Server.Proto.ChangeHpReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ChangeHpReason {
    [pbr::OriginalName("CHANGE_HP_REASON_NONE")] None = 0,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_AVATAR")] SubAvatar = 1,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_MONSTER")] SubMonster = 2,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_GEAR")] SubGear = 3,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_ENVIR")] SubEnvir = 4,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_FALL")] SubFall = 5,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_DRAWN")] SubDrawn = 6,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_ABYSS")] SubAbyss = 7,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_ABILITY")] SubAbility = 8,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_SUMMON")] SubSummon = 9,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_SCRIPT")] SubScript = 10,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_GM")] SubGm = 11,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_KILL_SELF")] SubKillSelf = 12,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_CLIMATE_COLD")] SubClimateCold = 13,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_STORM_LIGHTNING")] SubStormLightning = 14,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_KILL_SERVER_GADGET")] SubKillServerGadget = 15,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_REPLACE")] SubReplace = 16,
    [pbr::OriginalName("CHANGE_HP_REASON_SUB_PLAYER_LEAVE")] SubPlayerLeave = 17,
    [pbr::OriginalName("CHANGE_HP_REASON_Unk2700_CIKCDBOJGDK")] Unk2700Cikcdbojgdk = 18,
    [pbr::OriginalName("CHANGE_HP_REASON_Unk2700_HEKLBLFBJJK")] Unk2700Heklblfbjjk = 19,
    [pbr::OriginalName("CHANGE_HP_REASON_BY_LUA")] ByLua = 51,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_ABILITY")] AddAbility = 101,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_ITEM")] AddItem = 102,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_REVIVE")] AddRevive = 103,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_UPGRADE")] AddUpgrade = 104,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_STATUE")] AddStatue = 105,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_BACKGROUND")] AddBackground = 106,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_GM")] AddGm = 107,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_TRIAL_AVATAR_ACTIVITY")] AddTrialAvatarActivity = 108,
    [pbr::OriginalName("CHANGE_HP_REASON_ADD_ROUGUELIKE_SPRING")] AddRouguelikeSpring = 109,
  }

  #endregion

}

#endregion Designer generated code
