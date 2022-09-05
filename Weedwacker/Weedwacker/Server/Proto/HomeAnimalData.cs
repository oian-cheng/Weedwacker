// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeAnimalData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomeAnimalData.proto</summary>
  public static partial class HomeAnimalDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeAnimalData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeAnimalDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRIb21lQW5pbWFsRGF0YS5wcm90bxoMVmVjdG9yLnByb3RvIl4KDkhvbWVB",
            "bmltYWxEYXRhEhoKCXNwYXduX3JvdBgKIAEoCzIHLlZlY3RvchIUCgxmdXJu",
            "aXR1cmVfaWQYBSABKA0SGgoJc3Bhd25fcG9zGAYgASgLMgcuVmVjdG9yQhqq",
            "AhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeAnimalData), global::Weedwacker.Server.Proto.HomeAnimalData.Parser, new[]{ "SpawnRot", "FurnitureId", "SpawnPos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeAnimalData : pb::IMessage<HomeAnimalData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeAnimalData> _parser = new pb::MessageParser<HomeAnimalData>(() => new HomeAnimalData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeAnimalData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomeAnimalDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAnimalData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAnimalData(HomeAnimalData other) : this() {
      spawnRot_ = other.spawnRot_ != null ? other.spawnRot_.Clone() : null;
      furnitureId_ = other.furnitureId_;
      spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAnimalData Clone() {
      return new HomeAnimalData(this);
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

    /// <summary>Field number for the "furniture_id" field.</summary>
    public const int FurnitureIdFieldNumber = 5;
    private uint furnitureId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FurnitureId {
      get { return furnitureId_; }
      set {
        furnitureId_ = value;
      }
    }

    /// <summary>Field number for the "spawn_pos" field.</summary>
    public const int SpawnPosFieldNumber = 6;
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
      return Equals(other as HomeAnimalData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeAnimalData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SpawnRot, other.SpawnRot)) return false;
      if (FurnitureId != other.FurnitureId) return false;
      if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (spawnRot_ != null) hash ^= SpawnRot.GetHashCode();
      if (FurnitureId != 0) hash ^= FurnitureId.GetHashCode();
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
      if (FurnitureId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FurnitureId);
      }
      if (spawnPos_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SpawnPos);
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
      if (FurnitureId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FurnitureId);
      }
      if (spawnPos_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SpawnPos);
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
      if (spawnRot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnRot);
      }
      if (FurnitureId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FurnitureId);
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
    public void MergeFrom(HomeAnimalData other) {
      if (other == null) {
        return;
      }
      if (other.spawnRot_ != null) {
        if (spawnRot_ == null) {
          SpawnRot = new global::Weedwacker.Server.Proto.Vector();
        }
        SpawnRot.MergeFrom(other.SpawnRot);
      }
      if (other.FurnitureId != 0) {
        FurnitureId = other.FurnitureId;
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
          case 40: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
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
          case 40: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
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
