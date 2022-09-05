// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonsterAlertChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from MonsterAlertChangeNotify.proto</summary>
  public static partial class MonsterAlertChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MonsterAlertChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterAlertChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Nb25zdGVyQWxlcnRDaGFuZ2VOb3RpZnkucHJvdG8iYwoYTW9uc3RlckFs",
            "ZXJ0Q2hhbmdlTm90aWZ5EhgKEGF2YXRhcl9lbnRpdHlfaWQYDyABKA0SGwoT",
            "bW9uc3Rlcl9lbnRpdHlfbGlzdBgFIAMoDRIQCghpc19hbGVydBgNIAEoDUIa",
            "qgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.MonsterAlertChangeNotify), global::Weedwacker.Server.Proto.MonsterAlertChangeNotify.Parser, new[]{ "AvatarEntityId", "MonsterEntityList", "IsAlert" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 363
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class MonsterAlertChangeNotify : pb::IMessage<MonsterAlertChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonsterAlertChangeNotify> _parser = new pb::MessageParser<MonsterAlertChangeNotify>(() => new MonsterAlertChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonsterAlertChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.MonsterAlertChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterAlertChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterAlertChangeNotify(MonsterAlertChangeNotify other) : this() {
      avatarEntityId_ = other.avatarEntityId_;
      monsterEntityList_ = other.monsterEntityList_.Clone();
      isAlert_ = other.isAlert_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterAlertChangeNotify Clone() {
      return new MonsterAlertChangeNotify(this);
    }

    /// <summary>Field number for the "avatar_entity_id" field.</summary>
    public const int AvatarEntityIdFieldNumber = 15;
    private uint avatarEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarEntityId {
      get { return avatarEntityId_; }
      set {
        avatarEntityId_ = value;
      }
    }

    /// <summary>Field number for the "monster_entity_list" field.</summary>
    public const int MonsterEntityListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_monsterEntityList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> monsterEntityList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MonsterEntityList {
      get { return monsterEntityList_; }
    }

    /// <summary>Field number for the "is_alert" field.</summary>
    public const int IsAlertFieldNumber = 13;
    private uint isAlert_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IsAlert {
      get { return isAlert_; }
      set {
        isAlert_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonsterAlertChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonsterAlertChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarEntityId != other.AvatarEntityId) return false;
      if(!monsterEntityList_.Equals(other.monsterEntityList_)) return false;
      if (IsAlert != other.IsAlert) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarEntityId != 0) hash ^= AvatarEntityId.GetHashCode();
      hash ^= monsterEntityList_.GetHashCode();
      if (IsAlert != 0) hash ^= IsAlert.GetHashCode();
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
      monsterEntityList_.WriteTo(output, _repeated_monsterEntityList_codec);
      if (IsAlert != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(IsAlert);
      }
      if (AvatarEntityId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AvatarEntityId);
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
      monsterEntityList_.WriteTo(ref output, _repeated_monsterEntityList_codec);
      if (IsAlert != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(IsAlert);
      }
      if (AvatarEntityId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AvatarEntityId);
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
      if (AvatarEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarEntityId);
      }
      size += monsterEntityList_.CalculateSize(_repeated_monsterEntityList_codec);
      if (IsAlert != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IsAlert);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonsterAlertChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.AvatarEntityId != 0) {
        AvatarEntityId = other.AvatarEntityId;
      }
      monsterEntityList_.Add(other.monsterEntityList_);
      if (other.IsAlert != 0) {
        IsAlert = other.IsAlert;
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
          case 42:
          case 40: {
            monsterEntityList_.AddEntriesFrom(input, _repeated_monsterEntityList_codec);
            break;
          }
          case 104: {
            IsAlert = input.ReadUInt32();
            break;
          }
          case 120: {
            AvatarEntityId = input.ReadUInt32();
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
          case 42:
          case 40: {
            monsterEntityList_.AddEntriesFrom(ref input, _repeated_monsterEntityList_codec);
            break;
          }
          case 104: {
            IsAlert = input.ReadUInt32();
            break;
          }
          case 120: {
            AvatarEntityId = input.ReadUInt32();
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
