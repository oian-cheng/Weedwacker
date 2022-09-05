// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomePlantSubFieldData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomePlantSubFieldData.proto</summary>
  public static partial class HomePlantSubFieldDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomePlantSubFieldData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomePlantSubFieldDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtIb21lUGxhbnRTdWJGaWVsZERhdGEucHJvdG8aGkhvbWVQbGFudEZpZWxk",
            "U3RhdHVzLnByb3RvIpcBChVIb21lUGxhbnRTdWJGaWVsZERhdGESFgoOZW50",
            "aXR5X2lkX2xpc3QYDyADKA0SKwoMZmllbGRfc3RhdHVzGA4gASgOMhUuSG9t",
            "ZVBsYW50RmllbGRTdGF0dXMSFgoOaG9tZV9nYXRoZXJfaWQYCSABKA0SDwoH",
            "c2VlZF9pZBgIIAEoDRIQCghlbmRfdGltZRgEIAEoB0IaqgIXV2VlZHdhY2tl",
            "ci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.HomePlantFieldStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomePlantSubFieldData), global::Weedwacker.Server.Proto.HomePlantSubFieldData.Parser, new[]{ "EntityIdList", "FieldStatus", "HomeGatherId", "SeedId", "EndTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomePlantSubFieldData : pb::IMessage<HomePlantSubFieldData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomePlantSubFieldData> _parser = new pb::MessageParser<HomePlantSubFieldData>(() => new HomePlantSubFieldData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomePlantSubFieldData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomePlantSubFieldDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomePlantSubFieldData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomePlantSubFieldData(HomePlantSubFieldData other) : this() {
      entityIdList_ = other.entityIdList_.Clone();
      fieldStatus_ = other.fieldStatus_;
      homeGatherId_ = other.homeGatherId_;
      seedId_ = other.seedId_;
      endTime_ = other.endTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomePlantSubFieldData Clone() {
      return new HomePlantSubFieldData(this);
    }

    /// <summary>Field number for the "entity_id_list" field.</summary>
    public const int EntityIdListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_entityIdList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> entityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EntityIdList {
      get { return entityIdList_; }
    }

    /// <summary>Field number for the "field_status" field.</summary>
    public const int FieldStatusFieldNumber = 14;
    private global::Weedwacker.Server.Proto.HomePlantFieldStatus fieldStatus_ = global::Weedwacker.Server.Proto.HomePlantFieldStatus.StatueNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.HomePlantFieldStatus FieldStatus {
      get { return fieldStatus_; }
      set {
        fieldStatus_ = value;
      }
    }

    /// <summary>Field number for the "home_gather_id" field.</summary>
    public const int HomeGatherIdFieldNumber = 9;
    private uint homeGatherId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HomeGatherId {
      get { return homeGatherId_; }
      set {
        homeGatherId_ = value;
      }
    }

    /// <summary>Field number for the "seed_id" field.</summary>
    public const int SeedIdFieldNumber = 8;
    private uint seedId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SeedId {
      get { return seedId_; }
      set {
        seedId_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 4;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomePlantSubFieldData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomePlantSubFieldData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entityIdList_.Equals(other.entityIdList_)) return false;
      if (FieldStatus != other.FieldStatus) return false;
      if (HomeGatherId != other.HomeGatherId) return false;
      if (SeedId != other.SeedId) return false;
      if (EndTime != other.EndTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entityIdList_.GetHashCode();
      if (FieldStatus != global::Weedwacker.Server.Proto.HomePlantFieldStatus.StatueNone) hash ^= FieldStatus.GetHashCode();
      if (HomeGatherId != 0) hash ^= HomeGatherId.GetHashCode();
      if (SeedId != 0) hash ^= SeedId.GetHashCode();
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
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
      if (EndTime != 0) {
        output.WriteRawTag(37);
        output.WriteFixed32(EndTime);
      }
      if (SeedId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SeedId);
      }
      if (HomeGatherId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HomeGatherId);
      }
      if (FieldStatus != global::Weedwacker.Server.Proto.HomePlantFieldStatus.StatueNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) FieldStatus);
      }
      entityIdList_.WriteTo(output, _repeated_entityIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EndTime != 0) {
        output.WriteRawTag(37);
        output.WriteFixed32(EndTime);
      }
      if (SeedId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SeedId);
      }
      if (HomeGatherId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HomeGatherId);
      }
      if (FieldStatus != global::Weedwacker.Server.Proto.HomePlantFieldStatus.StatueNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) FieldStatus);
      }
      entityIdList_.WriteTo(ref output, _repeated_entityIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += entityIdList_.CalculateSize(_repeated_entityIdList_codec);
      if (FieldStatus != global::Weedwacker.Server.Proto.HomePlantFieldStatus.StatueNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldStatus);
      }
      if (HomeGatherId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HomeGatherId);
      }
      if (SeedId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SeedId);
      }
      if (EndTime != 0) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomePlantSubFieldData other) {
      if (other == null) {
        return;
      }
      entityIdList_.Add(other.entityIdList_);
      if (other.FieldStatus != global::Weedwacker.Server.Proto.HomePlantFieldStatus.StatueNone) {
        FieldStatus = other.FieldStatus;
      }
      if (other.HomeGatherId != 0) {
        HomeGatherId = other.HomeGatherId;
      }
      if (other.SeedId != 0) {
        SeedId = other.SeedId;
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
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
          case 37: {
            EndTime = input.ReadFixed32();
            break;
          }
          case 64: {
            SeedId = input.ReadUInt32();
            break;
          }
          case 72: {
            HomeGatherId = input.ReadUInt32();
            break;
          }
          case 112: {
            FieldStatus = (global::Weedwacker.Server.Proto.HomePlantFieldStatus) input.ReadEnum();
            break;
          }
          case 122:
          case 120: {
            entityIdList_.AddEntriesFrom(input, _repeated_entityIdList_codec);
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
          case 37: {
            EndTime = input.ReadFixed32();
            break;
          }
          case 64: {
            SeedId = input.ReadUInt32();
            break;
          }
          case 72: {
            HomeGatherId = input.ReadUInt32();
            break;
          }
          case 112: {
            FieldStatus = (global::Weedwacker.Server.Proto.HomePlantFieldStatus) input.ReadEnum();
            break;
          }
          case 122:
          case 120: {
            entityIdList_.AddEntriesFrom(ref input, _repeated_entityIdList_codec);
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
