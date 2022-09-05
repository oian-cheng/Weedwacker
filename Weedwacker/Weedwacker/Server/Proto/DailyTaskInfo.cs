// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DailyTaskInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from DailyTaskInfo.proto</summary>
  public static partial class DailyTaskInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DailyTaskInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DailyTaskInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNEYWlseVRhc2tJbmZvLnByb3RvInkKDURhaWx5VGFza0luZm8SEQoJcmV3",
            "YXJkX2lkGAMgASgNEhAKCHByb2dyZXNzGA0gASgNEhcKD2ZpbmlzaF9wcm9n",
            "cmVzcxgKIAEoDRIVCg1kYWlseV90YXNrX2lkGAQgASgNEhMKC2lzX2Zpbmlz",
            "aGVkGA4gASgIQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.DailyTaskInfo), global::Weedwacker.Server.Proto.DailyTaskInfo.Parser, new[]{ "RewardId", "Progress", "FinishProgress", "DailyTaskId", "IsFinished" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DailyTaskInfo : pb::IMessage<DailyTaskInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DailyTaskInfo> _parser = new pb::MessageParser<DailyTaskInfo>(() => new DailyTaskInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DailyTaskInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.DailyTaskInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyTaskInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyTaskInfo(DailyTaskInfo other) : this() {
      rewardId_ = other.rewardId_;
      progress_ = other.progress_;
      finishProgress_ = other.finishProgress_;
      dailyTaskId_ = other.dailyTaskId_;
      isFinished_ = other.isFinished_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DailyTaskInfo Clone() {
      return new DailyTaskInfo(this);
    }

    /// <summary>Field number for the "reward_id" field.</summary>
    public const int RewardIdFieldNumber = 3;
    private uint rewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardId {
      get { return rewardId_; }
      set {
        rewardId_ = value;
      }
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 13;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "finish_progress" field.</summary>
    public const int FinishProgressFieldNumber = 10;
    private uint finishProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishProgress {
      get { return finishProgress_; }
      set {
        finishProgress_ = value;
      }
    }

    /// <summary>Field number for the "daily_task_id" field.</summary>
    public const int DailyTaskIdFieldNumber = 4;
    private uint dailyTaskId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DailyTaskId {
      get { return dailyTaskId_; }
      set {
        dailyTaskId_ = value;
      }
    }

    /// <summary>Field number for the "is_finished" field.</summary>
    public const int IsFinishedFieldNumber = 14;
    private bool isFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinished {
      get { return isFinished_; }
      set {
        isFinished_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DailyTaskInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DailyTaskInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RewardId != other.RewardId) return false;
      if (Progress != other.Progress) return false;
      if (FinishProgress != other.FinishProgress) return false;
      if (DailyTaskId != other.DailyTaskId) return false;
      if (IsFinished != other.IsFinished) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RewardId != 0) hash ^= RewardId.GetHashCode();
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (FinishProgress != 0) hash ^= FinishProgress.GetHashCode();
      if (DailyTaskId != 0) hash ^= DailyTaskId.GetHashCode();
      if (IsFinished != false) hash ^= IsFinished.GetHashCode();
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
      if (RewardId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RewardId);
      }
      if (DailyTaskId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DailyTaskId);
      }
      if (FinishProgress != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FinishProgress);
      }
      if (Progress != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Progress);
      }
      if (IsFinished != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinished);
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
      if (RewardId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RewardId);
      }
      if (DailyTaskId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DailyTaskId);
      }
      if (FinishProgress != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FinishProgress);
      }
      if (Progress != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Progress);
      }
      if (IsFinished != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinished);
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
      if (RewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
      }
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (FinishProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishProgress);
      }
      if (DailyTaskId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DailyTaskId);
      }
      if (IsFinished != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DailyTaskInfo other) {
      if (other == null) {
        return;
      }
      if (other.RewardId != 0) {
        RewardId = other.RewardId;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.FinishProgress != 0) {
        FinishProgress = other.FinishProgress;
      }
      if (other.DailyTaskId != 0) {
        DailyTaskId = other.DailyTaskId;
      }
      if (other.IsFinished != false) {
        IsFinished = other.IsFinished;
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
          case 24: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 32: {
            DailyTaskId = input.ReadUInt32();
            break;
          }
          case 80: {
            FinishProgress = input.ReadUInt32();
            break;
          }
          case 104: {
            Progress = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinished = input.ReadBool();
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
          case 24: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 32: {
            DailyTaskId = input.ReadUInt32();
            break;
          }
          case 80: {
            FinishProgress = input.ReadUInt32();
            break;
          }
          case 104: {
            Progress = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinished = input.ReadBool();
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
