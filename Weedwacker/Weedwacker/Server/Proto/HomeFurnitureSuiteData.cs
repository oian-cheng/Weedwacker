// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeFurnitureSuiteData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomeFurnitureSuiteData.proto</summary>
  public static partial class HomeFurnitureSuiteDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeFurnitureSuiteData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeFurnitureSuiteDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxIb21lRnVybml0dXJlU3VpdGVEYXRhLnByb3RvGgxWZWN0b3IucHJvdG8i",
            "lAEKFkhvbWVGdXJuaXR1cmVTdWl0ZURhdGESFwoPaXNfYWxsb3dfc3VtbW9u",
            "GAogASgIEhAKCHN1aXRlX2lkGAYgASgNEhoKCXNwYXduX3BvcxgIIAEoCzIH",
            "LlZlY3RvchIMCgRndWlkGA0gASgNEiUKHWluY2x1ZGVkX2Z1cm5pdHVyZV9p",
            "bmRleF9saXN0GAEgAygFQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeFurnitureSuiteData), global::Weedwacker.Server.Proto.HomeFurnitureSuiteData.Parser, new[]{ "IsAllowSummon", "SuiteId", "SpawnPos", "Guid", "IncludedFurnitureIndexList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeFurnitureSuiteData : pb::IMessage<HomeFurnitureSuiteData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeFurnitureSuiteData> _parser = new pb::MessageParser<HomeFurnitureSuiteData>(() => new HomeFurnitureSuiteData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeFurnitureSuiteData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomeFurnitureSuiteDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureSuiteData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureSuiteData(HomeFurnitureSuiteData other) : this() {
      isAllowSummon_ = other.isAllowSummon_;
      suiteId_ = other.suiteId_;
      spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
      guid_ = other.guid_;
      includedFurnitureIndexList_ = other.includedFurnitureIndexList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureSuiteData Clone() {
      return new HomeFurnitureSuiteData(this);
    }

    /// <summary>Field number for the "is_allow_summon" field.</summary>
    public const int IsAllowSummonFieldNumber = 10;
    private bool isAllowSummon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAllowSummon {
      get { return isAllowSummon_; }
      set {
        isAllowSummon_ = value;
      }
    }

    /// <summary>Field number for the "suite_id" field.</summary>
    public const int SuiteIdFieldNumber = 6;
    private uint suiteId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SuiteId {
      get { return suiteId_; }
      set {
        suiteId_ = value;
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

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 13;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "included_furniture_index_list" field.</summary>
    public const int IncludedFurnitureIndexListFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_includedFurnitureIndexList_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> includedFurnitureIndexList_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> IncludedFurnitureIndexList {
      get { return includedFurnitureIndexList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeFurnitureSuiteData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeFurnitureSuiteData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAllowSummon != other.IsAllowSummon) return false;
      if (SuiteId != other.SuiteId) return false;
      if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
      if (Guid != other.Guid) return false;
      if(!includedFurnitureIndexList_.Equals(other.includedFurnitureIndexList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAllowSummon != false) hash ^= IsAllowSummon.GetHashCode();
      if (SuiteId != 0) hash ^= SuiteId.GetHashCode();
      if (spawnPos_ != null) hash ^= SpawnPos.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
      hash ^= includedFurnitureIndexList_.GetHashCode();
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
      includedFurnitureIndexList_.WriteTo(output, _repeated_includedFurnitureIndexList_codec);
      if (SuiteId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SuiteId);
      }
      if (spawnPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SpawnPos);
      }
      if (IsAllowSummon != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsAllowSummon);
      }
      if (Guid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Guid);
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
      includedFurnitureIndexList_.WriteTo(ref output, _repeated_includedFurnitureIndexList_codec);
      if (SuiteId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SuiteId);
      }
      if (spawnPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SpawnPos);
      }
      if (IsAllowSummon != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsAllowSummon);
      }
      if (Guid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Guid);
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
      if (IsAllowSummon != false) {
        size += 1 + 1;
      }
      if (SuiteId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SuiteId);
      }
      if (spawnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnPos);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      size += includedFurnitureIndexList_.CalculateSize(_repeated_includedFurnitureIndexList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeFurnitureSuiteData other) {
      if (other == null) {
        return;
      }
      if (other.IsAllowSummon != false) {
        IsAllowSummon = other.IsAllowSummon;
      }
      if (other.SuiteId != 0) {
        SuiteId = other.SuiteId;
      }
      if (other.spawnPos_ != null) {
        if (spawnPos_ == null) {
          SpawnPos = new global::Weedwacker.Server.Proto.Vector();
        }
        SpawnPos.MergeFrom(other.SpawnPos);
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
      }
      includedFurnitureIndexList_.Add(other.includedFurnitureIndexList_);
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
          case 10:
          case 8: {
            includedFurnitureIndexList_.AddEntriesFrom(input, _repeated_includedFurnitureIndexList_codec);
            break;
          }
          case 48: {
            SuiteId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 80: {
            IsAllowSummon = input.ReadBool();
            break;
          }
          case 104: {
            Guid = input.ReadUInt32();
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
          case 10:
          case 8: {
            includedFurnitureIndexList_.AddEntriesFrom(ref input, _repeated_includedFurnitureIndexList_codec);
            break;
          }
          case 48: {
            SuiteId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 80: {
            IsAllowSummon = input.ReadBool();
            break;
          }
          case 104: {
            Guid = input.ReadUInt32();
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
