// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_ILLNKBDNGKP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_ILLNKBDNGKP.proto</summary>
  public static partial class Unk3000ILLNKBDNGKPReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_ILLNKBDNGKP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000ILLNKBDNGKPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0lMTE5LQkROR0tQLnByb3RvGhlVbmszMDAwX0RDSE1BTUZJ",
            "Rk9GLnByb3RvGhlVbmszMDAwX0hHQk5PQ0pCREVLLnByb3RvInsKE1VuazMw",
            "MDBfSUxMTktCRE5HS1ASMQoTVW5rMjcwMF9QSEtISVBMRE9PQRgFIAMoCzIU",
            "LlVuazMwMDBfSEdCTk9DSkJERUsSMQoTVW5rMzAwMF9BSUVOQ01MTUNCRRgH",
            "IAMoCzIULlVuazMwMDBfRENITUFNRklGT0ZCGqoCF1dlZWR3YWNrZXIuU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk3000DCHMAMFIFOFReflection.Descriptor, global::Weedwacker.Server.Proto.Unk3000HGBNOCJBDEKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk3000_ILLNKBDNGKP), global::Weedwacker.Server.Proto.Unk3000_ILLNKBDNGKP.Parser, new[]{ "Unk2700PHKHIPLDOOA", "Unk3000AIENCMLMCBE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk3000_ILLNKBDNGKP : pb::IMessage<Unk3000_ILLNKBDNGKP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_ILLNKBDNGKP> _parser = new pb::MessageParser<Unk3000_ILLNKBDNGKP>(() => new Unk3000_ILLNKBDNGKP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_ILLNKBDNGKP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk3000ILLNKBDNGKPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ILLNKBDNGKP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ILLNKBDNGKP(Unk3000_ILLNKBDNGKP other) : this() {
      unk2700PHKHIPLDOOA_ = other.unk2700PHKHIPLDOOA_.Clone();
      unk3000AIENCMLMCBE_ = other.unk3000AIENCMLMCBE_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ILLNKBDNGKP Clone() {
      return new Unk3000_ILLNKBDNGKP(this);
    }

    /// <summary>Field number for the "Unk2700_PHKHIPLDOOA" field.</summary>
    public const int Unk2700PHKHIPLDOOAFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk3000_HGBNOCJBDEK> _repeated_unk2700PHKHIPLDOOA_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Server.Proto.Unk3000_HGBNOCJBDEK.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_HGBNOCJBDEK> unk2700PHKHIPLDOOA_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_HGBNOCJBDEK>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_HGBNOCJBDEK> Unk2700PHKHIPLDOOA {
      get { return unk2700PHKHIPLDOOA_; }
    }

    /// <summary>Field number for the "Unk3000_AIENCMLMCBE" field.</summary>
    public const int Unk3000AIENCMLMCBEFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk3000_DCHMAMFIFOF> _repeated_unk3000AIENCMLMCBE_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Server.Proto.Unk3000_DCHMAMFIFOF.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_DCHMAMFIFOF> unk3000AIENCMLMCBE_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_DCHMAMFIFOF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_DCHMAMFIFOF> Unk3000AIENCMLMCBE {
      get { return unk3000AIENCMLMCBE_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_ILLNKBDNGKP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_ILLNKBDNGKP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700PHKHIPLDOOA_.Equals(other.unk2700PHKHIPLDOOA_)) return false;
      if(!unk3000AIENCMLMCBE_.Equals(other.unk3000AIENCMLMCBE_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700PHKHIPLDOOA_.GetHashCode();
      hash ^= unk3000AIENCMLMCBE_.GetHashCode();
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
      unk2700PHKHIPLDOOA_.WriteTo(output, _repeated_unk2700PHKHIPLDOOA_codec);
      unk3000AIENCMLMCBE_.WriteTo(output, _repeated_unk3000AIENCMLMCBE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk2700PHKHIPLDOOA_.WriteTo(ref output, _repeated_unk2700PHKHIPLDOOA_codec);
      unk3000AIENCMLMCBE_.WriteTo(ref output, _repeated_unk3000AIENCMLMCBE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700PHKHIPLDOOA_.CalculateSize(_repeated_unk2700PHKHIPLDOOA_codec);
      size += unk3000AIENCMLMCBE_.CalculateSize(_repeated_unk3000AIENCMLMCBE_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_ILLNKBDNGKP other) {
      if (other == null) {
        return;
      }
      unk2700PHKHIPLDOOA_.Add(other.unk2700PHKHIPLDOOA_);
      unk3000AIENCMLMCBE_.Add(other.unk3000AIENCMLMCBE_);
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
          case 42: {
            unk2700PHKHIPLDOOA_.AddEntriesFrom(input, _repeated_unk2700PHKHIPLDOOA_codec);
            break;
          }
          case 58: {
            unk3000AIENCMLMCBE_.AddEntriesFrom(input, _repeated_unk3000AIENCMLMCBE_codec);
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
          case 42: {
            unk2700PHKHIPLDOOA_.AddEntriesFrom(ref input, _repeated_unk2700PHKHIPLDOOA_codec);
            break;
          }
          case 58: {
            unk3000AIENCMLMCBE_.AddEntriesFrom(ref input, _repeated_unk3000AIENCMLMCBE_codec);
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
