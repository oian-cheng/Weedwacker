// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ArenaChallengeFinishNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ArenaChallengeFinishNotify.proto</summary>
  public static partial class ArenaChallengeFinishNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ArenaChallengeFinishNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArenaChallengeFinishNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBBcmVuYUNoYWxsZW5nZUZpbmlzaE5vdGlmeS5wcm90bxomQXJlbmFDaGFs",
            "bGVuZ2VDaGlsZENoYWxsZW5nZUluZm8ucHJvdG8irAEKGkFyZW5hQ2hhbGxl",
            "bmdlRmluaXNoTm90aWZ5Eh0KFWFyZW5hX2NoYWxsZW5nZV9sZXZlbBgNIAEo",
            "DRIaChJhcmVuYV9jaGFsbGVuZ2VfaWQYAyABKA0SPwoUY2hpbGRfY2hhbGxl",
            "bmdlX2xpc3QYAiADKAsyIS5BcmVuYUNoYWxsZW5nZUNoaWxkQ2hhbGxlbmdl",
            "SW5mbxISCgppc19zdWNjZXNzGAwgASgIQhqqAhdXZWVkd2Fja2VyLlNlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.ArenaChallengeChildChallengeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ArenaChallengeFinishNotify), global::Weedwacker.Server.Proto.ArenaChallengeFinishNotify.Parser, new[]{ "ArenaChallengeLevel", "ArenaChallengeId", "ChildChallengeList", "IsSuccess" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2030
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ArenaChallengeFinishNotify : pb::IMessage<ArenaChallengeFinishNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ArenaChallengeFinishNotify> _parser = new pb::MessageParser<ArenaChallengeFinishNotify>(() => new ArenaChallengeFinishNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ArenaChallengeFinishNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ArenaChallengeFinishNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeFinishNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeFinishNotify(ArenaChallengeFinishNotify other) : this() {
      arenaChallengeLevel_ = other.arenaChallengeLevel_;
      arenaChallengeId_ = other.arenaChallengeId_;
      childChallengeList_ = other.childChallengeList_.Clone();
      isSuccess_ = other.isSuccess_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArenaChallengeFinishNotify Clone() {
      return new ArenaChallengeFinishNotify(this);
    }

    /// <summary>Field number for the "arena_challenge_level" field.</summary>
    public const int ArenaChallengeLevelFieldNumber = 13;
    private uint arenaChallengeLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ArenaChallengeLevel {
      get { return arenaChallengeLevel_; }
      set {
        arenaChallengeLevel_ = value;
      }
    }

    /// <summary>Field number for the "arena_challenge_id" field.</summary>
    public const int ArenaChallengeIdFieldNumber = 3;
    private uint arenaChallengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ArenaChallengeId {
      get { return arenaChallengeId_; }
      set {
        arenaChallengeId_ = value;
      }
    }

    /// <summary>Field number for the "child_challenge_list" field.</summary>
    public const int ChildChallengeListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ArenaChallengeChildChallengeInfo> _repeated_childChallengeList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Server.Proto.ArenaChallengeChildChallengeInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ArenaChallengeChildChallengeInfo> childChallengeList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ArenaChallengeChildChallengeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ArenaChallengeChildChallengeInfo> ChildChallengeList {
      get { return childChallengeList_; }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 12;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ArenaChallengeFinishNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ArenaChallengeFinishNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ArenaChallengeLevel != other.ArenaChallengeLevel) return false;
      if (ArenaChallengeId != other.ArenaChallengeId) return false;
      if(!childChallengeList_.Equals(other.childChallengeList_)) return false;
      if (IsSuccess != other.IsSuccess) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ArenaChallengeLevel != 0) hash ^= ArenaChallengeLevel.GetHashCode();
      if (ArenaChallengeId != 0) hash ^= ArenaChallengeId.GetHashCode();
      hash ^= childChallengeList_.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
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
      childChallengeList_.WriteTo(output, _repeated_childChallengeList_codec);
      if (ArenaChallengeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ArenaChallengeId);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsSuccess);
      }
      if (ArenaChallengeLevel != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ArenaChallengeLevel);
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
      childChallengeList_.WriteTo(ref output, _repeated_childChallengeList_codec);
      if (ArenaChallengeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ArenaChallengeId);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsSuccess);
      }
      if (ArenaChallengeLevel != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ArenaChallengeLevel);
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
      if (ArenaChallengeLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ArenaChallengeLevel);
      }
      if (ArenaChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ArenaChallengeId);
      }
      size += childChallengeList_.CalculateSize(_repeated_childChallengeList_codec);
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ArenaChallengeFinishNotify other) {
      if (other == null) {
        return;
      }
      if (other.ArenaChallengeLevel != 0) {
        ArenaChallengeLevel = other.ArenaChallengeLevel;
      }
      if (other.ArenaChallengeId != 0) {
        ArenaChallengeId = other.ArenaChallengeId;
      }
      childChallengeList_.Add(other.childChallengeList_);
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
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
          case 18: {
            childChallengeList_.AddEntriesFrom(input, _repeated_childChallengeList_codec);
            break;
          }
          case 24: {
            ArenaChallengeId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 104: {
            ArenaChallengeLevel = input.ReadUInt32();
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
          case 18: {
            childChallengeList_.AddEntriesFrom(ref input, _repeated_childChallengeList_codec);
            break;
          }
          case 24: {
            ArenaChallengeId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 104: {
            ArenaChallengeLevel = input.ReadUInt32();
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
