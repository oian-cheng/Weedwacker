// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_ENLDIHLGNCK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_ENLDIHLGNCK.proto</summary>
  public static partial class Unk3000ENLDIHLGNCKReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_ENLDIHLGNCK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000ENLDIHLGNCKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0VOTERJSExHTkNLLnByb3RvGhlVbmszMDAwX0dEREdHSklG",
            "TkNILnByb3RvImUKE1VuazMwMDBfRU5MRElITEdOQ0sSGwoTVW5rMzAwMF9D",
            "SU9MRUdFSERBQxgDIAEoDRIxChNVbmszMDAwX05MRlBLRE9CTkNEGA8gAygL",
            "MhQuVW5rMzAwMF9HRERHR0pJRk5DSEIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk3000GDDGGJIFNCHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk3000_ENLDIHLGNCK), global::Weedwacker.Server.Proto.Unk3000_ENLDIHLGNCK.Parser, new[]{ "Unk3000CIOLEGEHDAC", "Unk3000NLFPKDOBNCD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk3000_ENLDIHLGNCK : pb::IMessage<Unk3000_ENLDIHLGNCK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_ENLDIHLGNCK> _parser = new pb::MessageParser<Unk3000_ENLDIHLGNCK>(() => new Unk3000_ENLDIHLGNCK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_ENLDIHLGNCK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk3000ENLDIHLGNCKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ENLDIHLGNCK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ENLDIHLGNCK(Unk3000_ENLDIHLGNCK other) : this() {
      unk3000CIOLEGEHDAC_ = other.unk3000CIOLEGEHDAC_;
      unk3000NLFPKDOBNCD_ = other.unk3000NLFPKDOBNCD_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ENLDIHLGNCK Clone() {
      return new Unk3000_ENLDIHLGNCK(this);
    }

    /// <summary>Field number for the "Unk3000_CIOLEGEHDAC" field.</summary>
    public const int Unk3000CIOLEGEHDACFieldNumber = 3;
    private uint unk3000CIOLEGEHDAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000CIOLEGEHDAC {
      get { return unk3000CIOLEGEHDAC_; }
      set {
        unk3000CIOLEGEHDAC_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_NLFPKDOBNCD" field.</summary>
    public const int Unk3000NLFPKDOBNCDFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk3000_GDDGGJIFNCH> _repeated_unk3000NLFPKDOBNCD_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Server.Proto.Unk3000_GDDGGJIFNCH.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_GDDGGJIFNCH> unk3000NLFPKDOBNCD_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_GDDGGJIFNCH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk3000_GDDGGJIFNCH> Unk3000NLFPKDOBNCD {
      get { return unk3000NLFPKDOBNCD_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_ENLDIHLGNCK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_ENLDIHLGNCK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3000CIOLEGEHDAC != other.Unk3000CIOLEGEHDAC) return false;
      if(!unk3000NLFPKDOBNCD_.Equals(other.unk3000NLFPKDOBNCD_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3000CIOLEGEHDAC != 0) hash ^= Unk3000CIOLEGEHDAC.GetHashCode();
      hash ^= unk3000NLFPKDOBNCD_.GetHashCode();
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
      if (Unk3000CIOLEGEHDAC != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3000CIOLEGEHDAC);
      }
      unk3000NLFPKDOBNCD_.WriteTo(output, _repeated_unk3000NLFPKDOBNCD_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk3000CIOLEGEHDAC != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3000CIOLEGEHDAC);
      }
      unk3000NLFPKDOBNCD_.WriteTo(ref output, _repeated_unk3000NLFPKDOBNCD_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Unk3000CIOLEGEHDAC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000CIOLEGEHDAC);
      }
      size += unk3000NLFPKDOBNCD_.CalculateSize(_repeated_unk3000NLFPKDOBNCD_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_ENLDIHLGNCK other) {
      if (other == null) {
        return;
      }
      if (other.Unk3000CIOLEGEHDAC != 0) {
        Unk3000CIOLEGEHDAC = other.Unk3000CIOLEGEHDAC;
      }
      unk3000NLFPKDOBNCD_.Add(other.unk3000NLFPKDOBNCD_);
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
          case 24: {
            Unk3000CIOLEGEHDAC = input.ReadUInt32();
            break;
          }
          case 122: {
            unk3000NLFPKDOBNCD_.AddEntriesFrom(input, _repeated_unk3000NLFPKDOBNCD_codec);
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
          case 24: {
            Unk3000CIOLEGEHDAC = input.ReadUInt32();
            break;
          }
          case 122: {
            unk3000NLFPKDOBNCD_.AddEntriesFrom(ref input, _repeated_unk3000NLFPKDOBNCD_codec);
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
