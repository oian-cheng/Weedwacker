// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonEntryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from DungeonEntryInfo.proto</summary>
  public static partial class DungeonEntryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonEntryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonEntryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZEdW5nZW9uRW50cnlJbmZvLnByb3RvGiFXZWVrbHlCb3NzUmVzaW5EaXNj",
            "b3VudEluZm8ucHJvdG8iiQIKEER1bmdlb25FbnRyeUluZm8SEAoIZW5kX3Rp",
            "bWUYBiABKA0SEgoKZHVuZ2Vvbl9pZBgFIAEoDRIWCg5ib3NzX2NoZXN0X251",
            "bRgMIAEoDRIaChJtYXhfYm9zc19jaGVzdF9udW0YDSABKA0SGQoRbmV4dF9y",
            "ZWZyZXNoX3RpbWUYCyABKA0SRQofd2Vla2x5X2Jvc3NfcmVzaW5fZGlzY291",
            "bnRfaW5mbxgJIAEoCzIcLldlZWtseUJvc3NSZXNpbkRpc2NvdW50SW5mbxIS",
            "CgpzdGFydF90aW1lGA8gASgNEhEKCWlzX3Bhc3NlZBgEIAEoCBISCgpsZWZ0",
            "X3RpbWVzGAcgASgNQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.WeeklyBossResinDiscountInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.DungeonEntryInfo), global::Weedwacker.Server.Proto.DungeonEntryInfo.Parser, new[]{ "EndTime", "DungeonId", "BossChestNum", "MaxBossChestNum", "NextRefreshTime", "WeeklyBossResinDiscountInfo", "StartTime", "IsPassed", "LeftTimes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DungeonEntryInfo : pb::IMessage<DungeonEntryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonEntryInfo> _parser = new pb::MessageParser<DungeonEntryInfo>(() => new DungeonEntryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonEntryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.DungeonEntryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryInfo(DungeonEntryInfo other) : this() {
      endTime_ = other.endTime_;
      dungeonId_ = other.dungeonId_;
      bossChestNum_ = other.bossChestNum_;
      maxBossChestNum_ = other.maxBossChestNum_;
      nextRefreshTime_ = other.nextRefreshTime_;
      weeklyBossResinDiscountInfo_ = other.weeklyBossResinDiscountInfo_ != null ? other.weeklyBossResinDiscountInfo_.Clone() : null;
      startTime_ = other.startTime_;
      isPassed_ = other.isPassed_;
      leftTimes_ = other.leftTimes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryInfo Clone() {
      return new DungeonEntryInfo(this);
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 6;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 5;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "boss_chest_num" field.</summary>
    public const int BossChestNumFieldNumber = 12;
    private uint bossChestNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BossChestNum {
      get { return bossChestNum_; }
      set {
        bossChestNum_ = value;
      }
    }

    /// <summary>Field number for the "max_boss_chest_num" field.</summary>
    public const int MaxBossChestNumFieldNumber = 13;
    private uint maxBossChestNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxBossChestNum {
      get { return maxBossChestNum_; }
      set {
        maxBossChestNum_ = value;
      }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 11;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "weekly_boss_resin_discount_info" field.</summary>
    public const int WeeklyBossResinDiscountInfoFieldNumber = 9;
    private global::Weedwacker.Server.Proto.WeeklyBossResinDiscountInfo weeklyBossResinDiscountInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.WeeklyBossResinDiscountInfo WeeklyBossResinDiscountInfo {
      get { return weeklyBossResinDiscountInfo_; }
      set {
        weeklyBossResinDiscountInfo_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 15;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "is_passed" field.</summary>
    public const int IsPassedFieldNumber = 4;
    private bool isPassed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPassed {
      get { return isPassed_; }
      set {
        isPassed_ = value;
      }
    }

    /// <summary>Field number for the "left_times" field.</summary>
    public const int LeftTimesFieldNumber = 7;
    private uint leftTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftTimes {
      get { return leftTimes_; }
      set {
        leftTimes_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonEntryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonEntryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EndTime != other.EndTime) return false;
      if (DungeonId != other.DungeonId) return false;
      if (BossChestNum != other.BossChestNum) return false;
      if (MaxBossChestNum != other.MaxBossChestNum) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if (!object.Equals(WeeklyBossResinDiscountInfo, other.WeeklyBossResinDiscountInfo)) return false;
      if (StartTime != other.StartTime) return false;
      if (IsPassed != other.IsPassed) return false;
      if (LeftTimes != other.LeftTimes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (BossChestNum != 0) hash ^= BossChestNum.GetHashCode();
      if (MaxBossChestNum != 0) hash ^= MaxBossChestNum.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      if (weeklyBossResinDiscountInfo_ != null) hash ^= WeeklyBossResinDiscountInfo.GetHashCode();
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (IsPassed != false) hash ^= IsPassed.GetHashCode();
      if (LeftTimes != 0) hash ^= LeftTimes.GetHashCode();
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
      if (IsPassed != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsPassed);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DungeonId);
      }
      if (EndTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EndTime);
      }
      if (LeftTimes != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LeftTimes);
      }
      if (weeklyBossResinDiscountInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(WeeklyBossResinDiscountInfo);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NextRefreshTime);
      }
      if (BossChestNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BossChestNum);
      }
      if (MaxBossChestNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MaxBossChestNum);
      }
      if (StartTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StartTime);
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
      if (IsPassed != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsPassed);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DungeonId);
      }
      if (EndTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EndTime);
      }
      if (LeftTimes != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LeftTimes);
      }
      if (weeklyBossResinDiscountInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(WeeklyBossResinDiscountInfo);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NextRefreshTime);
      }
      if (BossChestNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BossChestNum);
      }
      if (MaxBossChestNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MaxBossChestNum);
      }
      if (StartTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StartTime);
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
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (BossChestNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BossChestNum);
      }
      if (MaxBossChestNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxBossChestNum);
      }
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      if (weeklyBossResinDiscountInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WeeklyBossResinDiscountInfo);
      }
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (IsPassed != false) {
        size += 1 + 1;
      }
      if (LeftTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftTimes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonEntryInfo other) {
      if (other == null) {
        return;
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.BossChestNum != 0) {
        BossChestNum = other.BossChestNum;
      }
      if (other.MaxBossChestNum != 0) {
        MaxBossChestNum = other.MaxBossChestNum;
      }
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      if (other.weeklyBossResinDiscountInfo_ != null) {
        if (weeklyBossResinDiscountInfo_ == null) {
          WeeklyBossResinDiscountInfo = new global::Weedwacker.Server.Proto.WeeklyBossResinDiscountInfo();
        }
        WeeklyBossResinDiscountInfo.MergeFrom(other.WeeklyBossResinDiscountInfo);
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      if (other.IsPassed != false) {
        IsPassed = other.IsPassed;
      }
      if (other.LeftTimes != 0) {
        LeftTimes = other.LeftTimes;
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
          case 32: {
            IsPassed = input.ReadBool();
            break;
          }
          case 40: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 48: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 56: {
            LeftTimes = input.ReadUInt32();
            break;
          }
          case 74: {
            if (weeklyBossResinDiscountInfo_ == null) {
              WeeklyBossResinDiscountInfo = new global::Weedwacker.Server.Proto.WeeklyBossResinDiscountInfo();
            }
            input.ReadMessage(WeeklyBossResinDiscountInfo);
            break;
          }
          case 88: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 96: {
            BossChestNum = input.ReadUInt32();
            break;
          }
          case 104: {
            MaxBossChestNum = input.ReadUInt32();
            break;
          }
          case 120: {
            StartTime = input.ReadUInt32();
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
          case 32: {
            IsPassed = input.ReadBool();
            break;
          }
          case 40: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 48: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 56: {
            LeftTimes = input.ReadUInt32();
            break;
          }
          case 74: {
            if (weeklyBossResinDiscountInfo_ == null) {
              WeeklyBossResinDiscountInfo = new global::Weedwacker.Server.Proto.WeeklyBossResinDiscountInfo();
            }
            input.ReadMessage(WeeklyBossResinDiscountInfo);
            break;
          }
          case 88: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 96: {
            BossChestNum = input.ReadUInt32();
            break;
          }
          case 104: {
            MaxBossChestNum = input.ReadUInt32();
            break;
          }
          case 120: {
            StartTime = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
