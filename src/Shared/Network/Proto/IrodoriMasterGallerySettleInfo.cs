// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriMasterGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from IrodoriMasterGallerySettleInfo.proto</summary>
  public static partial class IrodoriMasterGallerySettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for IrodoriMasterGallerySettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IrodoriMasterGallerySettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRJcm9kb3JpTWFzdGVyR2FsbGVyeVNldHRsZUluZm8ucHJvdG8SH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8aF0dhbGxlcnlTdG9wUmVhc29u",
            "LnByb3RvIrEBCh5Jcm9kb3JpTWFzdGVyR2FsbGVyeVNldHRsZUluZm8SQgoG",
            "cmVhc29uGAogASgOMjIuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "by5HYWxsZXJ5U3RvcFJlYXNvbhIRCglkaWZmaWN1bHQYAiABKA0SEwoLZmlu",
            "aXNoX3RpbWUYBCABKA0SEAoIbGV2ZWxfaWQYASABKA0SEQoJaXNfZmluaXNo",
            "GAMgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GalleryStopReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.IrodoriMasterGallerySettleInfo), global::Weedwacker.Shared.Network.Proto.IrodoriMasterGallerySettleInfo.Parser, new[]{ "Reason", "Difficult", "FinishTime", "LevelId", "IsFinish" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IrodoriMasterGallerySettleInfo : pb::IMessage<IrodoriMasterGallerySettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IrodoriMasterGallerySettleInfo> _parser = new pb::MessageParser<IrodoriMasterGallerySettleInfo>(() => new IrodoriMasterGallerySettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IrodoriMasterGallerySettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.IrodoriMasterGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriMasterGallerySettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriMasterGallerySettleInfo(IrodoriMasterGallerySettleInfo other) : this() {
      reason_ = other.reason_;
      difficult_ = other.difficult_;
      finishTime_ = other.finishTime_;
      levelId_ = other.levelId_;
      isFinish_ = other.isFinish_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriMasterGallerySettleInfo Clone() {
      return new IrodoriMasterGallerySettleInfo(this);
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.GalleryStopReason reason_ = global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GalleryStopReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "difficult" field.</summary>
    public const int DifficultFieldNumber = 2;
    private uint difficult_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Difficult {
      get { return difficult_; }
      set {
        difficult_ = value;
      }
    }

    /// <summary>Field number for the "finish_time" field.</summary>
    public const int FinishTimeFieldNumber = 4;
    private uint finishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishTime {
      get { return finishTime_; }
      set {
        finishTime_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 1;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 3;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IrodoriMasterGallerySettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IrodoriMasterGallerySettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reason != other.Reason) return false;
      if (Difficult != other.Difficult) return false;
      if (FinishTime != other.FinishTime) return false;
      if (LevelId != other.LevelId) return false;
      if (IsFinish != other.IsFinish) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) hash ^= Reason.GetHashCode();
      if (Difficult != 0) hash ^= Difficult.GetHashCode();
      if (FinishTime != 0) hash ^= FinishTime.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
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
      if (LevelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LevelId);
      }
      if (Difficult != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Difficult);
      }
      if (IsFinish != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFinish);
      }
      if (FinishTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FinishTime);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Reason);
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
      if (LevelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LevelId);
      }
      if (Difficult != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Difficult);
      }
      if (IsFinish != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFinish);
      }
      if (FinishTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FinishTime);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Reason);
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
      if (Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (Difficult != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Difficult);
      }
      if (FinishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishTime);
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IrodoriMasterGallerySettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) {
        Reason = other.Reason;
      }
      if (other.Difficult != 0) {
        Difficult = other.Difficult;
      }
      if (other.FinishTime != 0) {
        FinishTime = other.FinishTime;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 16: {
            Difficult = input.ReadUInt32();
            break;
          }
          case 24: {
            IsFinish = input.ReadBool();
            break;
          }
          case 32: {
            FinishTime = input.ReadUInt32();
            break;
          }
          case 80: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GalleryStopReason) input.ReadEnum();
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 16: {
            Difficult = input.ReadUInt32();
            break;
          }
          case 24: {
            IsFinish = input.ReadBool();
            break;
          }
          case 32: {
            FinishTime = input.ReadUInt32();
            break;
          }
          case 80: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GalleryStopReason) input.ReadEnum();
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
