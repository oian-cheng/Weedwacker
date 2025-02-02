// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerGeneralMatchDismissNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerGeneralMatchDismissNotify.proto</summary>
  public static partial class PlayerGeneralMatchDismissNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerGeneralMatchDismissNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerGeneralMatchDismissNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQbGF5ZXJHZW5lcmFsTWF0Y2hEaXNtaXNzTm90aWZ5LnByb3RvEh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGhFNYXRjaFJlYXNvbi5wcm90",
            "byKDAQofUGxheWVyR2VuZXJhbE1hdGNoRGlzbWlzc05vdGlmeRI8CgZyZWFz",
            "b24YCyABKA4yLC5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLk1h",
            "dGNoUmVhc29uEhAKCHVpZF9saXN0GAogAygNEhAKCG1hdGNoX2lkGAMgASgN",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MatchReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerGeneralMatchDismissNotify), global::Weedwacker.Shared.Network.Proto.PlayerGeneralMatchDismissNotify.Parser, new[]{ "Reason", "UidList", "MatchId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4158;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerGeneralMatchDismissNotify : pb::IMessage<PlayerGeneralMatchDismissNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerGeneralMatchDismissNotify> _parser = new pb::MessageParser<PlayerGeneralMatchDismissNotify>(() => new PlayerGeneralMatchDismissNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerGeneralMatchDismissNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerGeneralMatchDismissNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGeneralMatchDismissNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGeneralMatchDismissNotify(PlayerGeneralMatchDismissNotify other) : this() {
      reason_ = other.reason_;
      uidList_ = other.uidList_.Clone();
      matchId_ = other.matchId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGeneralMatchDismissNotify Clone() {
      return new PlayerGeneralMatchDismissNotify(this);
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.MatchReason reason_ = global::Weedwacker.Shared.Network.Proto.MatchReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MatchReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    /// <summary>Field number for the "match_id" field.</summary>
    public const int MatchIdFieldNumber = 3;
    private uint matchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MatchId {
      get { return matchId_; }
      set {
        matchId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerGeneralMatchDismissNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerGeneralMatchDismissNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reason != other.Reason) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      if (MatchId != other.MatchId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) hash ^= Reason.GetHashCode();
      hash ^= uidList_.GetHashCode();
      if (MatchId != 0) hash ^= MatchId.GetHashCode();
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
      if (MatchId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MatchId);
      }
      uidList_.WriteTo(output, _repeated_uidList_codec);
      if (Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) {
        output.WriteRawTag(88);
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
      if (MatchId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MatchId);
      }
      uidList_.WriteTo(ref output, _repeated_uidList_codec);
      if (Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) {
        output.WriteRawTag(88);
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
      if (Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (MatchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MatchId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerGeneralMatchDismissNotify other) {
      if (other == null) {
        return;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) {
        Reason = other.Reason;
      }
      uidList_.Add(other.uidList_);
      if (other.MatchId != 0) {
        MatchId = other.MatchId;
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
            MatchId = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
            break;
          }
          case 88: {
            Reason = (global::Weedwacker.Shared.Network.Proto.MatchReason) input.ReadEnum();
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
            MatchId = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
            break;
          }
          case 88: {
            Reason = (global::Weedwacker.Shared.Network.Proto.MatchReason) input.ReadEnum();
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
