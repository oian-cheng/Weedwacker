// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_KJNIKBPKAED.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_KJNIKBPKAED.proto</summary>
  public static partial class Unk3000KJNIKBPKAEDReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_KJNIKBPKAED.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000KJNIKBPKAEDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0tKTklLQlBLQUVELnByb3RvImAKE1VuazMwMDBfS0pOSUtC",
            "UEtBRUQSDwoHcmV0Y29kZRgFIAEoBRIbChNVbmszMDAwX0NGRE1MR0tOTEtM",
            "GA4gASgNEhsKE1VuazMwMDBfQ0lPTEVHRUhEQUMYDSABKA1CGqoCF1dlZWR3",
            "YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk3000_KJNIKBPKAED), global::Weedwacker.Server.Proto.Unk3000_KJNIKBPKAED.Parser, new[]{ "Retcode", "Unk3000CFDMLGKNLKL", "Unk3000CIOLEGEHDAC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 461
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk3000_KJNIKBPKAED : pb::IMessage<Unk3000_KJNIKBPKAED>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_KJNIKBPKAED> _parser = new pb::MessageParser<Unk3000_KJNIKBPKAED>(() => new Unk3000_KJNIKBPKAED());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_KJNIKBPKAED> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk3000KJNIKBPKAEDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_KJNIKBPKAED() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_KJNIKBPKAED(Unk3000_KJNIKBPKAED other) : this() {
      retcode_ = other.retcode_;
      unk3000CFDMLGKNLKL_ = other.unk3000CFDMLGKNLKL_;
      unk3000CIOLEGEHDAC_ = other.unk3000CIOLEGEHDAC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_KJNIKBPKAED Clone() {
      return new Unk3000_KJNIKBPKAED(this);
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

    /// <summary>Field number for the "Unk3000_CFDMLGKNLKL" field.</summary>
    public const int Unk3000CFDMLGKNLKLFieldNumber = 14;
    private uint unk3000CFDMLGKNLKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000CFDMLGKNLKL {
      get { return unk3000CFDMLGKNLKL_; }
      set {
        unk3000CFDMLGKNLKL_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_CIOLEGEHDAC" field.</summary>
    public const int Unk3000CIOLEGEHDACFieldNumber = 13;
    private uint unk3000CIOLEGEHDAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000CIOLEGEHDAC {
      get { return unk3000CIOLEGEHDAC_; }
      set {
        unk3000CIOLEGEHDAC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_KJNIKBPKAED);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_KJNIKBPKAED other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (Unk3000CFDMLGKNLKL != other.Unk3000CFDMLGKNLKL) return false;
      if (Unk3000CIOLEGEHDAC != other.Unk3000CIOLEGEHDAC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk3000CFDMLGKNLKL != 0) hash ^= Unk3000CFDMLGKNLKL.GetHashCode();
      if (Unk3000CIOLEGEHDAC != 0) hash ^= Unk3000CIOLEGEHDAC.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (Unk3000CIOLEGEHDAC != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3000CIOLEGEHDAC);
      }
      if (Unk3000CFDMLGKNLKL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3000CFDMLGKNLKL);
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
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (Unk3000CIOLEGEHDAC != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3000CIOLEGEHDAC);
      }
      if (Unk3000CFDMLGKNLKL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3000CFDMLGKNLKL);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk3000CFDMLGKNLKL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000CFDMLGKNLKL);
      }
      if (Unk3000CIOLEGEHDAC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000CIOLEGEHDAC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_KJNIKBPKAED other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk3000CFDMLGKNLKL != 0) {
        Unk3000CFDMLGKNLKL = other.Unk3000CFDMLGKNLKL;
      }
      if (other.Unk3000CIOLEGEHDAC != 0) {
        Unk3000CIOLEGEHDAC = other.Unk3000CIOLEGEHDAC;
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
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 104: {
            Unk3000CIOLEGEHDAC = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3000CFDMLGKNLKL = input.ReadUInt32();
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
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 104: {
            Unk3000CIOLEGEHDAC = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3000CFDMLGKNLKL = input.ReadUInt32();
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
