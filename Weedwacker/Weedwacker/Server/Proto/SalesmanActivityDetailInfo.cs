// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SalesmanActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from SalesmanActivityDetailInfo.proto</summary>
  public static partial class SalesmanActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SalesmanActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SalesmanActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTYWxlc21hbkFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxoYU2FsZXNtYW5T",
            "dGF0dXNUeXBlLnByb3RvIq8DChpTYWxlc21hbkFjdGl2aXR5RGV0YWlsSW5m",
            "bxIhChlzcGVjaWFsX3Jld2FyZF9wcmV2aWV3X2lkGAMgASgNEiMKBnN0YXR1",
            "cxgEIAEoDjITLlNhbGVzbWFuU3RhdHVzVHlwZRIZChFsYXN0X2RlbGl2ZXJf",
            "dGltZRgCIAEoDRJUChZzZWxlY3RlZF9yZXdhcmRfaWRfbWFwGAUgAygLMjQu",
            "U2FsZXNtYW5BY3Rpdml0eURldGFpbEluZm8uU2VsZWN0ZWRSZXdhcmRJZE1h",
            "cEVudHJ5EhUKDWRlbGl2ZXJfY291bnQYCyABKA0SIwobaXNfaGFzX3Rha2Vu",
            "X3NwZWNpYWxfcmV3YXJkGAcgASgIEhEKCWRheV9pbmRleBgMIAEoDRIWCg5j",
            "b25kX2RheV9jb3VudBgGIAEoDRIVCg1kYXlfcmV3YXJkX2lkGAkgASgNEh4K",
            "FmlzX3RvZGF5X2hhc19kZWxpdmVyZWQYDSABKAgaOgoYU2VsZWN0ZWRSZXdh",
            "cmRJZE1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFC",
            "GqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.SalesmanStatusTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.SalesmanActivityDetailInfo), global::Weedwacker.Server.Proto.SalesmanActivityDetailInfo.Parser, new[]{ "SpecialRewardPreviewId", "Status", "LastDeliverTime", "SelectedRewardIdMap", "DeliverCount", "IsHasTakenSpecialReward", "DayIndex", "CondDayCount", "DayRewardId", "IsTodayHasDelivered" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SalesmanActivityDetailInfo : pb::IMessage<SalesmanActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SalesmanActivityDetailInfo> _parser = new pb::MessageParser<SalesmanActivityDetailInfo>(() => new SalesmanActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SalesmanActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.SalesmanActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalesmanActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalesmanActivityDetailInfo(SalesmanActivityDetailInfo other) : this() {
      specialRewardPreviewId_ = other.specialRewardPreviewId_;
      status_ = other.status_;
      lastDeliverTime_ = other.lastDeliverTime_;
      selectedRewardIdMap_ = other.selectedRewardIdMap_.Clone();
      deliverCount_ = other.deliverCount_;
      isHasTakenSpecialReward_ = other.isHasTakenSpecialReward_;
      dayIndex_ = other.dayIndex_;
      condDayCount_ = other.condDayCount_;
      dayRewardId_ = other.dayRewardId_;
      isTodayHasDelivered_ = other.isTodayHasDelivered_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalesmanActivityDetailInfo Clone() {
      return new SalesmanActivityDetailInfo(this);
    }

    /// <summary>Field number for the "special_reward_preview_id" field.</summary>
    public const int SpecialRewardPreviewIdFieldNumber = 3;
    private uint specialRewardPreviewId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SpecialRewardPreviewId {
      get { return specialRewardPreviewId_; }
      set {
        specialRewardPreviewId_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Weedwacker.Server.Proto.SalesmanStatusType status_ = global::Weedwacker.Server.Proto.SalesmanStatusType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.SalesmanStatusType Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "last_deliver_time" field.</summary>
    public const int LastDeliverTimeFieldNumber = 2;
    private uint lastDeliverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastDeliverTime {
      get { return lastDeliverTime_; }
      set {
        lastDeliverTime_ = value;
      }
    }

    /// <summary>Field number for the "selected_reward_id_map" field.</summary>
    public const int SelectedRewardIdMapFieldNumber = 5;
    private static readonly pbc::MapField<uint, uint>.Codec _map_selectedRewardIdMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 42);
    private readonly pbc::MapField<uint, uint> selectedRewardIdMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SelectedRewardIdMap {
      get { return selectedRewardIdMap_; }
    }

    /// <summary>Field number for the "deliver_count" field.</summary>
    public const int DeliverCountFieldNumber = 11;
    private uint deliverCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DeliverCount {
      get { return deliverCount_; }
      set {
        deliverCount_ = value;
      }
    }

    /// <summary>Field number for the "is_has_taken_special_reward" field.</summary>
    public const int IsHasTakenSpecialRewardFieldNumber = 7;
    private bool isHasTakenSpecialReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsHasTakenSpecialReward {
      get { return isHasTakenSpecialReward_; }
      set {
        isHasTakenSpecialReward_ = value;
      }
    }

    /// <summary>Field number for the "day_index" field.</summary>
    public const int DayIndexFieldNumber = 12;
    private uint dayIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DayIndex {
      get { return dayIndex_; }
      set {
        dayIndex_ = value;
      }
    }

    /// <summary>Field number for the "cond_day_count" field.</summary>
    public const int CondDayCountFieldNumber = 6;
    private uint condDayCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CondDayCount {
      get { return condDayCount_; }
      set {
        condDayCount_ = value;
      }
    }

    /// <summary>Field number for the "day_reward_id" field.</summary>
    public const int DayRewardIdFieldNumber = 9;
    private uint dayRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DayRewardId {
      get { return dayRewardId_; }
      set {
        dayRewardId_ = value;
      }
    }

    /// <summary>Field number for the "is_today_has_delivered" field.</summary>
    public const int IsTodayHasDeliveredFieldNumber = 13;
    private bool isTodayHasDelivered_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTodayHasDelivered {
      get { return isTodayHasDelivered_; }
      set {
        isTodayHasDelivered_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SalesmanActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SalesmanActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SpecialRewardPreviewId != other.SpecialRewardPreviewId) return false;
      if (Status != other.Status) return false;
      if (LastDeliverTime != other.LastDeliverTime) return false;
      if (!SelectedRewardIdMap.Equals(other.SelectedRewardIdMap)) return false;
      if (DeliverCount != other.DeliverCount) return false;
      if (IsHasTakenSpecialReward != other.IsHasTakenSpecialReward) return false;
      if (DayIndex != other.DayIndex) return false;
      if (CondDayCount != other.CondDayCount) return false;
      if (DayRewardId != other.DayRewardId) return false;
      if (IsTodayHasDelivered != other.IsTodayHasDelivered) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SpecialRewardPreviewId != 0) hash ^= SpecialRewardPreviewId.GetHashCode();
      if (Status != global::Weedwacker.Server.Proto.SalesmanStatusType.None) hash ^= Status.GetHashCode();
      if (LastDeliverTime != 0) hash ^= LastDeliverTime.GetHashCode();
      hash ^= SelectedRewardIdMap.GetHashCode();
      if (DeliverCount != 0) hash ^= DeliverCount.GetHashCode();
      if (IsHasTakenSpecialReward != false) hash ^= IsHasTakenSpecialReward.GetHashCode();
      if (DayIndex != 0) hash ^= DayIndex.GetHashCode();
      if (CondDayCount != 0) hash ^= CondDayCount.GetHashCode();
      if (DayRewardId != 0) hash ^= DayRewardId.GetHashCode();
      if (IsTodayHasDelivered != false) hash ^= IsTodayHasDelivered.GetHashCode();
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
      if (LastDeliverTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LastDeliverTime);
      }
      if (SpecialRewardPreviewId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SpecialRewardPreviewId);
      }
      if (Status != global::Weedwacker.Server.Proto.SalesmanStatusType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      selectedRewardIdMap_.WriteTo(output, _map_selectedRewardIdMap_codec);
      if (CondDayCount != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CondDayCount);
      }
      if (IsHasTakenSpecialReward != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsHasTakenSpecialReward);
      }
      if (DayRewardId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DayRewardId);
      }
      if (DeliverCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DeliverCount);
      }
      if (DayIndex != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DayIndex);
      }
      if (IsTodayHasDelivered != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsTodayHasDelivered);
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
      if (LastDeliverTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LastDeliverTime);
      }
      if (SpecialRewardPreviewId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SpecialRewardPreviewId);
      }
      if (Status != global::Weedwacker.Server.Proto.SalesmanStatusType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      selectedRewardIdMap_.WriteTo(ref output, _map_selectedRewardIdMap_codec);
      if (CondDayCount != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CondDayCount);
      }
      if (IsHasTakenSpecialReward != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsHasTakenSpecialReward);
      }
      if (DayRewardId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DayRewardId);
      }
      if (DeliverCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DeliverCount);
      }
      if (DayIndex != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DayIndex);
      }
      if (IsTodayHasDelivered != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsTodayHasDelivered);
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
      if (SpecialRewardPreviewId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SpecialRewardPreviewId);
      }
      if (Status != global::Weedwacker.Server.Proto.SalesmanStatusType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (LastDeliverTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastDeliverTime);
      }
      size += selectedRewardIdMap_.CalculateSize(_map_selectedRewardIdMap_codec);
      if (DeliverCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DeliverCount);
      }
      if (IsHasTakenSpecialReward != false) {
        size += 1 + 1;
      }
      if (DayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DayIndex);
      }
      if (CondDayCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CondDayCount);
      }
      if (DayRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DayRewardId);
      }
      if (IsTodayHasDelivered != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SalesmanActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.SpecialRewardPreviewId != 0) {
        SpecialRewardPreviewId = other.SpecialRewardPreviewId;
      }
      if (other.Status != global::Weedwacker.Server.Proto.SalesmanStatusType.None) {
        Status = other.Status;
      }
      if (other.LastDeliverTime != 0) {
        LastDeliverTime = other.LastDeliverTime;
      }
      selectedRewardIdMap_.Add(other.selectedRewardIdMap_);
      if (other.DeliverCount != 0) {
        DeliverCount = other.DeliverCount;
      }
      if (other.IsHasTakenSpecialReward != false) {
        IsHasTakenSpecialReward = other.IsHasTakenSpecialReward;
      }
      if (other.DayIndex != 0) {
        DayIndex = other.DayIndex;
      }
      if (other.CondDayCount != 0) {
        CondDayCount = other.CondDayCount;
      }
      if (other.DayRewardId != 0) {
        DayRewardId = other.DayRewardId;
      }
      if (other.IsTodayHasDelivered != false) {
        IsTodayHasDelivered = other.IsTodayHasDelivered;
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
          case 16: {
            LastDeliverTime = input.ReadUInt32();
            break;
          }
          case 24: {
            SpecialRewardPreviewId = input.ReadUInt32();
            break;
          }
          case 32: {
            Status = (global::Weedwacker.Server.Proto.SalesmanStatusType) input.ReadEnum();
            break;
          }
          case 42: {
            selectedRewardIdMap_.AddEntriesFrom(input, _map_selectedRewardIdMap_codec);
            break;
          }
          case 48: {
            CondDayCount = input.ReadUInt32();
            break;
          }
          case 56: {
            IsHasTakenSpecialReward = input.ReadBool();
            break;
          }
          case 72: {
            DayRewardId = input.ReadUInt32();
            break;
          }
          case 88: {
            DeliverCount = input.ReadUInt32();
            break;
          }
          case 96: {
            DayIndex = input.ReadUInt32();
            break;
          }
          case 104: {
            IsTodayHasDelivered = input.ReadBool();
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
          case 16: {
            LastDeliverTime = input.ReadUInt32();
            break;
          }
          case 24: {
            SpecialRewardPreviewId = input.ReadUInt32();
            break;
          }
          case 32: {
            Status = (global::Weedwacker.Server.Proto.SalesmanStatusType) input.ReadEnum();
            break;
          }
          case 42: {
            selectedRewardIdMap_.AddEntriesFrom(ref input, _map_selectedRewardIdMap_codec);
            break;
          }
          case 48: {
            CondDayCount = input.ReadUInt32();
            break;
          }
          case 56: {
            IsHasTakenSpecialReward = input.ReadBool();
            break;
          }
          case 72: {
            DayRewardId = input.ReadUInt32();
            break;
          }
          case 88: {
            DeliverCount = input.ReadUInt32();
            break;
          }
          case 96: {
            DayIndex = input.ReadUInt32();
            break;
          }
          case 104: {
            IsTodayHasDelivered = input.ReadBool();
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
