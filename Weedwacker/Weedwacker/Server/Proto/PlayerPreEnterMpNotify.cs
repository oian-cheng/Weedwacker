// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerPreEnterMpNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from PlayerPreEnterMpNotify.proto</summary>
  public static partial class PlayerPreEnterMpNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerPreEnterMpNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerPreEnterMpNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQbGF5ZXJQcmVFbnRlck1wTm90aWZ5LnByb3RvIqUBChZQbGF5ZXJQcmVF",
            "bnRlck1wTm90aWZ5EiwKBXN0YXRlGAIgASgOMh0uUGxheWVyUHJlRW50ZXJN",
            "cE5vdGlmeS5TdGF0ZRILCgN1aWQYDiABKA0SEAoIbmlja25hbWUYBiABKAki",
            "PgoFU3RhdGUSEQoNU1RBVEVfSU5WQUxJRBAAEg8KC1NUQVRFX1NUQVJUEAES",
            "EQoNU1RBVEVfVElNRU9VVBACQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify), global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Parser, new[]{ "State", "Uid", "Nickname" }, null, new[]{ typeof(global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1822
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerPreEnterMpNotify : pb::IMessage<PlayerPreEnterMpNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerPreEnterMpNotify> _parser = new pb::MessageParser<PlayerPreEnterMpNotify>(() => new PlayerPreEnterMpNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerPreEnterMpNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.PlayerPreEnterMpNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerPreEnterMpNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerPreEnterMpNotify(PlayerPreEnterMpNotify other) : this() {
      state_ = other.state_;
      uid_ = other.uid_;
      nickname_ = other.nickname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerPreEnterMpNotify Clone() {
      return new PlayerPreEnterMpNotify(this);
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State state_ = global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 14;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 6;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerPreEnterMpNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerPreEnterMpNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (State != other.State) return false;
      if (Uid != other.Uid) return false;
      if (Nickname != other.Nickname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (State != global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State.Invalid) hash ^= State.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
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
      if (State != global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State.Invalid) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
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
      if (State != global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State.Invalid) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
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
      if (State != global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerPreEnterMpNotify other) {
      if (other == null) {
        return;
      }
      if (other.State != global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State.Invalid) {
        State = other.State;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
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
            State = (global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State) input.ReadEnum();
            break;
          }
          case 50: {
            Nickname = input.ReadString();
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
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
            State = (global::Weedwacker.Server.Proto.PlayerPreEnterMpNotify.Types.State) input.ReadEnum();
            break;
          }
          case 50: {
            Nickname = input.ReadString();
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerPreEnterMpNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum State {
        [pbr::OriginalName("STATE_INVALID")] Invalid = 0,
        [pbr::OriginalName("STATE_START")] Start = 1,
        [pbr::OriginalName("STATE_TIMEOUT")] Timeout = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
