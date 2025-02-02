// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneReliquaryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneReliquaryInfo.proto</summary>
  public static partial class SceneReliquaryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneReliquaryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneReliquaryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTY2VuZVJlbGlxdWFyeUluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8iWQoSU2NlbmVSZWxpcXVhcnlJbmZvEg8KB2l0ZW1f",
            "aWQYASABKA0SDAoEZ3VpZBgCIAEoBBINCgVsZXZlbBgDIAEoDRIVCg1wcm9t",
            "b3RlX2xldmVsGAQgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneReliquaryInfo), global::Weedwacker.Shared.Network.Proto.SceneReliquaryInfo.Parser, new[]{ "ItemId", "Guid", "Level", "PromoteLevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneReliquaryInfo : pb::IMessage<SceneReliquaryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneReliquaryInfo> _parser = new pb::MessageParser<SceneReliquaryInfo>(() => new SceneReliquaryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneReliquaryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneReliquaryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneReliquaryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneReliquaryInfo(SceneReliquaryInfo other) : this() {
      itemId_ = other.itemId_;
      guid_ = other.guid_;
      level_ = other.level_;
      promoteLevel_ = other.promoteLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneReliquaryInfo Clone() {
      return new SceneReliquaryInfo(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 2;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 3;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "promote_level" field.</summary>
    public const int PromoteLevelFieldNumber = 4;
    private uint promoteLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PromoteLevel {
      get { return promoteLevel_; }
      set {
        promoteLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneReliquaryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneReliquaryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (Guid != other.Guid) return false;
      if (Level != other.Level) return false;
      if (PromoteLevel != other.PromoteLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (PromoteLevel != 0) hash ^= PromoteLevel.GetHashCode();
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
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Guid);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Level);
      }
      if (PromoteLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PromoteLevel);
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
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Guid);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Level);
      }
      if (PromoteLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PromoteLevel);
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
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (PromoteLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PromoteLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneReliquaryInfo other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.PromoteLevel != 0) {
        PromoteLevel = other.PromoteLevel;
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 16: {
            Guid = input.ReadUInt64();
            break;
          }
          case 24: {
            Level = input.ReadUInt32();
            break;
          }
          case 32: {
            PromoteLevel = input.ReadUInt32();
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
            ItemId = input.ReadUInt32();
            break;
          }
          case 16: {
            Guid = input.ReadUInt64();
            break;
          }
          case 24: {
            Level = input.ReadUInt32();
            break;
          }
          case 32: {
            PromoteLevel = input.ReadUInt32();
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
