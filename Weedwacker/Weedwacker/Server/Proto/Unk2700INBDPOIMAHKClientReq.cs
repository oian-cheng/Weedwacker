// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_INBDPOIMAHK_ClientReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_INBDPOIMAHK_ClientReq.proto</summary>
  public static partial class Unk2700INBDPOIMAHKClientReqReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_INBDPOIMAHK_ClientReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700INBDPOIMAHKClientReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVbmsyNzAwX0lOQkRQT0lNQUhLX0NsaWVudFJlcS5wcm90byJOCh1Vbmsy",
            "NzAwX0lOQkRQT0lNQUhLX0NsaWVudFJlcRIQCgh0YWdfbGlzdBgBIAMoDRIb",
            "ChNVbmsyNzAwX09OT09KQkVBQk9FGAUgASgEQhqqAhdXZWVkd2Fja2VyLlNl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_INBDPOIMAHK_ClientReq), global::Weedwacker.Server.Proto.Unk2700_INBDPOIMAHK_ClientReq.Parser, new[]{ "TagList", "Unk2700ONOOJBEABOE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6242
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_INBDPOIMAHK_ClientReq : pb::IMessage<Unk2700_INBDPOIMAHK_ClientReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_INBDPOIMAHK_ClientReq> _parser = new pb::MessageParser<Unk2700_INBDPOIMAHK_ClientReq>(() => new Unk2700_INBDPOIMAHK_ClientReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_INBDPOIMAHK_ClientReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700INBDPOIMAHKClientReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_INBDPOIMAHK_ClientReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_INBDPOIMAHK_ClientReq(Unk2700_INBDPOIMAHK_ClientReq other) : this() {
      tagList_ = other.tagList_.Clone();
      unk2700ONOOJBEABOE_ = other.unk2700ONOOJBEABOE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_INBDPOIMAHK_ClientReq Clone() {
      return new Unk2700_INBDPOIMAHK_ClientReq(this);
    }

    /// <summary>Field number for the "tag_list" field.</summary>
    public const int TagListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_tagList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> tagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TagList {
      get { return tagList_; }
    }

    /// <summary>Field number for the "Unk2700_ONOOJBEABOE" field.</summary>
    public const int Unk2700ONOOJBEABOEFieldNumber = 5;
    private ulong unk2700ONOOJBEABOE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk2700ONOOJBEABOE {
      get { return unk2700ONOOJBEABOE_; }
      set {
        unk2700ONOOJBEABOE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_INBDPOIMAHK_ClientReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_INBDPOIMAHK_ClientReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!tagList_.Equals(other.tagList_)) return false;
      if (Unk2700ONOOJBEABOE != other.Unk2700ONOOJBEABOE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= tagList_.GetHashCode();
      if (Unk2700ONOOJBEABOE != 0UL) hash ^= Unk2700ONOOJBEABOE.GetHashCode();
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
      tagList_.WriteTo(output, _repeated_tagList_codec);
      if (Unk2700ONOOJBEABOE != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(Unk2700ONOOJBEABOE);
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
      tagList_.WriteTo(ref output, _repeated_tagList_codec);
      if (Unk2700ONOOJBEABOE != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(Unk2700ONOOJBEABOE);
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
      size += tagList_.CalculateSize(_repeated_tagList_codec);
      if (Unk2700ONOOJBEABOE != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk2700ONOOJBEABOE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_INBDPOIMAHK_ClientReq other) {
      if (other == null) {
        return;
      }
      tagList_.Add(other.tagList_);
      if (other.Unk2700ONOOJBEABOE != 0UL) {
        Unk2700ONOOJBEABOE = other.Unk2700ONOOJBEABOE;
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
          case 10:
          case 8: {
            tagList_.AddEntriesFrom(input, _repeated_tagList_codec);
            break;
          }
          case 40: {
            Unk2700ONOOJBEABOE = input.ReadUInt64();
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
            tagList_.AddEntriesFrom(ref input, _repeated_tagList_codec);
            break;
          }
          case 40: {
            Unk2700ONOOJBEABOE = input.ReadUInt64();
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
