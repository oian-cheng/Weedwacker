// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2800_OMGNOBICOCD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2800_OMGNOBICOCD.proto</summary>
  public static partial class Unk2800OMGNOBICOCDReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2800_OMGNOBICOCD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2800OMGNOBICOCDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyODAwX09NR05PQklDT0NELnByb3RvGhpDdXN0b21HYWRnZXRUcmVl",
            "SW5mby5wcm90byKAAQoTVW5rMjgwMF9PTUdOT0JJQ09DRBIbChNVbmsyODAw",
            "X0RQRU9JSktFQVBCGA4gASgNEjIKE1VuazI3MDBfT0NJSEpGT0tIUEsYCyAB",
            "KAsyFS5DdXN0b21HYWRnZXRUcmVlSW5mbxIYChBnYWRnZXRfZW50aXR5X2lk",
            "GAogASgNQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.CustomGadgetTreeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2800_OMGNOBICOCD), global::Weedwacker.Server.Proto.Unk2800_OMGNOBICOCD.Parser, new[]{ "Unk2800DPEOIJKEAPB", "Unk2700OCIHJFOKHPK", "GadgetEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 843
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2800_OMGNOBICOCD : pb::IMessage<Unk2800_OMGNOBICOCD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2800_OMGNOBICOCD> _parser = new pb::MessageParser<Unk2800_OMGNOBICOCD>(() => new Unk2800_OMGNOBICOCD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2800_OMGNOBICOCD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2800OMGNOBICOCDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_OMGNOBICOCD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_OMGNOBICOCD(Unk2800_OMGNOBICOCD other) : this() {
      unk2800DPEOIJKEAPB_ = other.unk2800DPEOIJKEAPB_;
      unk2700OCIHJFOKHPK_ = other.unk2700OCIHJFOKHPK_ != null ? other.unk2700OCIHJFOKHPK_.Clone() : null;
      gadgetEntityId_ = other.gadgetEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_OMGNOBICOCD Clone() {
      return new Unk2800_OMGNOBICOCD(this);
    }

    /// <summary>Field number for the "Unk2800_DPEOIJKEAPB" field.</summary>
    public const int Unk2800DPEOIJKEAPBFieldNumber = 14;
    private uint unk2800DPEOIJKEAPB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2800DPEOIJKEAPB {
      get { return unk2800DPEOIJKEAPB_; }
      set {
        unk2800DPEOIJKEAPB_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_OCIHJFOKHPK" field.</summary>
    public const int Unk2700OCIHJFOKHPKFieldNumber = 11;
    private global::Weedwacker.Server.Proto.CustomGadgetTreeInfo unk2700OCIHJFOKHPK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.CustomGadgetTreeInfo Unk2700OCIHJFOKHPK {
      get { return unk2700OCIHJFOKHPK_; }
      set {
        unk2700OCIHJFOKHPK_ = value;
      }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 10;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2800_OMGNOBICOCD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2800_OMGNOBICOCD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2800DPEOIJKEAPB != other.Unk2800DPEOIJKEAPB) return false;
      if (!object.Equals(Unk2700OCIHJFOKHPK, other.Unk2700OCIHJFOKHPK)) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2800DPEOIJKEAPB != 0) hash ^= Unk2800DPEOIJKEAPB.GetHashCode();
      if (unk2700OCIHJFOKHPK_ != null) hash ^= Unk2700OCIHJFOKHPK.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
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
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (unk2700OCIHJFOKHPK_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Unk2700OCIHJFOKHPK);
      }
      if (Unk2800DPEOIJKEAPB != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk2800DPEOIJKEAPB);
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
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (unk2700OCIHJFOKHPK_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Unk2700OCIHJFOKHPK);
      }
      if (Unk2800DPEOIJKEAPB != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk2800DPEOIJKEAPB);
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
      if (Unk2800DPEOIJKEAPB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2800DPEOIJKEAPB);
      }
      if (unk2700OCIHJFOKHPK_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700OCIHJFOKHPK);
      }
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2800_OMGNOBICOCD other) {
      if (other == null) {
        return;
      }
      if (other.Unk2800DPEOIJKEAPB != 0) {
        Unk2800DPEOIJKEAPB = other.Unk2800DPEOIJKEAPB;
      }
      if (other.unk2700OCIHJFOKHPK_ != null) {
        if (unk2700OCIHJFOKHPK_ == null) {
          Unk2700OCIHJFOKHPK = new global::Weedwacker.Server.Proto.CustomGadgetTreeInfo();
        }
        Unk2700OCIHJFOKHPK.MergeFrom(other.Unk2700OCIHJFOKHPK);
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
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
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (unk2700OCIHJFOKHPK_ == null) {
              Unk2700OCIHJFOKHPK = new global::Weedwacker.Server.Proto.CustomGadgetTreeInfo();
            }
            input.ReadMessage(Unk2700OCIHJFOKHPK);
            break;
          }
          case 112: {
            Unk2800DPEOIJKEAPB = input.ReadUInt32();
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
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (unk2700OCIHJFOKHPK_ == null) {
              Unk2700OCIHJFOKHPK = new global::Weedwacker.Server.Proto.CustomGadgetTreeInfo();
            }
            input.ReadMessage(Unk2700OCIHJFOKHPK);
            break;
          }
          case 112: {
            Unk2800DPEOIJKEAPB = input.ReadUInt32();
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
