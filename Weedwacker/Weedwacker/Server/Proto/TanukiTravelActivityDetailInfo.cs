// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TanukiTravelActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from TanukiTravelActivityDetailInfo.proto</summary>
  public static partial class TanukiTravelActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TanukiTravelActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TanukiTravelActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRUYW51a2lUcmF2ZWxBY3Rpdml0eURldGFpbEluZm8ucHJvdG8aGVVuazI3",
            "MDBfQklGTkZPR0JQTk0ucHJvdG8iiwEKHlRhbnVraVRyYXZlbEFjdGl2aXR5",
            "RGV0YWlsSW5mbxIxChNVbmsyNzAwX0pCUEZJRERQR01FGAQgAygLMhQuVW5r",
            "MjcwMF9CSUZORk9HQlBOTRIZChFpc19jb250ZW50X2Nsb3NlZBgLIAEoCBIb",
            "ChNVbmsyNzAwX0JISENOT0xNQ0pNGAogASgNQhqqAhdXZWVkd2Fja2VyLlNl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700BIFNFOGBPNMReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.TanukiTravelActivityDetailInfo), global::Weedwacker.Server.Proto.TanukiTravelActivityDetailInfo.Parser, new[]{ "Unk2700JBPFIDDPGME", "IsContentClosed", "Unk2700BHHCNOLMCJM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TanukiTravelActivityDetailInfo : pb::IMessage<TanukiTravelActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TanukiTravelActivityDetailInfo> _parser = new pb::MessageParser<TanukiTravelActivityDetailInfo>(() => new TanukiTravelActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TanukiTravelActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.TanukiTravelActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelActivityDetailInfo(TanukiTravelActivityDetailInfo other) : this() {
      unk2700JBPFIDDPGME_ = other.unk2700JBPFIDDPGME_.Clone();
      isContentClosed_ = other.isContentClosed_;
      unk2700BHHCNOLMCJM_ = other.unk2700BHHCNOLMCJM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelActivityDetailInfo Clone() {
      return new TanukiTravelActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk2700_JBPFIDDPGME" field.</summary>
    public const int Unk2700JBPFIDDPGMEFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_BIFNFOGBPNM> _repeated_unk2700JBPFIDDPGME_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Server.Proto.Unk2700_BIFNFOGBPNM.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BIFNFOGBPNM> unk2700JBPFIDDPGME_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BIFNFOGBPNM>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BIFNFOGBPNM> Unk2700JBPFIDDPGME {
      get { return unk2700JBPFIDDPGME_; }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 11;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_BHHCNOLMCJM" field.</summary>
    public const int Unk2700BHHCNOLMCJMFieldNumber = 10;
    private uint unk2700BHHCNOLMCJM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700BHHCNOLMCJM {
      get { return unk2700BHHCNOLMCJM_; }
      set {
        unk2700BHHCNOLMCJM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TanukiTravelActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TanukiTravelActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700JBPFIDDPGME_.Equals(other.unk2700JBPFIDDPGME_)) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if (Unk2700BHHCNOLMCJM != other.Unk2700BHHCNOLMCJM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700JBPFIDDPGME_.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      if (Unk2700BHHCNOLMCJM != 0) hash ^= Unk2700BHHCNOLMCJM.GetHashCode();
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
      unk2700JBPFIDDPGME_.WriteTo(output, _repeated_unk2700JBPFIDDPGME_codec);
      if (Unk2700BHHCNOLMCJM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2700BHHCNOLMCJM);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsContentClosed);
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
      unk2700JBPFIDDPGME_.WriteTo(ref output, _repeated_unk2700JBPFIDDPGME_codec);
      if (Unk2700BHHCNOLMCJM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2700BHHCNOLMCJM);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsContentClosed);
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
      size += unk2700JBPFIDDPGME_.CalculateSize(_repeated_unk2700JBPFIDDPGME_codec);
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (Unk2700BHHCNOLMCJM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700BHHCNOLMCJM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TanukiTravelActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      unk2700JBPFIDDPGME_.Add(other.unk2700JBPFIDDPGME_);
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      if (other.Unk2700BHHCNOLMCJM != 0) {
        Unk2700BHHCNOLMCJM = other.Unk2700BHHCNOLMCJM;
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
          case 34: {
            unk2700JBPFIDDPGME_.AddEntriesFrom(input, _repeated_unk2700JBPFIDDPGME_codec);
            break;
          }
          case 80: {
            Unk2700BHHCNOLMCJM = input.ReadUInt32();
            break;
          }
          case 88: {
            IsContentClosed = input.ReadBool();
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
          case 34: {
            unk2700JBPFIDDPGME_.AddEntriesFrom(ref input, _repeated_unk2700JBPFIDDPGME_codec);
            break;
          }
          case 80: {
            Unk2700BHHCNOLMCJM = input.ReadUInt32();
            break;
          }
          case 88: {
            IsContentClosed = input.ReadBool();
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
