// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_EGKIHLIOLDM.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_EGKIHLIOLDM.proto</summary>
  public static partial class Unk2700EGKIHLIOLDMReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_EGKIHLIOLDM.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700EGKIHLIOLDMReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0VHS0lITElPTERNLnByb3RvGhlVbmsyNzAwX05QT0JQRk5E",
            "SktLLnByb3RvIlgKE1VuazI3MDBfRUdLSUhMSU9MRE0SGwoTVW5rMjcwMF9D",
            "RERPTkpKTUZDSRgOIAEoDRIkCgZyZWFzb24YByABKA4yFC5VbmsyNzAwX05Q",
            "T0JQRk5ESktLQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700NPOBPFNDJKKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_EGKIHLIOLDM), global::Weedwacker.Server.Proto.Unk2700_EGKIHLIOLDM.Parser, new[]{ "Unk2700CDDONJJMFCI", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_EGKIHLIOLDM : pb::IMessage<Unk2700_EGKIHLIOLDM>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_EGKIHLIOLDM> _parser = new pb::MessageParser<Unk2700_EGKIHLIOLDM>(() => new Unk2700_EGKIHLIOLDM());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_EGKIHLIOLDM> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700EGKIHLIOLDMReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_EGKIHLIOLDM() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_EGKIHLIOLDM(Unk2700_EGKIHLIOLDM other) : this() {
      unk2700CDDONJJMFCI_ = other.unk2700CDDONJJMFCI_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_EGKIHLIOLDM Clone() {
      return new Unk2700_EGKIHLIOLDM(this);
    }

    /// <summary>Field number for the "Unk2700_CDDONJJMFCI" field.</summary>
    public const int Unk2700CDDONJJMFCIFieldNumber = 14;
    private uint unk2700CDDONJJMFCI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700CDDONJJMFCI {
      get { return unk2700CDDONJJMFCI_; }
      set {
        unk2700CDDONJJMFCI_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 7;
    private global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK reason_ = global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK.Unk2700Pgicihiambf;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_EGKIHLIOLDM);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_EGKIHLIOLDM other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700CDDONJJMFCI != other.Unk2700CDDONJJMFCI) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700CDDONJJMFCI != 0) hash ^= Unk2700CDDONJJMFCI.GetHashCode();
      if (Reason != global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK.Unk2700Pgicihiambf) hash ^= Reason.GetHashCode();
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
      if (Reason != global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK.Unk2700Pgicihiambf) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Reason);
      }
      if (Unk2700CDDONJJMFCI != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk2700CDDONJJMFCI);
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
      if (Reason != global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK.Unk2700Pgicihiambf) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Reason);
      }
      if (Unk2700CDDONJJMFCI != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk2700CDDONJJMFCI);
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
      if (Unk2700CDDONJJMFCI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700CDDONJJMFCI);
      }
      if (Reason != global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK.Unk2700Pgicihiambf) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_EGKIHLIOLDM other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700CDDONJJMFCI != 0) {
        Unk2700CDDONJJMFCI = other.Unk2700CDDONJJMFCI;
      }
      if (other.Reason != global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK.Unk2700Pgicihiambf) {
        Reason = other.Reason;
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
          case 56: {
            Reason = (global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK) input.ReadEnum();
            break;
          }
          case 112: {
            Unk2700CDDONJJMFCI = input.ReadUInt32();
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
          case 56: {
            Reason = (global::Weedwacker.Server.Proto.Unk2700_NPOBPFNDJKK) input.ReadEnum();
            break;
          }
          case 112: {
            Unk2700CDDONJJMFCI = input.ReadUInt32();
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
