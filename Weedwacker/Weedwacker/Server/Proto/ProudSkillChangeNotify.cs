// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProudSkillChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ProudSkillChangeNotify.proto</summary>
  public static partial class ProudSkillChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ProudSkillChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProudSkillChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQcm91ZFNraWxsQ2hhbmdlTm90aWZ5LnByb3RvInIKFlByb3VkU2tpbGxD",
            "aGFuZ2VOb3RpZnkSEwoLYXZhdGFyX2d1aWQYCyABKAQSEQoJZW50aXR5X2lk",
            "GAQgASgNEhYKDnNraWxsX2RlcG90X2lkGAggASgNEhgKEHByb3VkX3NraWxs",
            "X2xpc3QYDCADKA1CGqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ProudSkillChangeNotify), global::Weedwacker.Server.Proto.ProudSkillChangeNotify.Parser, new[]{ "AvatarGuid", "EntityId", "SkillDepotId", "ProudSkillList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1031
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ProudSkillChangeNotify : pb::IMessage<ProudSkillChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProudSkillChangeNotify> _parser = new pb::MessageParser<ProudSkillChangeNotify>(() => new ProudSkillChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProudSkillChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ProudSkillChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillChangeNotify(ProudSkillChangeNotify other) : this() {
      avatarGuid_ = other.avatarGuid_;
      entityId_ = other.entityId_;
      skillDepotId_ = other.skillDepotId_;
      proudSkillList_ = other.proudSkillList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillChangeNotify Clone() {
      return new ProudSkillChangeNotify(this);
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 11;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 4;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "skill_depot_id" field.</summary>
    public const int SkillDepotIdFieldNumber = 8;
    private uint skillDepotId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillDepotId {
      get { return skillDepotId_; }
      set {
        skillDepotId_ = value;
      }
    }

    /// <summary>Field number for the "proud_skill_list" field.</summary>
    public const int ProudSkillListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_proudSkillList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> proudSkillList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ProudSkillList {
      get { return proudSkillList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProudSkillChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProudSkillChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarGuid != other.AvatarGuid) return false;
      if (EntityId != other.EntityId) return false;
      if (SkillDepotId != other.SkillDepotId) return false;
      if(!proudSkillList_.Equals(other.proudSkillList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (SkillDepotId != 0) hash ^= SkillDepotId.GetHashCode();
      hash ^= proudSkillList_.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (SkillDepotId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SkillDepotId);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(AvatarGuid);
      }
      proudSkillList_.WriteTo(output, _repeated_proudSkillList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (SkillDepotId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SkillDepotId);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(AvatarGuid);
      }
      proudSkillList_.WriteTo(ref output, _repeated_proudSkillList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (SkillDepotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillDepotId);
      }
      size += proudSkillList_.CalculateSize(_repeated_proudSkillList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProudSkillChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.SkillDepotId != 0) {
        SkillDepotId = other.SkillDepotId;
      }
      proudSkillList_.Add(other.proudSkillList_);
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
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 64: {
            SkillDepotId = input.ReadUInt32();
            break;
          }
          case 88: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 98:
          case 96: {
            proudSkillList_.AddEntriesFrom(input, _repeated_proudSkillList_codec);
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
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 64: {
            SkillDepotId = input.ReadUInt32();
            break;
          }
          case 88: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 98:
          case 96: {
            proudSkillList_.AddEntriesFrom(ref input, _repeated_proudSkillList_codec);
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
