// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_BNMDCEKPDMC.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_BNMDCEKPDMC.proto</summary>
  public static partial class Unk2700BNMDCEKPDMCReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_BNMDCEKPDMC.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700BNMDCEKPDMCReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0JOTURDRUtQRE1DLnByb3RvGhlVbmsyNzAwX0JKSk9NUERM",
            "TkFMLnByb3RvGhlVbmsyNzAwX0hKTEZOS0xQRkJILnByb3RvIsICChNVbmsy",
            "NzAwX0JOTURDRUtQRE1DEhAKCHN0YWdlX2lkGAggASgNEhsKE1VuazI3MDBf",
            "S0lGUEtQR0tKQ0EYDiADKA0SKQoLYXZhdGFyX2xpc3QYDSADKAsyFC5Vbmsy",
            "NzAwX0hKTEZOS0xQRkJIEjEKE1VuazI3MDBfQUFHQklGSE5OUFAYAiADKAsy",
            "FC5VbmsyNzAwX0JKSk9NUERMTkFMEhsKE1VuazI3MDBfR0dOQkJITUdMQU4Y",
            "CiADKA0SMQoTVW5rMjcwMF9QTEhJSklIRk5ETBgJIAMoCzIULlVuazI3MDBf",
            "SEpMRk5LTFBGQkgSGwoTVW5rMjcwMF9PS0dLSFBDTU5NThgPIAMoDRIxChNV",
            "bmsyNzAwX0JCR0hJQ0VETEJCGAsgAygLMhQuVW5rMjcwMF9ISkxGTktMUEZC",
            "SEIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700BJJOMPDLNALReflection.Descriptor, global::Weedwacker.Server.Proto.Unk2700HJLFNKLPFBHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_BNMDCEKPDMC), global::Weedwacker.Server.Proto.Unk2700_BNMDCEKPDMC.Parser, new[]{ "StageId", "Unk2700KIFPKPGKJCA", "AvatarList", "Unk2700AAGBIFHNNPP", "Unk2700GGNBBHMGLAN", "Unk2700PLHIJIHFNDL", "Unk2700OKGKHPCMNMN", "Unk2700BBGHICEDLBB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8641
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_BNMDCEKPDMC : pb::IMessage<Unk2700_BNMDCEKPDMC>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_BNMDCEKPDMC> _parser = new pb::MessageParser<Unk2700_BNMDCEKPDMC>(() => new Unk2700_BNMDCEKPDMC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_BNMDCEKPDMC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700BNMDCEKPDMCReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BNMDCEKPDMC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BNMDCEKPDMC(Unk2700_BNMDCEKPDMC other) : this() {
      stageId_ = other.stageId_;
      unk2700KIFPKPGKJCA_ = other.unk2700KIFPKPGKJCA_.Clone();
      avatarList_ = other.avatarList_.Clone();
      unk2700AAGBIFHNNPP_ = other.unk2700AAGBIFHNNPP_.Clone();
      unk2700GGNBBHMGLAN_ = other.unk2700GGNBBHMGLAN_.Clone();
      unk2700PLHIJIHFNDL_ = other.unk2700PLHIJIHFNDL_.Clone();
      unk2700OKGKHPCMNMN_ = other.unk2700OKGKHPCMNMN_.Clone();
      unk2700BBGHICEDLBB_ = other.unk2700BBGHICEDLBB_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BNMDCEKPDMC Clone() {
      return new Unk2700_BNMDCEKPDMC(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 8;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_KIFPKPGKJCA" field.</summary>
    public const int Unk2700KIFPKPGKJCAFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700KIFPKPGKJCA_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> unk2700KIFPKPGKJCA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700KIFPKPGKJCA {
      get { return unk2700KIFPKPGKJCA_; }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> avatarList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "Unk2700_AAGBIFHNNPP" field.</summary>
    public const int Unk2700AAGBIFHNNPPFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_BJJOMPDLNAL> _repeated_unk2700AAGBIFHNNPP_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Server.Proto.Unk2700_BJJOMPDLNAL.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BJJOMPDLNAL> unk2700AAGBIFHNNPP_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BJJOMPDLNAL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_BJJOMPDLNAL> Unk2700AAGBIFHNNPP {
      get { return unk2700AAGBIFHNNPP_; }
    }

    /// <summary>Field number for the "Unk2700_GGNBBHMGLAN" field.</summary>
    public const int Unk2700GGNBBHMGLANFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700GGNBBHMGLAN_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> unk2700GGNBBHMGLAN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700GGNBBHMGLAN {
      get { return unk2700GGNBBHMGLAN_; }
    }

    /// <summary>Field number for the "Unk2700_PLHIJIHFNDL" field.</summary>
    public const int Unk2700PLHIJIHFNDLFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> _repeated_unk2700PLHIJIHFNDL_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> unk2700PLHIJIHFNDL_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> Unk2700PLHIJIHFNDL {
      get { return unk2700PLHIJIHFNDL_; }
    }

    /// <summary>Field number for the "Unk2700_OKGKHPCMNMN" field.</summary>
    public const int Unk2700OKGKHPCMNMNFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700OKGKHPCMNMN_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> unk2700OKGKHPCMNMN_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700OKGKHPCMNMN {
      get { return unk2700OKGKHPCMNMN_; }
    }

    /// <summary>Field number for the "Unk2700_BBGHICEDLBB" field.</summary>
    public const int Unk2700BBGHICEDLBBFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> _repeated_unk2700BBGHICEDLBB_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> unk2700BBGHICEDLBB_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_HJLFNKLPFBH> Unk2700BBGHICEDLBB {
      get { return unk2700BBGHICEDLBB_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_BNMDCEKPDMC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_BNMDCEKPDMC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if(!unk2700KIFPKPGKJCA_.Equals(other.unk2700KIFPKPGKJCA_)) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if(!unk2700AAGBIFHNNPP_.Equals(other.unk2700AAGBIFHNNPP_)) return false;
      if(!unk2700GGNBBHMGLAN_.Equals(other.unk2700GGNBBHMGLAN_)) return false;
      if(!unk2700PLHIJIHFNDL_.Equals(other.unk2700PLHIJIHFNDL_)) return false;
      if(!unk2700OKGKHPCMNMN_.Equals(other.unk2700OKGKHPCMNMN_)) return false;
      if(!unk2700BBGHICEDLBB_.Equals(other.unk2700BBGHICEDLBB_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= unk2700KIFPKPGKJCA_.GetHashCode();
      hash ^= avatarList_.GetHashCode();
      hash ^= unk2700AAGBIFHNNPP_.GetHashCode();
      hash ^= unk2700GGNBBHMGLAN_.GetHashCode();
      hash ^= unk2700PLHIJIHFNDL_.GetHashCode();
      hash ^= unk2700OKGKHPCMNMN_.GetHashCode();
      hash ^= unk2700BBGHICEDLBB_.GetHashCode();
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
      unk2700AAGBIFHNNPP_.WriteTo(output, _repeated_unk2700AAGBIFHNNPP_codec);
      if (StageId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StageId);
      }
      unk2700PLHIJIHFNDL_.WriteTo(output, _repeated_unk2700PLHIJIHFNDL_codec);
      unk2700GGNBBHMGLAN_.WriteTo(output, _repeated_unk2700GGNBBHMGLAN_codec);
      unk2700BBGHICEDLBB_.WriteTo(output, _repeated_unk2700BBGHICEDLBB_codec);
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      unk2700KIFPKPGKJCA_.WriteTo(output, _repeated_unk2700KIFPKPGKJCA_codec);
      unk2700OKGKHPCMNMN_.WriteTo(output, _repeated_unk2700OKGKHPCMNMN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk2700AAGBIFHNNPP_.WriteTo(ref output, _repeated_unk2700AAGBIFHNNPP_codec);
      if (StageId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StageId);
      }
      unk2700PLHIJIHFNDL_.WriteTo(ref output, _repeated_unk2700PLHIJIHFNDL_codec);
      unk2700GGNBBHMGLAN_.WriteTo(ref output, _repeated_unk2700GGNBBHMGLAN_codec);
      unk2700BBGHICEDLBB_.WriteTo(ref output, _repeated_unk2700BBGHICEDLBB_codec);
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      unk2700KIFPKPGKJCA_.WriteTo(ref output, _repeated_unk2700KIFPKPGKJCA_codec);
      unk2700OKGKHPCMNMN_.WriteTo(ref output, _repeated_unk2700OKGKHPCMNMN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += unk2700KIFPKPGKJCA_.CalculateSize(_repeated_unk2700KIFPKPGKJCA_codec);
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      size += unk2700AAGBIFHNNPP_.CalculateSize(_repeated_unk2700AAGBIFHNNPP_codec);
      size += unk2700GGNBBHMGLAN_.CalculateSize(_repeated_unk2700GGNBBHMGLAN_codec);
      size += unk2700PLHIJIHFNDL_.CalculateSize(_repeated_unk2700PLHIJIHFNDL_codec);
      size += unk2700OKGKHPCMNMN_.CalculateSize(_repeated_unk2700OKGKHPCMNMN_codec);
      size += unk2700BBGHICEDLBB_.CalculateSize(_repeated_unk2700BBGHICEDLBB_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_BNMDCEKPDMC other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      unk2700KIFPKPGKJCA_.Add(other.unk2700KIFPKPGKJCA_);
      avatarList_.Add(other.avatarList_);
      unk2700AAGBIFHNNPP_.Add(other.unk2700AAGBIFHNNPP_);
      unk2700GGNBBHMGLAN_.Add(other.unk2700GGNBBHMGLAN_);
      unk2700PLHIJIHFNDL_.Add(other.unk2700PLHIJIHFNDL_);
      unk2700OKGKHPCMNMN_.Add(other.unk2700OKGKHPCMNMN_);
      unk2700BBGHICEDLBB_.Add(other.unk2700BBGHICEDLBB_);
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
          case 18: {
            unk2700AAGBIFHNNPP_.AddEntriesFrom(input, _repeated_unk2700AAGBIFHNNPP_codec);
            break;
          }
          case 64: {
            StageId = input.ReadUInt32();
            break;
          }
          case 74: {
            unk2700PLHIJIHFNDL_.AddEntriesFrom(input, _repeated_unk2700PLHIJIHFNDL_codec);
            break;
          }
          case 82:
          case 80: {
            unk2700GGNBBHMGLAN_.AddEntriesFrom(input, _repeated_unk2700GGNBBHMGLAN_codec);
            break;
          }
          case 90: {
            unk2700BBGHICEDLBB_.AddEntriesFrom(input, _repeated_unk2700BBGHICEDLBB_codec);
            break;
          }
          case 106: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
            break;
          }
          case 114:
          case 112: {
            unk2700KIFPKPGKJCA_.AddEntriesFrom(input, _repeated_unk2700KIFPKPGKJCA_codec);
            break;
          }
          case 122:
          case 120: {
            unk2700OKGKHPCMNMN_.AddEntriesFrom(input, _repeated_unk2700OKGKHPCMNMN_codec);
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
          case 18: {
            unk2700AAGBIFHNNPP_.AddEntriesFrom(ref input, _repeated_unk2700AAGBIFHNNPP_codec);
            break;
          }
          case 64: {
            StageId = input.ReadUInt32();
            break;
          }
          case 74: {
            unk2700PLHIJIHFNDL_.AddEntriesFrom(ref input, _repeated_unk2700PLHIJIHFNDL_codec);
            break;
          }
          case 82:
          case 80: {
            unk2700GGNBBHMGLAN_.AddEntriesFrom(ref input, _repeated_unk2700GGNBBHMGLAN_codec);
            break;
          }
          case 90: {
            unk2700BBGHICEDLBB_.AddEntriesFrom(ref input, _repeated_unk2700BBGHICEDLBB_codec);
            break;
          }
          case 106: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
            break;
          }
          case 114:
          case 112: {
            unk2700KIFPKPGKJCA_.AddEntriesFrom(ref input, _repeated_unk2700KIFPKPGKJCA_codec);
            break;
          }
          case 122:
          case 120: {
            unk2700OKGKHPCMNMN_.AddEntriesFrom(ref input, _repeated_unk2700OKGKHPCMNMN_codec);
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
