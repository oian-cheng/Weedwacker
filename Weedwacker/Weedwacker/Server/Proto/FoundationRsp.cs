// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FoundationRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from FoundationRsp.proto</summary>
  public static partial class FoundationRspReflection {

    #region Descriptor
    /// <summary>File descriptor for FoundationRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoundationRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNGb3VuZGF0aW9uUnNwLnByb3RvGhZGb3VuZGF0aW9uT3BUeXBlLnByb3Rv",
            "IowBCg1Gb3VuZGF0aW9uUnNwEiIKB29wX3R5cGUYDSABKA4yES5Gb3VuZGF0",
            "aW9uT3BUeXBlEhgKEGdhZGdldF9lbnRpdHlfaWQYCiABKA0SEwoLYnVpbGRp",
            "bmdfaWQYCyABKA0SFwoPcG9pbnRfY29uZmlnX2lkGAwgASgNEg8KB3JldGNv",
            "ZGUYByABKAVCGqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.FoundationOpTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.FoundationRsp), global::Weedwacker.Server.Proto.FoundationRsp.Parser, new[]{ "OpType", "GadgetEntityId", "BuildingId", "PointConfigId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 882
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class FoundationRsp : pb::IMessage<FoundationRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FoundationRsp> _parser = new pb::MessageParser<FoundationRsp>(() => new FoundationRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FoundationRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.FoundationRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationRsp(FoundationRsp other) : this() {
      opType_ = other.opType_;
      gadgetEntityId_ = other.gadgetEntityId_;
      buildingId_ = other.buildingId_;
      pointConfigId_ = other.pointConfigId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FoundationRsp Clone() {
      return new FoundationRsp(this);
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 13;
    private global::Weedwacker.Server.Proto.FoundationOpType opType_ = global::Weedwacker.Server.Proto.FoundationOpType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.FoundationOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 10;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "building_id" field.</summary>
    public const int BuildingIdFieldNumber = 11;
    private uint buildingId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuildingId {
      get { return buildingId_; }
      set {
        buildingId_ = value;
      }
    }

    /// <summary>Field number for the "point_config_id" field.</summary>
    public const int PointConfigIdFieldNumber = 12;
    private uint pointConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointConfigId {
      get { return pointConfigId_; }
      set {
        pointConfigId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FoundationRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FoundationRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpType != other.OpType) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      if (BuildingId != other.BuildingId) return false;
      if (PointConfigId != other.PointConfigId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OpType != global::Weedwacker.Server.Proto.FoundationOpType.None) hash ^= OpType.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
      if (BuildingId != 0) hash ^= BuildingId.GetHashCode();
      if (PointConfigId != 0) hash ^= PointConfigId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (BuildingId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(BuildingId);
      }
      if (PointConfigId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PointConfigId);
      }
      if (OpType != global::Weedwacker.Server.Proto.FoundationOpType.None) {
        output.WriteRawTag(104);
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
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (BuildingId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(BuildingId);
      }
      if (PointConfigId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PointConfigId);
      }
      if (OpType != global::Weedwacker.Server.Proto.FoundationOpType.None) {
        output.WriteRawTag(104);
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
      if (OpType != global::Weedwacker.Server.Proto.FoundationOpType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (BuildingId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingId);
      }
      if (PointConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointConfigId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FoundationRsp other) {
      if (other == null) {
        return;
      }
      if (other.OpType != global::Weedwacker.Server.Proto.FoundationOpType.None) {
        OpType = other.OpType;
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
      }
      if (other.BuildingId != 0) {
        BuildingId = other.BuildingId;
      }
      if (other.PointConfigId != 0) {
        PointConfigId = other.PointConfigId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            BuildingId = input.ReadUInt32();
            break;
          }
          case 96: {
            PointConfigId = input.ReadUInt32();
            break;
          }
          case 104: {
            OpType = (global::Weedwacker.Server.Proto.FoundationOpType) input.ReadEnum();
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
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 88: {
            BuildingId = input.ReadUInt32();
            break;
          }
          case 96: {
            PointConfigId = input.ReadUInt32();
            break;
          }
          case 104: {
            OpType = (global::Weedwacker.Server.Proto.FoundationOpType) input.ReadEnum();
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
