// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QueryCodexMonsterBeKilledNumRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from QueryCodexMonsterBeKilledNumRsp.proto</summary>
  public static partial class QueryCodexMonsterBeKilledNumRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QueryCodexMonsterBeKilledNumRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryCodexMonsterBeKilledNumRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVRdWVyeUNvZGV4TW9uc3RlckJlS2lsbGVkTnVtUnNwLnByb3RvIoIBCh9R",
            "dWVyeUNvZGV4TW9uc3RlckJlS2lsbGVkTnVtUnNwEhUKDWNvZGV4X2lkX2xp",
            "c3QYBCADKA0SGwoTVW5rMjcwMF9NS09CTUdHUE5NSRgGIAMoDRIaChJiZV9r",
            "aWxsZWRfbnVtX2xpc3QYDCADKA0SDwoHcmV0Y29kZRgFIAEoBUIaqgIXV2Vl",
            "ZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.QueryCodexMonsterBeKilledNumRsp), global::Weedwacker.Server.Proto.QueryCodexMonsterBeKilledNumRsp.Parser, new[]{ "CodexIdList", "Unk2700MKOBMGGPNMI", "BeKilledNumList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4209
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class QueryCodexMonsterBeKilledNumRsp : pb::IMessage<QueryCodexMonsterBeKilledNumRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryCodexMonsterBeKilledNumRsp> _parser = new pb::MessageParser<QueryCodexMonsterBeKilledNumRsp>(() => new QueryCodexMonsterBeKilledNumRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryCodexMonsterBeKilledNumRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.QueryCodexMonsterBeKilledNumRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp(QueryCodexMonsterBeKilledNumRsp other) : this() {
      codexIdList_ = other.codexIdList_.Clone();
      unk2700MKOBMGGPNMI_ = other.unk2700MKOBMGGPNMI_.Clone();
      beKilledNumList_ = other.beKilledNumList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp Clone() {
      return new QueryCodexMonsterBeKilledNumRsp(this);
    }

    /// <summary>Field number for the "codex_id_list" field.</summary>
    public const int CodexIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_codexIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> codexIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CodexIdList {
      get { return codexIdList_; }
    }

    /// <summary>Field number for the "Unk2700_MKOBMGGPNMI" field.</summary>
    public const int Unk2700MKOBMGGPNMIFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700MKOBMGGPNMI_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> unk2700MKOBMGGPNMI_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700MKOBMGGPNMI {
      get { return unk2700MKOBMGGPNMI_; }
    }

    /// <summary>Field number for the "be_killed_num_list" field.</summary>
    public const int BeKilledNumListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_beKilledNumList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> beKilledNumList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BeKilledNumList {
      get { return beKilledNumList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
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
      return Equals(other as QueryCodexMonsterBeKilledNumRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryCodexMonsterBeKilledNumRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!codexIdList_.Equals(other.codexIdList_)) return false;
      if(!unk2700MKOBMGGPNMI_.Equals(other.unk2700MKOBMGGPNMI_)) return false;
      if(!beKilledNumList_.Equals(other.beKilledNumList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= codexIdList_.GetHashCode();
      hash ^= unk2700MKOBMGGPNMI_.GetHashCode();
      hash ^= beKilledNumList_.GetHashCode();
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
      codexIdList_.WriteTo(output, _repeated_codexIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      unk2700MKOBMGGPNMI_.WriteTo(output, _repeated_unk2700MKOBMGGPNMI_codec);
      beKilledNumList_.WriteTo(output, _repeated_beKilledNumList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      codexIdList_.WriteTo(ref output, _repeated_codexIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      unk2700MKOBMGGPNMI_.WriteTo(ref output, _repeated_unk2700MKOBMGGPNMI_codec);
      beKilledNumList_.WriteTo(ref output, _repeated_beKilledNumList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += codexIdList_.CalculateSize(_repeated_codexIdList_codec);
      size += unk2700MKOBMGGPNMI_.CalculateSize(_repeated_unk2700MKOBMGGPNMI_codec);
      size += beKilledNumList_.CalculateSize(_repeated_beKilledNumList_codec);
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
    public void MergeFrom(QueryCodexMonsterBeKilledNumRsp other) {
      if (other == null) {
        return;
      }
      codexIdList_.Add(other.codexIdList_);
      unk2700MKOBMGGPNMI_.Add(other.unk2700MKOBMGGPNMI_);
      beKilledNumList_.Add(other.beKilledNumList_);
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
          case 34:
          case 32: {
            codexIdList_.AddEntriesFrom(input, _repeated_codexIdList_codec);
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 50:
          case 48: {
            unk2700MKOBMGGPNMI_.AddEntriesFrom(input, _repeated_unk2700MKOBMGGPNMI_codec);
            break;
          }
          case 98:
          case 96: {
            beKilledNumList_.AddEntriesFrom(input, _repeated_beKilledNumList_codec);
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
          case 34:
          case 32: {
            codexIdList_.AddEntriesFrom(ref input, _repeated_codexIdList_codec);
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 50:
          case 48: {
            unk2700MKOBMGGPNMI_.AddEntriesFrom(ref input, _repeated_unk2700MKOBMGGPNMI_codec);
            break;
          }
          case 98:
          case 96: {
            beKilledNumList_.AddEntriesFrom(ref input, _repeated_beKilledNumList_codec);
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
