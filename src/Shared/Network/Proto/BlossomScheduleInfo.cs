// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlossomScheduleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BlossomScheduleInfo.proto</summary>
  public static partial class BlossomScheduleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BlossomScheduleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlossomScheduleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlCbG9zc29tU2NoZWR1bGVJbmZvLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvIooBChNCbG9zc29tU2NoZWR1bGVJbmZvEhAKCHBy",
            "b2dyZXNzGAEgASgNEg0KBXN0YXRlGAUgASgNEhcKD2ZpbmlzaF9wcm9ncmVz",
            "cxgKIAEoDRISCgpyZWZyZXNoX2lkGAwgASgNEhYKDmNpcmNsZV9jYW1wX2lk",
            "GAIgASgNEg0KBXJvdW5kGA4gASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BlossomScheduleInfo), global::Weedwacker.Shared.Network.Proto.BlossomScheduleInfo.Parser, new[]{ "Progress", "State", "FinishProgress", "RefreshId", "CircleCampId", "Round" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BlossomScheduleInfo : pb::IMessage<BlossomScheduleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BlossomScheduleInfo> _parser = new pb::MessageParser<BlossomScheduleInfo>(() => new BlossomScheduleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BlossomScheduleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BlossomScheduleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomScheduleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomScheduleInfo(BlossomScheduleInfo other) : this() {
      progress_ = other.progress_;
      state_ = other.state_;
      finishProgress_ = other.finishProgress_;
      refreshId_ = other.refreshId_;
      circleCampId_ = other.circleCampId_;
      round_ = other.round_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomScheduleInfo Clone() {
      return new BlossomScheduleInfo(this);
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 1;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 5;
    private uint state_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint State {
      get { return state_; }
      set {
        state_ = value;
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

    /// <summary>Field number for the "refresh_id" field.</summary>
    public const int RefreshIdFieldNumber = 12;
    private uint refreshId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RefreshId {
      get { return refreshId_; }
      set {
        refreshId_ = value;
      }
    }

    /// <summary>Field number for the "circle_camp_id" field.</summary>
    public const int CircleCampIdFieldNumber = 2;
    private uint circleCampId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CircleCampId {
      get { return circleCampId_; }
      set {
        circleCampId_ = value;
      }
    }

    /// <summary>Field number for the "round" field.</summary>
    public const int RoundFieldNumber = 14;
    private uint round_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Round {
      get { return round_; }
      set {
        round_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BlossomScheduleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BlossomScheduleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Progress != other.Progress) return false;
      if (State != other.State) return false;
      if (FinishProgress != other.FinishProgress) return false;
      if (RefreshId != other.RefreshId) return false;
      if (CircleCampId != other.CircleCampId) return false;
      if (Round != other.Round) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Progress != 0) hash ^= Progress.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      if (FinishProgress != 0) hash ^= FinishProgress.GetHashCode();
      if (RefreshId != 0) hash ^= RefreshId.GetHashCode();
      if (CircleCampId != 0) hash ^= CircleCampId.GetHashCode();
      if (Round != 0) hash ^= Round.GetHashCode();
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
      if (Progress != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Progress);
      }
      if (CircleCampId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CircleCampId);
      }
      if (State != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(State);
      }
      if (FinishProgress != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FinishProgress);
      }
      if (RefreshId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(RefreshId);
      }
      if (Round != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Round);
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
      if (Progress != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Progress);
      }
      if (CircleCampId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CircleCampId);
      }
      if (State != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(State);
      }
      if (FinishProgress != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FinishProgress);
      }
      if (RefreshId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(RefreshId);
      }
      if (Round != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Round);
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
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(State);
      }
      if (FinishProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishProgress);
      }
      if (RefreshId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RefreshId);
      }
      if (CircleCampId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CircleCampId);
      }
      if (Round != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BlossomScheduleInfo other) {
      if (other == null) {
        return;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.FinishProgress != 0) {
        FinishProgress = other.FinishProgress;
      }
      if (other.RefreshId != 0) {
        RefreshId = other.RefreshId;
      }
      if (other.CircleCampId != 0) {
        CircleCampId = other.CircleCampId;
      }
      if (other.Round != 0) {
        Round = other.Round;
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
            Progress = input.ReadUInt32();
            break;
          }
          case 16: {
            CircleCampId = input.ReadUInt32();
            break;
          }
          case 40: {
            State = input.ReadUInt32();
            break;
          }
          case 80: {
            FinishProgress = input.ReadUInt32();
            break;
          }
          case 96: {
            RefreshId = input.ReadUInt32();
            break;
          }
          case 112: {
            Round = input.ReadUInt32();
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
            Progress = input.ReadUInt32();
            break;
          }
          case 16: {
            CircleCampId = input.ReadUInt32();
            break;
          }
          case 40: {
            State = input.ReadUInt32();
            break;
          }
          case 80: {
            FinishProgress = input.ReadUInt32();
            break;
          }
          case 96: {
            RefreshId = input.ReadUInt32();
            break;
          }
          case 112: {
            Round = input.ReadUInt32();
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
