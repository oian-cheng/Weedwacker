// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LunaRiteTakeSacrificeRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from LunaRiteTakeSacrificeRewardRsp.proto</summary>
  public static partial class LunaRiteTakeSacrificeRewardRspReflection {

    #region Descriptor
    /// <summary>File descriptor for LunaRiteTakeSacrificeRewardRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LunaRiteTakeSacrificeRewardRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRMdW5hUml0ZVRha2VTYWNyaWZpY2VSZXdhcmRSc3AucHJvdG8ikAEKHkx1",
            "bmFSaXRlVGFrZVNhY3JpZmljZVJld2FyZFJzcBINCgVpbmRleBgLIAEoDRId",
            "ChVzYWNyaWZpY2VfcmV3YXJkX2xpc3QYAiADKA0SHgoWc2FjcmlmaWNlX3Jl",
            "d2FyZF9pbmRleBgOIAEoDRIPCgdhcmVhX2lkGAYgASgNEg8KB3JldGNvZGUY",
            "DCABKAVCGqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.LunaRiteTakeSacrificeRewardRsp), global::Weedwacker.Server.Proto.LunaRiteTakeSacrificeRewardRsp.Parser, new[]{ "Index", "SacrificeRewardList", "SacrificeRewardIndex", "AreaId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8397
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class LunaRiteTakeSacrificeRewardRsp : pb::IMessage<LunaRiteTakeSacrificeRewardRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LunaRiteTakeSacrificeRewardRsp> _parser = new pb::MessageParser<LunaRiteTakeSacrificeRewardRsp>(() => new LunaRiteTakeSacrificeRewardRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LunaRiteTakeSacrificeRewardRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.LunaRiteTakeSacrificeRewardRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteTakeSacrificeRewardRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteTakeSacrificeRewardRsp(LunaRiteTakeSacrificeRewardRsp other) : this() {
      index_ = other.index_;
      sacrificeRewardList_ = other.sacrificeRewardList_.Clone();
      sacrificeRewardIndex_ = other.sacrificeRewardIndex_;
      areaId_ = other.areaId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteTakeSacrificeRewardRsp Clone() {
      return new LunaRiteTakeSacrificeRewardRsp(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 11;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "sacrifice_reward_list" field.</summary>
    public const int SacrificeRewardListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_sacrificeRewardList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> sacrificeRewardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SacrificeRewardList {
      get { return sacrificeRewardList_; }
    }

    /// <summary>Field number for the "sacrifice_reward_index" field.</summary>
    public const int SacrificeRewardIndexFieldNumber = 14;
    private uint sacrificeRewardIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SacrificeRewardIndex {
      get { return sacrificeRewardIndex_; }
      set {
        sacrificeRewardIndex_ = value;
      }
    }

    /// <summary>Field number for the "area_id" field.</summary>
    public const int AreaIdFieldNumber = 6;
    private uint areaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaId {
      get { return areaId_; }
      set {
        areaId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
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
      return Equals(other as LunaRiteTakeSacrificeRewardRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LunaRiteTakeSacrificeRewardRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if(!sacrificeRewardList_.Equals(other.sacrificeRewardList_)) return false;
      if (SacrificeRewardIndex != other.SacrificeRewardIndex) return false;
      if (AreaId != other.AreaId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      hash ^= sacrificeRewardList_.GetHashCode();
      if (SacrificeRewardIndex != 0) hash ^= SacrificeRewardIndex.GetHashCode();
      if (AreaId != 0) hash ^= AreaId.GetHashCode();
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
      sacrificeRewardList_.WriteTo(output, _repeated_sacrificeRewardList_codec);
      if (AreaId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AreaId);
      }
      if (Index != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Index);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      if (SacrificeRewardIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(SacrificeRewardIndex);
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
      sacrificeRewardList_.WriteTo(ref output, _repeated_sacrificeRewardList_codec);
      if (AreaId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AreaId);
      }
      if (Index != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Index);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      if (SacrificeRewardIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(SacrificeRewardIndex);
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
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      size += sacrificeRewardList_.CalculateSize(_repeated_sacrificeRewardList_codec);
      if (SacrificeRewardIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SacrificeRewardIndex);
      }
      if (AreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
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
    public void MergeFrom(LunaRiteTakeSacrificeRewardRsp other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      sacrificeRewardList_.Add(other.sacrificeRewardList_);
      if (other.SacrificeRewardIndex != 0) {
        SacrificeRewardIndex = other.SacrificeRewardIndex;
      }
      if (other.AreaId != 0) {
        AreaId = other.AreaId;
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
          case 18:
          case 16: {
            sacrificeRewardList_.AddEntriesFrom(input, _repeated_sacrificeRewardList_codec);
            break;
          }
          case 48: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 88: {
            Index = input.ReadUInt32();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            SacrificeRewardIndex = input.ReadUInt32();
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
          case 18:
          case 16: {
            sacrificeRewardList_.AddEntriesFrom(ref input, _repeated_sacrificeRewardList_codec);
            break;
          }
          case 48: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 88: {
            Index = input.ReadUInt32();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            SacrificeRewardIndex = input.ReadUInt32();
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
