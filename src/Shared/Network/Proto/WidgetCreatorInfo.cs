// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetCreatorInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WidgetCreatorInfo.proto</summary>
  public static partial class WidgetCreatorInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetCreatorInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetCreatorInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdXaWRnZXRDcmVhdG9ySW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90bxoeV2lkZ2V0Q3JlYXRlTG9jYXRpb25JbmZvLnByb3Rv",
            "GhlXaWRnZXRDcmVhdG9yT3BUeXBlLnByb3RvIr8BChFXaWRnZXRDcmVhdG9y",
            "SW5mbxJFCgdvcF90eXBlGA4gASgOMjQuV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90by5XaWRnZXRDcmVhdG9yT3BUeXBlEhEKCWVudGl0eV9pZBgM",
            "IAEoDRJQCg1sb2NhdGlvbl9pbmZvGAkgASgLMjkuV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90by5XaWRnZXRDcmVhdGVMb2NhdGlvbkluZm9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo), global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo.Parser, new[]{ "OpType", "EntityId", "LocationInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WidgetCreatorInfo : pb::IMessage<WidgetCreatorInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetCreatorInfo> _parser = new pb::MessageParser<WidgetCreatorInfo>(() => new WidgetCreatorInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetCreatorInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCreatorInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCreatorInfo(WidgetCreatorInfo other) : this() {
      opType_ = other.opType_;
      entityId_ = other.entityId_;
      locationInfo_ = other.locationInfo_ != null ? other.locationInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCreatorInfo Clone() {
      return new WidgetCreatorInfo(this);
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType opType_ = global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 12;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "location_info" field.</summary>
    public const int LocationInfoFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo locationInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo LocationInfo {
      get { return locationInfo_; }
      set {
        locationInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetCreatorInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetCreatorInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpType != other.OpType) return false;
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(LocationInfo, other.LocationInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OpType != global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType.None) hash ^= OpType.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (locationInfo_ != null) hash ^= LocationInfo.GetHashCode();
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
      if (locationInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(LocationInfo);
      }
      if (EntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EntityId);
      }
      if (OpType != global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) OpType);
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
      if (locationInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(LocationInfo);
      }
      if (EntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EntityId);
      }
      if (OpType != global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) OpType);
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
      if (OpType != global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (locationInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocationInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetCreatorInfo other) {
      if (other == null) {
        return;
      }
      if (other.OpType != global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType.None) {
        OpType = other.OpType;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.locationInfo_ != null) {
        if (locationInfo_ == null) {
          LocationInfo = new global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo();
        }
        LocationInfo.MergeFrom(other.LocationInfo);
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
          case 74: {
            if (locationInfo_ == null) {
              LocationInfo = new global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo();
            }
            input.ReadMessage(LocationInfo);
            break;
          }
          case 96: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 112: {
            OpType = (global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType) input.ReadEnum();
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
          case 74: {
            if (locationInfo_ == null) {
              LocationInfo = new global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo();
            }
            input.ReadMessage(LocationInfo);
            break;
          }
          case 96: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 112: {
            OpType = (global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType) input.ReadEnum();
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
