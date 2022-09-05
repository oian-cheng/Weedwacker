// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerLogoutReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from PlayerLogoutReq.proto</summary>
  public static partial class PlayerLogoutReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerLogoutReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerLogoutReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQbGF5ZXJMb2dvdXRSZXEucHJvdG8iiwIKD1BsYXllckxvZ291dFJlcRIn",
            "CgZyZWFzb24YBiABKA4yFy5QbGF5ZXJMb2dvdXRSZXEuUmVhc29uIs4BCgZS",
            "ZWFzb24SFQoRUkVBU09OX0RJU0NPTk5FQ1QQABIVChFSRUFTT05fQ0xJRU5U",
            "X1JFURABEhIKDlJFQVNPTl9USU1FT1VUEAISFAoQUkVBU09OX0FETUlOX1JF",
            "URADEhcKE1JFQVNPTl9TRVJWRVJfQ0xPU0UQBBITCg9SRUFTT05fR01fQ0xF",
            "QVIQBRIaChZSRUFTT05fUExBWUVSX1RSQU5TRkVSEAYSIgoeUkVBU09OX0NM",
            "SUVOVF9DSEVDS1NVTV9JTlZBTElEEAdCGqoCF1dlZWR3YWNrZXIuU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.PlayerLogoutReq), global::Weedwacker.Server.Proto.PlayerLogoutReq.Parser, new[]{ "Reason" }, null, new[]{ typeof(global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 107
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class PlayerLogoutReq : pb::IMessage<PlayerLogoutReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerLogoutReq> _parser = new pb::MessageParser<PlayerLogoutReq>(() => new PlayerLogoutReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerLogoutReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.PlayerLogoutReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLogoutReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLogoutReq(PlayerLogoutReq other) : this() {
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLogoutReq Clone() {
      return new PlayerLogoutReq(this);
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 6;
    private global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason reason_ = global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason.Disconnect;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerLogoutReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerLogoutReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Reason != global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason.Disconnect) hash ^= Reason.GetHashCode();
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
      if (Reason != global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason.Disconnect) {
        output.WriteRawTag(48);
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
      if (Reason != global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason.Disconnect) {
        output.WriteRawTag(48);
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
      if (Reason != global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason.Disconnect) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerLogoutReq other) {
      if (other == null) {
        return;
      }
      if (other.Reason != global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason.Disconnect) {
        Reason = other.Reason;
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
          case 48: {
            Reason = (global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason) input.ReadEnum();
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
          case 48: {
            Reason = (global::Weedwacker.Server.Proto.PlayerLogoutReq.Types.Reason) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerLogoutReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Reason {
        [pbr::OriginalName("REASON_DISCONNECT")] Disconnect = 0,
        [pbr::OriginalName("REASON_CLIENT_REQ")] ClientReq = 1,
        [pbr::OriginalName("REASON_TIMEOUT")] Timeout = 2,
        [pbr::OriginalName("REASON_ADMIN_REQ")] AdminReq = 3,
        [pbr::OriginalName("REASON_SERVER_CLOSE")] ServerClose = 4,
        [pbr::OriginalName("REASON_GM_CLEAR")] GmClear = 5,
        [pbr::OriginalName("REASON_PLAYER_TRANSFER")] PlayerTransfer = 6,
        [pbr::OriginalName("REASON_CLIENT_CHECKSUM_INVALID")] ClientChecksumInvalid = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
