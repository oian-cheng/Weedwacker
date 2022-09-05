// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeModuleComfortInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomeModuleComfortInfo.proto</summary>
  public static partial class HomeModuleComfortInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeModuleComfortInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeModuleComfortInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtIb21lTW9kdWxlQ29tZm9ydEluZm8ucHJvdG8iegoVSG9tZU1vZHVsZUNv",
            "bWZvcnRJbmZvEhEKCW1vZHVsZV9pZBgNIAEoDRIgChhyb29tX3NjZW5lX2Nv",
            "bWZvcnRfdmFsdWUYCSABKA0SLAokd29ybGRfc2NlbmVfYmxvY2tfY29tZm9y",
            "dF92YWx1ZV9saXN0GAMgAygNQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeModuleComfortInfo), global::Weedwacker.Server.Proto.HomeModuleComfortInfo.Parser, new[]{ "ModuleId", "RoomSceneComfortValue", "WorldSceneBlockComfortValueList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeModuleComfortInfo : pb::IMessage<HomeModuleComfortInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeModuleComfortInfo> _parser = new pb::MessageParser<HomeModuleComfortInfo>(() => new HomeModuleComfortInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeModuleComfortInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomeModuleComfortInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeModuleComfortInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeModuleComfortInfo(HomeModuleComfortInfo other) : this() {
      moduleId_ = other.moduleId_;
      roomSceneComfortValue_ = other.roomSceneComfortValue_;
      worldSceneBlockComfortValueList_ = other.worldSceneBlockComfortValueList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeModuleComfortInfo Clone() {
      return new HomeModuleComfortInfo(this);
    }

    /// <summary>Field number for the "module_id" field.</summary>
    public const int ModuleIdFieldNumber = 13;
    private uint moduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModuleId {
      get { return moduleId_; }
      set {
        moduleId_ = value;
      }
    }

    /// <summary>Field number for the "room_scene_comfort_value" field.</summary>
    public const int RoomSceneComfortValueFieldNumber = 9;
    private uint roomSceneComfortValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomSceneComfortValue {
      get { return roomSceneComfortValue_; }
      set {
        roomSceneComfortValue_ = value;
      }
    }

    /// <summary>Field number for the "world_scene_block_comfort_value_list" field.</summary>
    public const int WorldSceneBlockComfortValueListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_worldSceneBlockComfortValueList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> worldSceneBlockComfortValueList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> WorldSceneBlockComfortValueList {
      get { return worldSceneBlockComfortValueList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeModuleComfortInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeModuleComfortInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModuleId != other.ModuleId) return false;
      if (RoomSceneComfortValue != other.RoomSceneComfortValue) return false;
      if(!worldSceneBlockComfortValueList_.Equals(other.worldSceneBlockComfortValueList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ModuleId != 0) hash ^= ModuleId.GetHashCode();
      if (RoomSceneComfortValue != 0) hash ^= RoomSceneComfortValue.GetHashCode();
      hash ^= worldSceneBlockComfortValueList_.GetHashCode();
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
      worldSceneBlockComfortValueList_.WriteTo(output, _repeated_worldSceneBlockComfortValueList_codec);
      if (RoomSceneComfortValue != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RoomSceneComfortValue);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ModuleId);
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
      worldSceneBlockComfortValueList_.WriteTo(ref output, _repeated_worldSceneBlockComfortValueList_codec);
      if (RoomSceneComfortValue != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RoomSceneComfortValue);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ModuleId);
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
      if (ModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModuleId);
      }
      if (RoomSceneComfortValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomSceneComfortValue);
      }
      size += worldSceneBlockComfortValueList_.CalculateSize(_repeated_worldSceneBlockComfortValueList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeModuleComfortInfo other) {
      if (other == null) {
        return;
      }
      if (other.ModuleId != 0) {
        ModuleId = other.ModuleId;
      }
      if (other.RoomSceneComfortValue != 0) {
        RoomSceneComfortValue = other.RoomSceneComfortValue;
      }
      worldSceneBlockComfortValueList_.Add(other.worldSceneBlockComfortValueList_);
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
          case 26:
          case 24: {
            worldSceneBlockComfortValueList_.AddEntriesFrom(input, _repeated_worldSceneBlockComfortValueList_codec);
            break;
          }
          case 72: {
            RoomSceneComfortValue = input.ReadUInt32();
            break;
          }
          case 104: {
            ModuleId = input.ReadUInt32();
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
          case 26:
          case 24: {
            worldSceneBlockComfortValueList_.AddEntriesFrom(ref input, _repeated_worldSceneBlockComfortValueList_codec);
            break;
          }
          case 72: {
            RoomSceneComfortValue = input.ReadUInt32();
            break;
          }
          case 104: {
            ModuleId = input.ReadUInt32();
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
