// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicGameStartReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from MusicGameStartReq.proto</summary>
  public static partial class MusicGameStartReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicGameStartReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicGameStartReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdNdXNpY0dhbWVTdGFydFJlcS5wcm90byJlChFNdXNpY0dhbWVTdGFydFJl",
            "cRIWCg5tdXNpY19iYXNpY19pZBgCIAEoDRIbChNVbmsyNzAwX0lPS1BJS0pE",
            "RUhHGAsgASgIEhsKE1VuazI3MDBfQ0VQR01LQUhIQ0QYAyABKARCGqoCF1dl",
            "ZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.MusicGameStartReq), global::Weedwacker.Server.Proto.MusicGameStartReq.Parser, new[]{ "MusicBasicId", "Unk2700IOKPIKJDEHG", "Unk2700CEPGMKAHHCD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8406
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class MusicGameStartReq : pb::IMessage<MusicGameStartReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicGameStartReq> _parser = new pb::MessageParser<MusicGameStartReq>(() => new MusicGameStartReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicGameStartReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.MusicGameStartReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameStartReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameStartReq(MusicGameStartReq other) : this() {
      musicBasicId_ = other.musicBasicId_;
      unk2700IOKPIKJDEHG_ = other.unk2700IOKPIKJDEHG_;
      unk2700CEPGMKAHHCD_ = other.unk2700CEPGMKAHHCD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameStartReq Clone() {
      return new MusicGameStartReq(this);
    }

    /// <summary>Field number for the "music_basic_id" field.</summary>
    public const int MusicBasicIdFieldNumber = 2;
    private uint musicBasicId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MusicBasicId {
      get { return musicBasicId_; }
      set {
        musicBasicId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_IOKPIKJDEHG" field.</summary>
    public const int Unk2700IOKPIKJDEHGFieldNumber = 11;
    private bool unk2700IOKPIKJDEHG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700IOKPIKJDEHG {
      get { return unk2700IOKPIKJDEHG_; }
      set {
        unk2700IOKPIKJDEHG_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_CEPGMKAHHCD" field.</summary>
    public const int Unk2700CEPGMKAHHCDFieldNumber = 3;
    private ulong unk2700CEPGMKAHHCD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk2700CEPGMKAHHCD {
      get { return unk2700CEPGMKAHHCD_; }
      set {
        unk2700CEPGMKAHHCD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicGameStartReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicGameStartReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MusicBasicId != other.MusicBasicId) return false;
      if (Unk2700IOKPIKJDEHG != other.Unk2700IOKPIKJDEHG) return false;
      if (Unk2700CEPGMKAHHCD != other.Unk2700CEPGMKAHHCD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MusicBasicId != 0) hash ^= MusicBasicId.GetHashCode();
      if (Unk2700IOKPIKJDEHG != false) hash ^= Unk2700IOKPIKJDEHG.GetHashCode();
      if (Unk2700CEPGMKAHHCD != 0UL) hash ^= Unk2700CEPGMKAHHCD.GetHashCode();
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
      if (MusicBasicId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MusicBasicId);
      }
      if (Unk2700CEPGMKAHHCD != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unk2700CEPGMKAHHCD);
      }
      if (Unk2700IOKPIKJDEHG != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk2700IOKPIKJDEHG);
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
      if (MusicBasicId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MusicBasicId);
      }
      if (Unk2700CEPGMKAHHCD != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unk2700CEPGMKAHHCD);
      }
      if (Unk2700IOKPIKJDEHG != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk2700IOKPIKJDEHG);
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
      if (MusicBasicId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MusicBasicId);
      }
      if (Unk2700IOKPIKJDEHG != false) {
        size += 1 + 1;
      }
      if (Unk2700CEPGMKAHHCD != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk2700CEPGMKAHHCD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicGameStartReq other) {
      if (other == null) {
        return;
      }
      if (other.MusicBasicId != 0) {
        MusicBasicId = other.MusicBasicId;
      }
      if (other.Unk2700IOKPIKJDEHG != false) {
        Unk2700IOKPIKJDEHG = other.Unk2700IOKPIKJDEHG;
      }
      if (other.Unk2700CEPGMKAHHCD != 0UL) {
        Unk2700CEPGMKAHHCD = other.Unk2700CEPGMKAHHCD;
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
          case 16: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk2700CEPGMKAHHCD = input.ReadUInt64();
            break;
          }
          case 88: {
            Unk2700IOKPIKJDEHG = input.ReadBool();
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
          case 16: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk2700CEPGMKAHHCD = input.ReadUInt64();
            break;
          }
          case 88: {
            Unk2700IOKPIKJDEHG = input.ReadBool();
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
