// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InvestigationMonster.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InvestigationMonster.proto</summary>
  public static partial class InvestigationMonsterReflection {

    #region Descriptor
    /// <summary>File descriptor for InvestigationMonster.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InvestigationMonsterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpJbnZlc3RpZ2F0aW9uTW9uc3Rlci5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90bxoMVmVjdG9yLnByb3RvGiFXZWVrbHlCb3NzUmVz",
            "aW5EaXNjb3VudEluZm8ucHJvdG8i7gQKFEludmVzdGlnYXRpb25Nb25zdGVy",
            "EhAKCGlzX2FsaXZlGA0gASgIEjQKA3BvcxgHIAEoCzInLldlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9yEhAKCHNjZW5lX2lkGAwgASgN",
            "EhkKEW5leHRfcmVmcmVzaF90aW1lGAggASgNEg8KB2NpdHlfaWQYDiABKA0S",
            "EQoIZ3JvdXBfaWQYxw0gASgNEhsKE1VuazMzMDBfT05MQUxDQ0tJRUUYASAB",
            "KA0SZQofd2Vla2x5X2Jvc3NfcmVzaW5fZGlzY291bnRfaW5mbxgDIAEoCzI8",
            "LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uV2Vla2x5Qm9zc1Jl",
            "c2luRGlzY291bnRJbmZvEhsKE1VuazMzMDBfREtLT0JESUVLUFAYBiABKA0S",
            "CgoCaWQYCSABKA0SEwoKbW9uc3Rlcl9pZBiyBCABKA0SUwoKbG9ja19zdGF0",
            "ZRgEIAEoDjI/LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uSW52",
            "ZXN0aWdhdGlvbk1vbnN0ZXIuTG9ja1N0YXRlEhsKE1VuazMzMDBfSkhMRUhF",
            "T09HR0IYCiABKA0SFgoOaXNfYXJlYV9sb2NrZWQYBSABKAgSDQoFbGV2ZWwY",
            "AiABKA0SGwoTVW5rMzMwMF9LTktGQ09LTUVDSRgLIAEoDRINCgVyZXNpbhgP",
            "IAEoDSI2CglMb2NrU3RhdGUSEwoPTE9DS19TVEFURV9OT05FEAASFAoQTE9D",
            "S19TVEFURV9RVUVTVBABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WeeklyBossResinDiscountInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.InvestigationMonster), global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Parser, new[]{ "IsAlive", "Pos", "SceneId", "NextRefreshTime", "CityId", "GroupId", "Unk3300ONLALCCKIEE", "WeeklyBossResinDiscountInfo", "Unk3300DKKOBDIEKPP", "Id", "MonsterId", "LockState", "Unk3300JHLEHEOOGGB", "IsAreaLocked", "Level", "Unk3300KNKFCOKMECI", "Resin" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InvestigationMonster : pb::IMessage<InvestigationMonster>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InvestigationMonster> _parser = new pb::MessageParser<InvestigationMonster>(() => new InvestigationMonster());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InvestigationMonster> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.InvestigationMonsterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InvestigationMonster() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InvestigationMonster(InvestigationMonster other) : this() {
      isAlive_ = other.isAlive_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      sceneId_ = other.sceneId_;
      nextRefreshTime_ = other.nextRefreshTime_;
      cityId_ = other.cityId_;
      groupId_ = other.groupId_;
      unk3300ONLALCCKIEE_ = other.unk3300ONLALCCKIEE_;
      weeklyBossResinDiscountInfo_ = other.weeklyBossResinDiscountInfo_ != null ? other.weeklyBossResinDiscountInfo_.Clone() : null;
      unk3300DKKOBDIEKPP_ = other.unk3300DKKOBDIEKPP_;
      id_ = other.id_;
      monsterId_ = other.monsterId_;
      lockState_ = other.lockState_;
      unk3300JHLEHEOOGGB_ = other.unk3300JHLEHEOOGGB_;
      isAreaLocked_ = other.isAreaLocked_;
      level_ = other.level_;
      unk3300KNKFCOKMECI_ = other.unk3300KNKFCOKMECI_;
      resin_ = other.resin_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InvestigationMonster Clone() {
      return new InvestigationMonster(this);
    }

    /// <summary>Field number for the "is_alive" field.</summary>
    public const int IsAliveFieldNumber = 13;
    private bool isAlive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAlive {
      get { return isAlive_; }
      set {
        isAlive_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 12;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 8;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "city_id" field.</summary>
    public const int CityIdFieldNumber = 14;
    private uint cityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityId {
      get { return cityId_; }
      set {
        cityId_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 1735;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ONLALCCKIEE" field.</summary>
    public const int Unk3300ONLALCCKIEEFieldNumber = 1;
    private uint unk3300ONLALCCKIEE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300ONLALCCKIEE {
      get { return unk3300ONLALCCKIEE_; }
      set {
        unk3300ONLALCCKIEE_ = value;
      }
    }

    /// <summary>Field number for the "weekly_boss_resin_discount_info" field.</summary>
    public const int WeeklyBossResinDiscountInfoFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.WeeklyBossResinDiscountInfo weeklyBossResinDiscountInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WeeklyBossResinDiscountInfo WeeklyBossResinDiscountInfo {
      get { return weeklyBossResinDiscountInfo_; }
      set {
        weeklyBossResinDiscountInfo_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DKKOBDIEKPP" field.</summary>
    public const int Unk3300DKKOBDIEKPPFieldNumber = 6;
    private uint unk3300DKKOBDIEKPP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DKKOBDIEKPP {
      get { return unk3300DKKOBDIEKPP_; }
      set {
        unk3300DKKOBDIEKPP_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 9;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 562;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "lock_state" field.</summary>
    public const int LockStateFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState lockState_ = global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState LockState {
      get { return lockState_; }
      set {
        lockState_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JHLEHEOOGGB" field.</summary>
    public const int Unk3300JHLEHEOOGGBFieldNumber = 10;
    private uint unk3300JHLEHEOOGGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JHLEHEOOGGB {
      get { return unk3300JHLEHEOOGGB_; }
      set {
        unk3300JHLEHEOOGGB_ = value;
      }
    }

    /// <summary>Field number for the "is_area_locked" field.</summary>
    public const int IsAreaLockedFieldNumber = 5;
    private bool isAreaLocked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAreaLocked {
      get { return isAreaLocked_; }
      set {
        isAreaLocked_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KNKFCOKMECI" field.</summary>
    public const int Unk3300KNKFCOKMECIFieldNumber = 11;
    private uint unk3300KNKFCOKMECI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KNKFCOKMECI {
      get { return unk3300KNKFCOKMECI_; }
      set {
        unk3300KNKFCOKMECI_ = value;
      }
    }

    /// <summary>Field number for the "resin" field.</summary>
    public const int ResinFieldNumber = 15;
    private uint resin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Resin {
      get { return resin_; }
      set {
        resin_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InvestigationMonster);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InvestigationMonster other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAlive != other.IsAlive) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (SceneId != other.SceneId) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if (CityId != other.CityId) return false;
      if (GroupId != other.GroupId) return false;
      if (Unk3300ONLALCCKIEE != other.Unk3300ONLALCCKIEE) return false;
      if (!object.Equals(WeeklyBossResinDiscountInfo, other.WeeklyBossResinDiscountInfo)) return false;
      if (Unk3300DKKOBDIEKPP != other.Unk3300DKKOBDIEKPP) return false;
      if (Id != other.Id) return false;
      if (MonsterId != other.MonsterId) return false;
      if (LockState != other.LockState) return false;
      if (Unk3300JHLEHEOOGGB != other.Unk3300JHLEHEOOGGB) return false;
      if (IsAreaLocked != other.IsAreaLocked) return false;
      if (Level != other.Level) return false;
      if (Unk3300KNKFCOKMECI != other.Unk3300KNKFCOKMECI) return false;
      if (Resin != other.Resin) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAlive != false) hash ^= IsAlive.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      if (CityId != 0) hash ^= CityId.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (Unk3300ONLALCCKIEE != 0) hash ^= Unk3300ONLALCCKIEE.GetHashCode();
      if (weeklyBossResinDiscountInfo_ != null) hash ^= WeeklyBossResinDiscountInfo.GetHashCode();
      if (Unk3300DKKOBDIEKPP != 0) hash ^= Unk3300DKKOBDIEKPP.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      if (LockState != global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState.None) hash ^= LockState.GetHashCode();
      if (Unk3300JHLEHEOOGGB != 0) hash ^= Unk3300JHLEHEOOGGB.GetHashCode();
      if (IsAreaLocked != false) hash ^= IsAreaLocked.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Unk3300KNKFCOKMECI != 0) hash ^= Unk3300KNKFCOKMECI.GetHashCode();
      if (Resin != 0) hash ^= Resin.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Unk3300ONLALCCKIEE != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300ONLALCCKIEE);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (weeklyBossResinDiscountInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(WeeklyBossResinDiscountInfo);
      }
      if (LockState != global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) LockState);
      }
      if (IsAreaLocked != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsAreaLocked);
      }
      if (Unk3300DKKOBDIEKPP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300DKKOBDIEKPP);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NextRefreshTime);
      }
      if (Id != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Id);
      }
      if (Unk3300JHLEHEOOGGB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300JHLEHEOOGGB);
      }
      if (Unk3300KNKFCOKMECI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300KNKFCOKMECI);
      }
      if (SceneId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneId);
      }
      if (IsAlive != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsAlive);
      }
      if (CityId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CityId);
      }
      if (Resin != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Resin);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(144, 35);
        output.WriteUInt32(MonsterId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(184, 108);
        output.WriteUInt32(GroupId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk3300ONLALCCKIEE != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300ONLALCCKIEE);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (weeklyBossResinDiscountInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(WeeklyBossResinDiscountInfo);
      }
      if (LockState != global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) LockState);
      }
      if (IsAreaLocked != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsAreaLocked);
      }
      if (Unk3300DKKOBDIEKPP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300DKKOBDIEKPP);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NextRefreshTime);
      }
      if (Id != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Id);
      }
      if (Unk3300JHLEHEOOGGB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300JHLEHEOOGGB);
      }
      if (Unk3300KNKFCOKMECI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300KNKFCOKMECI);
      }
      if (SceneId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneId);
      }
      if (IsAlive != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsAlive);
      }
      if (CityId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CityId);
      }
      if (Resin != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Resin);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(144, 35);
        output.WriteUInt32(MonsterId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(184, 108);
        output.WriteUInt32(GroupId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsAlive != false) {
        size += 1 + 1;
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      if (CityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
      }
      if (GroupId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (Unk3300ONLALCCKIEE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300ONLALCCKIEE);
      }
      if (weeklyBossResinDiscountInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WeeklyBossResinDiscountInfo);
      }
      if (Unk3300DKKOBDIEKPP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DKKOBDIEKPP);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (MonsterId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (LockState != global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LockState);
      }
      if (Unk3300JHLEHEOOGGB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JHLEHEOOGGB);
      }
      if (IsAreaLocked != false) {
        size += 1 + 1;
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Unk3300KNKFCOKMECI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KNKFCOKMECI);
      }
      if (Resin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Resin);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InvestigationMonster other) {
      if (other == null) {
        return;
      }
      if (other.IsAlive != false) {
        IsAlive = other.IsAlive;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      if (other.CityId != 0) {
        CityId = other.CityId;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.Unk3300ONLALCCKIEE != 0) {
        Unk3300ONLALCCKIEE = other.Unk3300ONLALCCKIEE;
      }
      if (other.weeklyBossResinDiscountInfo_ != null) {
        if (weeklyBossResinDiscountInfo_ == null) {
          WeeklyBossResinDiscountInfo = new global::Weedwacker.Shared.Network.Proto.WeeklyBossResinDiscountInfo();
        }
        WeeklyBossResinDiscountInfo.MergeFrom(other.WeeklyBossResinDiscountInfo);
      }
      if (other.Unk3300DKKOBDIEKPP != 0) {
        Unk3300DKKOBDIEKPP = other.Unk3300DKKOBDIEKPP;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      if (other.LockState != global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState.None) {
        LockState = other.LockState;
      }
      if (other.Unk3300JHLEHEOOGGB != 0) {
        Unk3300JHLEHEOOGGB = other.Unk3300JHLEHEOOGGB;
      }
      if (other.IsAreaLocked != false) {
        IsAreaLocked = other.IsAreaLocked;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Unk3300KNKFCOKMECI != 0) {
        Unk3300KNKFCOKMECI = other.Unk3300KNKFCOKMECI;
      }
      if (other.Resin != 0) {
        Resin = other.Resin;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Unk3300ONLALCCKIEE = input.ReadUInt32();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 26: {
            if (weeklyBossResinDiscountInfo_ == null) {
              WeeklyBossResinDiscountInfo = new global::Weedwacker.Shared.Network.Proto.WeeklyBossResinDiscountInfo();
            }
            input.ReadMessage(WeeklyBossResinDiscountInfo);
            break;
          }
          case 32: {
            LockState = (global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState) input.ReadEnum();
            break;
          }
          case 40: {
            IsAreaLocked = input.ReadBool();
            break;
          }
          case 48: {
            Unk3300DKKOBDIEKPP = input.ReadUInt32();
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 64: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 72: {
            Id = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300JHLEHEOOGGB = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk3300KNKFCOKMECI = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 104: {
            IsAlive = input.ReadBool();
            break;
          }
          case 112: {
            CityId = input.ReadUInt32();
            break;
          }
          case 120: {
            Resin = input.ReadUInt32();
            break;
          }
          case 4496: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 13880: {
            GroupId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Unk3300ONLALCCKIEE = input.ReadUInt32();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 26: {
            if (weeklyBossResinDiscountInfo_ == null) {
              WeeklyBossResinDiscountInfo = new global::Weedwacker.Shared.Network.Proto.WeeklyBossResinDiscountInfo();
            }
            input.ReadMessage(WeeklyBossResinDiscountInfo);
            break;
          }
          case 32: {
            LockState = (global::Weedwacker.Shared.Network.Proto.InvestigationMonster.Types.LockState) input.ReadEnum();
            break;
          }
          case 40: {
            IsAreaLocked = input.ReadBool();
            break;
          }
          case 48: {
            Unk3300DKKOBDIEKPP = input.ReadUInt32();
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 64: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 72: {
            Id = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300JHLEHEOOGGB = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk3300KNKFCOKMECI = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 104: {
            IsAlive = input.ReadBool();
            break;
          }
          case 112: {
            CityId = input.ReadUInt32();
            break;
          }
          case 120: {
            Resin = input.ReadUInt32();
            break;
          }
          case 4496: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 13880: {
            GroupId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the InvestigationMonster message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum LockState {
        [pbr::OriginalName("LOCK_STATE_NONE")] None = 0,
        [pbr::OriginalName("LOCK_STATE_QUEST")] Quest = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
