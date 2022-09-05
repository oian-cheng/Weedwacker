// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeFurnitureData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomeFurnitureData.proto</summary>
  public static partial class HomeFurnitureDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeFurnitureData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeFurnitureDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdIb21lRnVybml0dXJlRGF0YS5wcm90bxoMVmVjdG9yLnByb3RvIqABChFI",
            "b21lRnVybml0dXJlRGF0YRIPCgd2ZXJzaW9uGAYgASgNEh4KFnBhcmVudF9m",
            "dXJuaXR1cmVfaW5kZXgYAyABKAUSFAoMZnVybml0dXJlX2lkGAQgASgNEgwK",
            "BGd1aWQYCSABKA0SGgoJc3Bhd25fcm90GAogASgLMgcuVmVjdG9yEhoKCXNw",
            "YXduX3BvcxgIIAEoCzIHLlZlY3RvckIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeFurnitureData), global::Weedwacker.Server.Proto.HomeFurnitureData.Parser, new[]{ "Version", "ParentFurnitureIndex", "FurnitureId", "Guid", "SpawnRot", "SpawnPos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeFurnitureData : pb::IMessage<HomeFurnitureData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeFurnitureData> _parser = new pb::MessageParser<HomeFurnitureData>(() => new HomeFurnitureData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeFurnitureData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomeFurnitureDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureData(HomeFurnitureData other) : this() {
      version_ = other.version_;
      parentFurnitureIndex_ = other.parentFurnitureIndex_;
      furnitureId_ = other.furnitureId_;
      guid_ = other.guid_;
      spawnRot_ = other.spawnRot_ != null ? other.spawnRot_.Clone() : null;
      spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureData Clone() {
      return new HomeFurnitureData(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 6;
    private uint version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "parent_furniture_index" field.</summary>
    public const int ParentFurnitureIndexFieldNumber = 3;
    private int parentFurnitureIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ParentFurnitureIndex {
      get { return parentFurnitureIndex_; }
      set {
        parentFurnitureIndex_ = value;
      }
    }

    /// <summary>Field number for the "furniture_id" field.</summary>
    public const int FurnitureIdFieldNumber = 4;
    private uint furnitureId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FurnitureId {
      get { return furnitureId_; }
      set {
        furnitureId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 9;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "spawn_rot" field.</summary>
    public const int SpawnRotFieldNumber = 10;
    private global::Weedwacker.Server.Proto.Vector spawnRot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector SpawnRot {
      get { return spawnRot_; }
      set {
        spawnRot_ = value;
      }
    }

    /// <summary>Field number for the "spawn_pos" field.</summary>
    public const int SpawnPosFieldNumber = 8;
    private global::Weedwacker.Server.Proto.Vector spawnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector SpawnPos {
      get { return spawnPos_; }
      set {
        spawnPos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeFurnitureData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeFurnitureData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (ParentFurnitureIndex != other.ParentFurnitureIndex) return false;
      if (FurnitureId != other.FurnitureId) return false;
      if (Guid != other.Guid) return false;
      if (!object.Equals(SpawnRot, other.SpawnRot)) return false;
      if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Version != 0) hash ^= Version.GetHashCode();
      if (ParentFurnitureIndex != 0) hash ^= ParentFurnitureIndex.GetHashCode();
      if (FurnitureId != 0) hash ^= FurnitureId.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
      if (spawnRot_ != null) hash ^= SpawnRot.GetHashCode();
      if (spawnPos_ != null) hash ^= SpawnPos.GetHashCode();
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
      if (ParentFurnitureIndex != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ParentFurnitureIndex);
      }
      if (FurnitureId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FurnitureId);
      }
      if (Version != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Version);
      }
      if (spawnPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SpawnPos);
      }
      if (Guid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Guid);
      }
      if (spawnRot_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(SpawnRot);
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
      if (ParentFurnitureIndex != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ParentFurnitureIndex);
      }
      if (FurnitureId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FurnitureId);
      }
      if (Version != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Version);
      }
      if (spawnPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SpawnPos);
      }
      if (Guid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Guid);
      }
      if (spawnRot_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(SpawnRot);
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
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      if (ParentFurnitureIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ParentFurnitureIndex);
      }
      if (FurnitureId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FurnitureId);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (spawnRot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnRot);
      }
      if (spawnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnPos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeFurnitureData other) {
      if (other == null) {
        return;
      }
      if (other.Version != 0) {
        Version = other.Version;
      }
      if (other.ParentFurnitureIndex != 0) {
        ParentFurnitureIndex = other.ParentFurnitureIndex;
      }
      if (other.FurnitureId != 0) {
        FurnitureId = other.FurnitureId;
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
      }
      if (other.spawnRot_ != null) {
        if (spawnRot_ == null) {
          SpawnRot = new global::Weedwacker.Server.Proto.Vector();
        }
        SpawnRot.MergeFrom(other.SpawnRot);
      }
      if (other.spawnPos_ != null) {
        if (spawnPos_ == null) {
          SpawnPos = new global::Weedwacker.Server.Proto.Vector();
        }
        SpawnPos.MergeFrom(other.SpawnPos);
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
            ParentFurnitureIndex = input.ReadInt32();
            break;
          }
          case 32: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 48: {
            Version = input.ReadUInt32();
            break;
          }
          case 66: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 72: {
            Guid = input.ReadUInt32();
            break;
          }
          case 82: {
            if (spawnRot_ == null) {
              SpawnRot = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(SpawnRot);
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
            ParentFurnitureIndex = input.ReadInt32();
            break;
          }
          case 32: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 48: {
            Version = input.ReadUInt32();
            break;
          }
          case 66: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 72: {
            Guid = input.ReadUInt32();
            break;
          }
          case 82: {
            if (spawnRot_ == null) {
              SpawnRot = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(SpawnRot);
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
