// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_DCBEFDDECOJ.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_DCBEFDDECOJ.proto</summary>
  public static partial class Unk2700DCBEFDDECOJReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_DCBEFDDECOJ.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700DCBEFDDECOJReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0RDQkVGRERFQ09KLnByb3RvGhlVbmsyNzAwX0FESUdFQkVJ",
            "SkJBLnByb3RvGhlVbmsyNzAwX1BLQVBDT0JHSUpMLnByb3RvIt4BChNVbmsy",
            "NzAwX0RDQkVGRERFQ09KEjEKE1VuazI3MDBfSU5JQktGUE1DRk8YCCADKAsy",
            "FC5VbmsyNzAwX1BLQVBDT0JHSUpMEhAKCGxldmVsX2lkGAEgASgNEhsKE1Vu",
            "azI3MDBfQ0JQTlBFQk1QT0gYDyABKAgSFQoNZGlmZmljdWx0eV9pZBgLIAEo",
            "DRIxChNVbmsyNzAwX0VPTlBLTExKSFBIGAMgAygLMhQuVW5rMjcwMF9BRElH",
            "RUJFSUpCQRIbChNVbmsyNzAwX0ZJR0hKSUZJTktJGAcgASgNQhqqAhdXZWVk",
            "d2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700ADIGEBEIJBAReflection.Descriptor, global::Weedwacker.Server.Proto.Unk2700PKAPCOBGIJLReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_DCBEFDDECOJ), global::Weedwacker.Server.Proto.Unk2700_DCBEFDDECOJ.Parser, new[]{ "Unk2700INIBKFPMCFO", "LevelId", "Unk2700CBPNPEBMPOH", "DifficultyId", "Unk2700EONPKLLJHPH", "Unk2700FIGHJIFINKI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8858
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_DCBEFDDECOJ : pb::IMessage<Unk2700_DCBEFDDECOJ>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_DCBEFDDECOJ> _parser = new pb::MessageParser<Unk2700_DCBEFDDECOJ>(() => new Unk2700_DCBEFDDECOJ());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_DCBEFDDECOJ> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700DCBEFDDECOJReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_DCBEFDDECOJ() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_DCBEFDDECOJ(Unk2700_DCBEFDDECOJ other) : this() {
      unk2700INIBKFPMCFO_ = other.unk2700INIBKFPMCFO_.Clone();
      levelId_ = other.levelId_;
      unk2700CBPNPEBMPOH_ = other.unk2700CBPNPEBMPOH_;
      difficultyId_ = other.difficultyId_;
      unk2700EONPKLLJHPH_ = other.unk2700EONPKLLJHPH_.Clone();
      unk2700FIGHJIFINKI_ = other.unk2700FIGHJIFINKI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_DCBEFDDECOJ Clone() {
      return new Unk2700_DCBEFDDECOJ(this);
    }

    /// <summary>Field number for the "Unk2700_INIBKFPMCFO" field.</summary>
    public const int Unk2700INIBKFPMCFOFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_PKAPCOBGIJL> _repeated_unk2700INIBKFPMCFO_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Server.Proto.Unk2700_PKAPCOBGIJL.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_PKAPCOBGIJL> unk2700INIBKFPMCFO_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_PKAPCOBGIJL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_PKAPCOBGIJL> Unk2700INIBKFPMCFO {
      get { return unk2700INIBKFPMCFO_; }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 1;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_CBPNPEBMPOH" field.</summary>
    public const int Unk2700CBPNPEBMPOHFieldNumber = 15;
    private bool unk2700CBPNPEBMPOH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700CBPNPEBMPOH {
      get { return unk2700CBPNPEBMPOH_; }
      set {
        unk2700CBPNPEBMPOH_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 11;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_EONPKLLJHPH" field.</summary>
    public const int Unk2700EONPKLLJHPHFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_ADIGEBEIJBA> _repeated_unk2700EONPKLLJHPH_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Server.Proto.Unk2700_ADIGEBEIJBA.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_ADIGEBEIJBA> unk2700EONPKLLJHPH_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_ADIGEBEIJBA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_ADIGEBEIJBA> Unk2700EONPKLLJHPH {
      get { return unk2700EONPKLLJHPH_; }
    }

    /// <summary>Field number for the "Unk2700_FIGHJIFINKI" field.</summary>
    public const int Unk2700FIGHJIFINKIFieldNumber = 7;
    private uint unk2700FIGHJIFINKI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700FIGHJIFINKI {
      get { return unk2700FIGHJIFINKI_; }
      set {
        unk2700FIGHJIFINKI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_DCBEFDDECOJ);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_DCBEFDDECOJ other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700INIBKFPMCFO_.Equals(other.unk2700INIBKFPMCFO_)) return false;
      if (LevelId != other.LevelId) return false;
      if (Unk2700CBPNPEBMPOH != other.Unk2700CBPNPEBMPOH) return false;
      if (DifficultyId != other.DifficultyId) return false;
      if(!unk2700EONPKLLJHPH_.Equals(other.unk2700EONPKLLJHPH_)) return false;
      if (Unk2700FIGHJIFINKI != other.Unk2700FIGHJIFINKI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700INIBKFPMCFO_.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (Unk2700CBPNPEBMPOH != false) hash ^= Unk2700CBPNPEBMPOH.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      hash ^= unk2700EONPKLLJHPH_.GetHashCode();
      if (Unk2700FIGHJIFINKI != 0) hash ^= Unk2700FIGHJIFINKI.GetHashCode();
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
      if (LevelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LevelId);
      }
      unk2700EONPKLLJHPH_.WriteTo(output, _repeated_unk2700EONPKLLJHPH_codec);
      if (Unk2700FIGHJIFINKI != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk2700FIGHJIFINKI);
      }
      unk2700INIBKFPMCFO_.WriteTo(output, _repeated_unk2700INIBKFPMCFO_codec);
      if (DifficultyId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DifficultyId);
      }
      if (Unk2700CBPNPEBMPOH != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk2700CBPNPEBMPOH);
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
      if (LevelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LevelId);
      }
      unk2700EONPKLLJHPH_.WriteTo(ref output, _repeated_unk2700EONPKLLJHPH_codec);
      if (Unk2700FIGHJIFINKI != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk2700FIGHJIFINKI);
      }
      unk2700INIBKFPMCFO_.WriteTo(ref output, _repeated_unk2700INIBKFPMCFO_codec);
      if (DifficultyId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DifficultyId);
      }
      if (Unk2700CBPNPEBMPOH != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk2700CBPNPEBMPOH);
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
      size += unk2700INIBKFPMCFO_.CalculateSize(_repeated_unk2700INIBKFPMCFO_codec);
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (Unk2700CBPNPEBMPOH != false) {
        size += 1 + 1;
      }
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      size += unk2700EONPKLLJHPH_.CalculateSize(_repeated_unk2700EONPKLLJHPH_codec);
      if (Unk2700FIGHJIFINKI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700FIGHJIFINKI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_DCBEFDDECOJ other) {
      if (other == null) {
        return;
      }
      unk2700INIBKFPMCFO_.Add(other.unk2700INIBKFPMCFO_);
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.Unk2700CBPNPEBMPOH != false) {
        Unk2700CBPNPEBMPOH = other.Unk2700CBPNPEBMPOH;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      unk2700EONPKLLJHPH_.Add(other.unk2700EONPKLLJHPH_);
      if (other.Unk2700FIGHJIFINKI != 0) {
        Unk2700FIGHJIFINKI = other.Unk2700FIGHJIFINKI;
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 26: {
            unk2700EONPKLLJHPH_.AddEntriesFrom(input, _repeated_unk2700EONPKLLJHPH_codec);
            break;
          }
          case 56: {
            Unk2700FIGHJIFINKI = input.ReadUInt32();
            break;
          }
          case 66: {
            unk2700INIBKFPMCFO_.AddEntriesFrom(input, _repeated_unk2700INIBKFPMCFO_codec);
            break;
          }
          case 88: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk2700CBPNPEBMPOH = input.ReadBool();
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 26: {
            unk2700EONPKLLJHPH_.AddEntriesFrom(ref input, _repeated_unk2700EONPKLLJHPH_codec);
            break;
          }
          case 56: {
            Unk2700FIGHJIFINKI = input.ReadUInt32();
            break;
          }
          case 66: {
            unk2700INIBKFPMCFO_.AddEntriesFrom(ref input, _repeated_unk2700INIBKFPMCFO_codec);
            break;
          }
          case 88: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk2700CBPNPEBMPOH = input.ReadBool();
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
