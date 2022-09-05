// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Achievement.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Achievement.proto</summary>
  public static partial class AchievementReflection {

    #region Descriptor
    /// <summary>File descriptor for Achievement.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AchievementReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBY2hpZXZlbWVudC5wcm90byLpAQoLQWNoaWV2ZW1lbnQSGAoQZmluaXNo",
            "X3RpbWVzdGFtcBgLIAEoDRIjCgZzdGF0dXMYDSABKA4yEy5BY2hpZXZlbWVu",
            "dC5TdGF0dXMSFAoMY3VyX3Byb2dyZXNzGAwgASgNEgoKAmlkGA4gASgNEhYK",
            "DnRvdGFsX3Byb2dyZXNzGAggASgNImEKBlN0YXR1cxISCg5TVEFUVVNfSU5W",
            "QUxJRBAAEhUKEVNUQVRVU19VTkZJTklTSEVEEAESEwoPU1RBVFVTX0ZJTklT",
            "SEVEEAISFwoTU1RBVFVTX1JFV0FSRF9UQUtFThADQhqqAhdXZWVkd2Fja2Vy",
            "LlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Achievement), global::Weedwacker.Server.Proto.Achievement.Parser, new[]{ "FinishTimestamp", "Status", "CurProgress", "Id", "TotalProgress" }, null, new[]{ typeof(global::Weedwacker.Server.Proto.Achievement.Types.Status) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Achievement : pb::IMessage<Achievement>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Achievement> _parser = new pb::MessageParser<Achievement>(() => new Achievement());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Achievement> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.AchievementReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Achievement() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Achievement(Achievement other) : this() {
      finishTimestamp_ = other.finishTimestamp_;
      status_ = other.status_;
      curProgress_ = other.curProgress_;
      id_ = other.id_;
      totalProgress_ = other.totalProgress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Achievement Clone() {
      return new Achievement(this);
    }

    /// <summary>Field number for the "finish_timestamp" field.</summary>
    public const int FinishTimestampFieldNumber = 11;
    private uint finishTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishTimestamp {
      get { return finishTimestamp_; }
      set {
        finishTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 13;
    private global::Weedwacker.Server.Proto.Achievement.Types.Status status_ = global::Weedwacker.Server.Proto.Achievement.Types.Status.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Achievement.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "cur_progress" field.</summary>
    public const int CurProgressFieldNumber = 12;
    private uint curProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurProgress {
      get { return curProgress_; }
      set {
        curProgress_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 14;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "total_progress" field.</summary>
    public const int TotalProgressFieldNumber = 8;
    private uint totalProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalProgress {
      get { return totalProgress_; }
      set {
        totalProgress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Achievement);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Achievement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FinishTimestamp != other.FinishTimestamp) return false;
      if (Status != other.Status) return false;
      if (CurProgress != other.CurProgress) return false;
      if (Id != other.Id) return false;
      if (TotalProgress != other.TotalProgress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FinishTimestamp != 0) hash ^= FinishTimestamp.GetHashCode();
      if (Status != global::Weedwacker.Server.Proto.Achievement.Types.Status.Invalid) hash ^= Status.GetHashCode();
      if (CurProgress != 0) hash ^= CurProgress.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (TotalProgress != 0) hash ^= TotalProgress.GetHashCode();
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
      if (TotalProgress != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TotalProgress);
      }
      if (FinishTimestamp != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FinishTimestamp);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurProgress);
      }
      if (Status != global::Weedwacker.Server.Proto.Achievement.Types.Status.Invalid) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Status);
      }
      if (Id != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Id);
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
      if (TotalProgress != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TotalProgress);
      }
      if (FinishTimestamp != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FinishTimestamp);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurProgress);
      }
      if (Status != global::Weedwacker.Server.Proto.Achievement.Types.Status.Invalid) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Status);
      }
      if (Id != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Id);
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
      if (FinishTimestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishTimestamp);
      }
      if (Status != global::Weedwacker.Server.Proto.Achievement.Types.Status.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (CurProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurProgress);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (TotalProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalProgress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Achievement other) {
      if (other == null) {
        return;
      }
      if (other.FinishTimestamp != 0) {
        FinishTimestamp = other.FinishTimestamp;
      }
      if (other.Status != global::Weedwacker.Server.Proto.Achievement.Types.Status.Invalid) {
        Status = other.Status;
      }
      if (other.CurProgress != 0) {
        CurProgress = other.CurProgress;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.TotalProgress != 0) {
        TotalProgress = other.TotalProgress;
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
          case 64: {
            TotalProgress = input.ReadUInt32();
            break;
          }
          case 88: {
            FinishTimestamp = input.ReadUInt32();
            break;
          }
          case 96: {
            CurProgress = input.ReadUInt32();
            break;
          }
          case 104: {
            Status = (global::Weedwacker.Server.Proto.Achievement.Types.Status) input.ReadEnum();
            break;
          }
          case 112: {
            Id = input.ReadUInt32();
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
          case 64: {
            TotalProgress = input.ReadUInt32();
            break;
          }
          case 88: {
            FinishTimestamp = input.ReadUInt32();
            break;
          }
          case 96: {
            CurProgress = input.ReadUInt32();
            break;
          }
          case 104: {
            Status = (global::Weedwacker.Server.Proto.Achievement.Types.Status) input.ReadEnum();
            break;
          }
          case 112: {
            Id = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Achievement message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("STATUS_INVALID")] Invalid = 0,
        [pbr::OriginalName("STATUS_UNFINISHED")] Unfinished = 1,
        [pbr::OriginalName("STATUS_FINISHED")] Finished = 2,
        [pbr::OriginalName("STATUS_REWARD_TAKEN")] RewardTaken = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
