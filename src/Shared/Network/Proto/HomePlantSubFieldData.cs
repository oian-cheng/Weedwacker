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
namespace Weedwacker.Shared.Network.Proto {

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
            "ChtIb21lUGxhbnRTdWJGaWVsZERhdGEucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aGkhvbWVQbGFudEZpZWxkU3RhdHVzLnByb3Rv",
            "IsgBChVIb21lUGxhbnRTdWJGaWVsZERhdGESSwoMZmllbGRfc3RhdHVzGAUg",
            "ASgOMjUuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5Ib21lUGxh",
            "bnRGaWVsZFN0YXR1cxIbChNVbmszMzAwX0lFTEhFQUFNQUtHGAcgASgNEhYK",
            "DmVudGl0eV9pZF9saXN0GAwgAygNEhAKCGVuZF90aW1lGAYgASgHEhsKE1Vu",
            "azMzMDBfR0FKSExHS0xCQksYCSABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomePlantSubFieldData), global::Weedwacker.Shared.Network.Proto.HomePlantSubFieldData.Parser, new[]{ "FieldStatus", "Unk3300IELHEAAMAKG", "EntityIdList", "EndTime", "Unk3300GAJHLGKLBBK" }, null, null, null, null)
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
      get { return global::Weedwacker.Shared.Network.Proto.HomePlantSubFieldDataReflection.Descriptor.MessageTypes[0]; }
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
      fieldStatus_ = other.fieldStatus_;
      unk3300IELHEAAMAKG_ = other.unk3300IELHEAAMAKG_;
      entityIdList_ = other.entityIdList_.Clone();
      endTime_ = other.endTime_;
      unk3300GAJHLGKLBBK_ = other.unk3300GAJHLGKLBBK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomePlantSubFieldData Clone() {
      return new HomePlantSubFieldData(this);
    }

    /// <summary>Field number for the "field_status" field.</summary>
    public const int FieldStatusFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus fieldStatus_ = global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus.StatueNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus FieldStatus {
      get { return fieldStatus_; }
      set {
        fieldStatus_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_IELHEAAMAKG" field.</summary>
    public const int Unk3300IELHEAAMAKGFieldNumber = 7;
    private uint unk3300IELHEAAMAKG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IELHEAAMAKG {
      get { return unk3300IELHEAAMAKG_; }
      set {
        unk3300IELHEAAMAKG_ = value;
      }
    }

    /// <summary>Field number for the "entity_id_list" field.</summary>
    public const int EntityIdListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_entityIdList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> entityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EntityIdList {
      get { return entityIdList_; }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 6;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GAJHLGKLBBK" field.</summary>
    public const int Unk3300GAJHLGKLBBKFieldNumber = 9;
    private uint unk3300GAJHLGKLBBK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GAJHLGKLBBK {
      get { return unk3300GAJHLGKLBBK_; }
      set {
        unk3300GAJHLGKLBBK_ = value;
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
      if (FieldStatus != other.FieldStatus) return false;
      if (Unk3300IELHEAAMAKG != other.Unk3300IELHEAAMAKG) return false;
      if(!entityIdList_.Equals(other.entityIdList_)) return false;
      if (EndTime != other.EndTime) return false;
      if (Unk3300GAJHLGKLBBK != other.Unk3300GAJHLGKLBBK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FieldStatus != global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus.StatueNone) hash ^= FieldStatus.GetHashCode();
      if (Unk3300IELHEAAMAKG != 0) hash ^= Unk3300IELHEAAMAKG.GetHashCode();
      hash ^= entityIdList_.GetHashCode();
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      if (Unk3300GAJHLGKLBBK != 0) hash ^= Unk3300GAJHLGKLBBK.GetHashCode();
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
      if (FieldStatus != global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus.StatueNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) FieldStatus);
      }
      if (EndTime != 0) {
        output.WriteRawTag(53);
        output.WriteFixed32(EndTime);
      }
      if (Unk3300IELHEAAMAKG != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300IELHEAAMAKG);
      }
      if (Unk3300GAJHLGKLBBK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300GAJHLGKLBBK);
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
      if (FieldStatus != global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus.StatueNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) FieldStatus);
      }
      if (EndTime != 0) {
        output.WriteRawTag(53);
        output.WriteFixed32(EndTime);
      }
      if (Unk3300IELHEAAMAKG != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300IELHEAAMAKG);
      }
      if (Unk3300GAJHLGKLBBK != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300GAJHLGKLBBK);
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
      if (FieldStatus != global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus.StatueNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldStatus);
      }
      if (Unk3300IELHEAAMAKG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IELHEAAMAKG);
      }
      size += entityIdList_.CalculateSize(_repeated_entityIdList_codec);
      if (EndTime != 0) {
        size += 1 + 4;
      }
      if (Unk3300GAJHLGKLBBK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GAJHLGKLBBK);
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
      if (other.FieldStatus != global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus.StatueNone) {
        FieldStatus = other.FieldStatus;
      }
      if (other.Unk3300IELHEAAMAKG != 0) {
        Unk3300IELHEAAMAKG = other.Unk3300IELHEAAMAKG;
      }
      entityIdList_.Add(other.entityIdList_);
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
      }
      if (other.Unk3300GAJHLGKLBBK != 0) {
        Unk3300GAJHLGKLBBK = other.Unk3300GAJHLGKLBBK;
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
            FieldStatus = (global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus) input.ReadEnum();
            break;
          }
          case 53: {
            EndTime = input.ReadFixed32();
            break;
          }
          case 56: {
            Unk3300IELHEAAMAKG = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300GAJHLGKLBBK = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
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
          case 40: {
            FieldStatus = (global::Weedwacker.Shared.Network.Proto.HomePlantFieldStatus) input.ReadEnum();
            break;
          }
          case 53: {
            EndTime = input.ReadFixed32();
            break;
          }
          case 56: {
            Unk3300IELHEAAMAKG = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300GAJHLGKLBBK = input.ReadUInt32();
            break;
          }
          case 98:
          case 96: {
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
