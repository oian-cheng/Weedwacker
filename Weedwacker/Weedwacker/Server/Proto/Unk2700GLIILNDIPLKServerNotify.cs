// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_GLIILNDIPLK_ServerNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_GLIILNDIPLK_ServerNotify.proto</summary>
  public static partial class Unk2700GLIILNDIPLKServerNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_GLIILNDIPLK_ServerNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700GLIILNDIPLKServerNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZVbmsyNzAwX0dMSUlMTkRJUExLX1NlcnZlck5vdGlmeS5wcm90byJ5CiBV",
            "bmsyNzAwX0dMSUlMTkRJUExLX1NlcnZlck5vdGlmeRIbChNVbmsyNzAwX0xB",
            "TElFQUJERkZJGAwgASgIEhsKE1VuazI3MDBfRENMSEZJTkpFT0QYCCABKAgS",
            "GwoTVW5rMjcwMF9HTUlDRkFETEFNQxgPIAEoCEIaqgIXV2VlZHdhY2tlci5T",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_GLIILNDIPLK_ServerNotify), global::Weedwacker.Server.Proto.Unk2700_GLIILNDIPLK_ServerNotify.Parser, new[]{ "Unk2700LALIEABDFFI", "Unk2700DCLHFINJEOD", "Unk2700GMICFADLAMC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6341
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_GLIILNDIPLK_ServerNotify : pb::IMessage<Unk2700_GLIILNDIPLK_ServerNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_GLIILNDIPLK_ServerNotify> _parser = new pb::MessageParser<Unk2700_GLIILNDIPLK_ServerNotify>(() => new Unk2700_GLIILNDIPLK_ServerNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_GLIILNDIPLK_ServerNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700GLIILNDIPLKServerNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GLIILNDIPLK_ServerNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GLIILNDIPLK_ServerNotify(Unk2700_GLIILNDIPLK_ServerNotify other) : this() {
      unk2700LALIEABDFFI_ = other.unk2700LALIEABDFFI_;
      unk2700DCLHFINJEOD_ = other.unk2700DCLHFINJEOD_;
      unk2700GMICFADLAMC_ = other.unk2700GMICFADLAMC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GLIILNDIPLK_ServerNotify Clone() {
      return new Unk2700_GLIILNDIPLK_ServerNotify(this);
    }

    /// <summary>Field number for the "Unk2700_LALIEABDFFI" field.</summary>
    public const int Unk2700LALIEABDFFIFieldNumber = 12;
    private bool unk2700LALIEABDFFI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700LALIEABDFFI {
      get { return unk2700LALIEABDFFI_; }
      set {
        unk2700LALIEABDFFI_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_DCLHFINJEOD" field.</summary>
    public const int Unk2700DCLHFINJEODFieldNumber = 8;
    private bool unk2700DCLHFINJEOD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700DCLHFINJEOD {
      get { return unk2700DCLHFINJEOD_; }
      set {
        unk2700DCLHFINJEOD_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_GMICFADLAMC" field.</summary>
    public const int Unk2700GMICFADLAMCFieldNumber = 15;
    private bool unk2700GMICFADLAMC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700GMICFADLAMC {
      get { return unk2700GMICFADLAMC_; }
      set {
        unk2700GMICFADLAMC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_GLIILNDIPLK_ServerNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_GLIILNDIPLK_ServerNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700LALIEABDFFI != other.Unk2700LALIEABDFFI) return false;
      if (Unk2700DCLHFINJEOD != other.Unk2700DCLHFINJEOD) return false;
      if (Unk2700GMICFADLAMC != other.Unk2700GMICFADLAMC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700LALIEABDFFI != false) hash ^= Unk2700LALIEABDFFI.GetHashCode();
      if (Unk2700DCLHFINJEOD != false) hash ^= Unk2700DCLHFINJEOD.GetHashCode();
      if (Unk2700GMICFADLAMC != false) hash ^= Unk2700GMICFADLAMC.GetHashCode();
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
      if (Unk2700DCLHFINJEOD != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk2700DCLHFINJEOD);
      }
      if (Unk2700LALIEABDFFI != false) {
        output.WriteRawTag(96);
        output.WriteBool(Unk2700LALIEABDFFI);
      }
      if (Unk2700GMICFADLAMC != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk2700GMICFADLAMC);
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
      if (Unk2700DCLHFINJEOD != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk2700DCLHFINJEOD);
      }
      if (Unk2700LALIEABDFFI != false) {
        output.WriteRawTag(96);
        output.WriteBool(Unk2700LALIEABDFFI);
      }
      if (Unk2700GMICFADLAMC != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk2700GMICFADLAMC);
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
      if (Unk2700LALIEABDFFI != false) {
        size += 1 + 1;
      }
      if (Unk2700DCLHFINJEOD != false) {
        size += 1 + 1;
      }
      if (Unk2700GMICFADLAMC != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_GLIILNDIPLK_ServerNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700LALIEABDFFI != false) {
        Unk2700LALIEABDFFI = other.Unk2700LALIEABDFFI;
      }
      if (other.Unk2700DCLHFINJEOD != false) {
        Unk2700DCLHFINJEOD = other.Unk2700DCLHFINJEOD;
      }
      if (other.Unk2700GMICFADLAMC != false) {
        Unk2700GMICFADLAMC = other.Unk2700GMICFADLAMC;
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
          case 64: {
            Unk2700DCLHFINJEOD = input.ReadBool();
            break;
          }
          case 96: {
            Unk2700LALIEABDFFI = input.ReadBool();
            break;
          }
          case 120: {
            Unk2700GMICFADLAMC = input.ReadBool();
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
          case 64: {
            Unk2700DCLHFINJEOD = input.ReadBool();
            break;
          }
          case 96: {
            Unk2700LALIEABDFFI = input.ReadBool();
            break;
          }
          case 120: {
            Unk2700GMICFADLAMC = input.ReadBool();
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
