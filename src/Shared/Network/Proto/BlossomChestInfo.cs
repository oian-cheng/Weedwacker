// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlossomChestInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BlossomChestInfo.proto</summary>
  public static partial class BlossomChestInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BlossomChestInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlossomChestInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZCbG9zc29tQ2hlc3RJbmZvLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvIpkBChBCbG9zc29tQ2hlc3RJbmZvEg0KBXJlc2luGAEg",
            "ASgNEhgKEHF1YWxpZnlfdWlkX2xpc3QYAiADKA0SFwoPcmVtYWluX3VpZF9s",
            "aXN0GAMgAygNEhEKCWRlYWRfdGltZRgEIAEoDRIcChRibG9zc29tX3JlZnJl",
            "c2hfdHlwZRgFIAEoDRISCgpyZWZyZXNoX2lkGAYgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BlossomChestInfo), global::Weedwacker.Shared.Network.Proto.BlossomChestInfo.Parser, new[]{ "Resin", "QualifyUidList", "RemainUidList", "DeadTime", "BlossomRefreshType", "RefreshId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BlossomChestInfo : pb::IMessage<BlossomChestInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BlossomChestInfo> _parser = new pb::MessageParser<BlossomChestInfo>(() => new BlossomChestInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BlossomChestInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BlossomChestInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomChestInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomChestInfo(BlossomChestInfo other) : this() {
      resin_ = other.resin_;
      qualifyUidList_ = other.qualifyUidList_.Clone();
      remainUidList_ = other.remainUidList_.Clone();
      deadTime_ = other.deadTime_;
      blossomRefreshType_ = other.blossomRefreshType_;
      refreshId_ = other.refreshId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomChestInfo Clone() {
      return new BlossomChestInfo(this);
    }

    /// <summary>Field number for the "resin" field.</summary>
    public const int ResinFieldNumber = 1;
    private uint resin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Resin {
      get { return resin_; }
      set {
        resin_ = value;
      }
    }

    /// <summary>Field number for the "qualify_uid_list" field.</summary>
    public const int QualifyUidListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_qualifyUidList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> qualifyUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> QualifyUidList {
      get { return qualifyUidList_; }
    }

    /// <summary>Field number for the "remain_uid_list" field.</summary>
    public const int RemainUidListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_remainUidList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> remainUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RemainUidList {
      get { return remainUidList_; }
    }

    /// <summary>Field number for the "dead_time" field.</summary>
    public const int DeadTimeFieldNumber = 4;
    private uint deadTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DeadTime {
      get { return deadTime_; }
      set {
        deadTime_ = value;
      }
    }

    /// <summary>Field number for the "blossom_refresh_type" field.</summary>
    public const int BlossomRefreshTypeFieldNumber = 5;
    private uint blossomRefreshType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BlossomRefreshType {
      get { return blossomRefreshType_; }
      set {
        blossomRefreshType_ = value;
      }
    }

    /// <summary>Field number for the "refresh_id" field.</summary>
    public const int RefreshIdFieldNumber = 6;
    private uint refreshId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RefreshId {
      get { return refreshId_; }
      set {
        refreshId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BlossomChestInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BlossomChestInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Resin != other.Resin) return false;
      if(!qualifyUidList_.Equals(other.qualifyUidList_)) return false;
      if(!remainUidList_.Equals(other.remainUidList_)) return false;
      if (DeadTime != other.DeadTime) return false;
      if (BlossomRefreshType != other.BlossomRefreshType) return false;
      if (RefreshId != other.RefreshId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Resin != 0) hash ^= Resin.GetHashCode();
      hash ^= qualifyUidList_.GetHashCode();
      hash ^= remainUidList_.GetHashCode();
      if (DeadTime != 0) hash ^= DeadTime.GetHashCode();
      if (BlossomRefreshType != 0) hash ^= BlossomRefreshType.GetHashCode();
      if (RefreshId != 0) hash ^= RefreshId.GetHashCode();
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
      if (Resin != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Resin);
      }
      qualifyUidList_.WriteTo(output, _repeated_qualifyUidList_codec);
      remainUidList_.WriteTo(output, _repeated_remainUidList_codec);
      if (DeadTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DeadTime);
      }
      if (BlossomRefreshType != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BlossomRefreshType);
      }
      if (RefreshId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RefreshId);
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
      if (Resin != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Resin);
      }
      qualifyUidList_.WriteTo(ref output, _repeated_qualifyUidList_codec);
      remainUidList_.WriteTo(ref output, _repeated_remainUidList_codec);
      if (DeadTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DeadTime);
      }
      if (BlossomRefreshType != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BlossomRefreshType);
      }
      if (RefreshId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RefreshId);
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
      if (Resin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Resin);
      }
      size += qualifyUidList_.CalculateSize(_repeated_qualifyUidList_codec);
      size += remainUidList_.CalculateSize(_repeated_remainUidList_codec);
      if (DeadTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DeadTime);
      }
      if (BlossomRefreshType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BlossomRefreshType);
      }
      if (RefreshId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RefreshId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BlossomChestInfo other) {
      if (other == null) {
        return;
      }
      if (other.Resin != 0) {
        Resin = other.Resin;
      }
      qualifyUidList_.Add(other.qualifyUidList_);
      remainUidList_.Add(other.remainUidList_);
      if (other.DeadTime != 0) {
        DeadTime = other.DeadTime;
      }
      if (other.BlossomRefreshType != 0) {
        BlossomRefreshType = other.BlossomRefreshType;
      }
      if (other.RefreshId != 0) {
        RefreshId = other.RefreshId;
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
            Resin = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            qualifyUidList_.AddEntriesFrom(input, _repeated_qualifyUidList_codec);
            break;
          }
          case 26:
          case 24: {
            remainUidList_.AddEntriesFrom(input, _repeated_remainUidList_codec);
            break;
          }
          case 32: {
            DeadTime = input.ReadUInt32();
            break;
          }
          case 40: {
            BlossomRefreshType = input.ReadUInt32();
            break;
          }
          case 48: {
            RefreshId = input.ReadUInt32();
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
            Resin = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            qualifyUidList_.AddEntriesFrom(ref input, _repeated_qualifyUidList_codec);
            break;
          }
          case 26:
          case 24: {
            remainUidList_.AddEntriesFrom(ref input, _repeated_remainUidList_codec);
            break;
          }
          case 32: {
            DeadTime = input.ReadUInt32();
            break;
          }
          case 40: {
            BlossomRefreshType = input.ReadUInt32();
            break;
          }
          case 48: {
            RefreshId = input.ReadUInt32();
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
