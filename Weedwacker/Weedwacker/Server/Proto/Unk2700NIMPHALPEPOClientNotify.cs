// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_NIMPHALPEPO_ClientNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_NIMPHALPEPO_ClientNotify.proto</summary>
  public static partial class Unk2700NIMPHALPEPOClientNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_NIMPHALPEPO_ClientNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700NIMPHALPEPOClientNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZVbmsyNzAwX05JTVBIQUxQRVBPX0NsaWVudE5vdGlmeS5wcm90byJcCiBV",
            "bmsyNzAwX05JTVBIQUxQRVBPX0NsaWVudE5vdGlmeRIbChNVbmsyNzAwX01L",
            "SU1GS0lHQkNMGA0gASgNEhsKE1VuazI3MDBfT05PT0pCRUFCT0UYDCABKARC",
            "GqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_NIMPHALPEPO_ClientNotify), global::Weedwacker.Server.Proto.Unk2700_NIMPHALPEPO_ClientNotify.Parser, new[]{ "Unk2700MKIMFKIGBCL", "Unk2700ONOOJBEABOE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6236
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_NIMPHALPEPO_ClientNotify : pb::IMessage<Unk2700_NIMPHALPEPO_ClientNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_NIMPHALPEPO_ClientNotify> _parser = new pb::MessageParser<Unk2700_NIMPHALPEPO_ClientNotify>(() => new Unk2700_NIMPHALPEPO_ClientNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_NIMPHALPEPO_ClientNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700NIMPHALPEPOClientNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NIMPHALPEPO_ClientNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NIMPHALPEPO_ClientNotify(Unk2700_NIMPHALPEPO_ClientNotify other) : this() {
      unk2700MKIMFKIGBCL_ = other.unk2700MKIMFKIGBCL_;
      unk2700ONOOJBEABOE_ = other.unk2700ONOOJBEABOE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NIMPHALPEPO_ClientNotify Clone() {
      return new Unk2700_NIMPHALPEPO_ClientNotify(this);
    }

    /// <summary>Field number for the "Unk2700_MKIMFKIGBCL" field.</summary>
    public const int Unk2700MKIMFKIGBCLFieldNumber = 13;
    private uint unk2700MKIMFKIGBCL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700MKIMFKIGBCL {
      get { return unk2700MKIMFKIGBCL_; }
      set {
        unk2700MKIMFKIGBCL_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_ONOOJBEABOE" field.</summary>
    public const int Unk2700ONOOJBEABOEFieldNumber = 12;
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
      return Equals(other as Unk2700_NIMPHALPEPO_ClientNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_NIMPHALPEPO_ClientNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700MKIMFKIGBCL != other.Unk2700MKIMFKIGBCL) return false;
      if (Unk2700ONOOJBEABOE != other.Unk2700ONOOJBEABOE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700MKIMFKIGBCL != 0) hash ^= Unk2700MKIMFKIGBCL.GetHashCode();
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
      if (Unk2700ONOOJBEABOE != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(Unk2700ONOOJBEABOE);
      }
      if (Unk2700MKIMFKIGBCL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk2700MKIMFKIGBCL);
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
      if (Unk2700ONOOJBEABOE != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(Unk2700ONOOJBEABOE);
      }
      if (Unk2700MKIMFKIGBCL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk2700MKIMFKIGBCL);
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
      if (Unk2700MKIMFKIGBCL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700MKIMFKIGBCL);
      }
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
    public void MergeFrom(Unk2700_NIMPHALPEPO_ClientNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700MKIMFKIGBCL != 0) {
        Unk2700MKIMFKIGBCL = other.Unk2700MKIMFKIGBCL;
      }
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
          case 96: {
            Unk2700ONOOJBEABOE = input.ReadUInt64();
            break;
          }
          case 104: {
            Unk2700MKIMFKIGBCL = input.ReadUInt32();
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
          case 96: {
            Unk2700ONOOJBEABOE = input.ReadUInt64();
            break;
          }
          case 104: {
            Unk2700MKIMFKIGBCL = input.ReadUInt32();
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
