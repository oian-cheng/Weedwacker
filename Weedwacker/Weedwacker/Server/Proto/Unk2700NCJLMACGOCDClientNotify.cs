// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_NCJLMACGOCD_ClientNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_NCJLMACGOCD_ClientNotify.proto</summary>
  public static partial class Unk2700NCJLMACGOCDClientNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_NCJLMACGOCD_ClientNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700NCJLMACGOCDClientNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZVbmsyNzAwX05DSkxNQUNHT0NEX0NsaWVudE5vdGlmeS5wcm90byJwCiBV",
            "bmsyNzAwX05DSkxNQUNHT0NEX0NsaWVudE5vdGlmeRIbChNVbmsyNzAwX0ND",
            "UEFMTU1GREZDGAUgASgNEhsKE1VuazI3MDBfTkVNT0VJRkhJRkMYCiABKA0S",
            "EgoKZHVuZ2Vvbl9pZBgDIAEoDUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_NCJLMACGOCD_ClientNotify), global::Weedwacker.Server.Proto.Unk2700_NCJLMACGOCD_ClientNotify.Parser, new[]{ "Unk2700CCPALMMFDFC", "Unk2700NEMOEIFHIFC", "DungeonId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 933
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_NCJLMACGOCD_ClientNotify : pb::IMessage<Unk2700_NCJLMACGOCD_ClientNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_NCJLMACGOCD_ClientNotify> _parser = new pb::MessageParser<Unk2700_NCJLMACGOCD_ClientNotify>(() => new Unk2700_NCJLMACGOCD_ClientNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_NCJLMACGOCD_ClientNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700NCJLMACGOCDClientNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NCJLMACGOCD_ClientNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NCJLMACGOCD_ClientNotify(Unk2700_NCJLMACGOCD_ClientNotify other) : this() {
      unk2700CCPALMMFDFC_ = other.unk2700CCPALMMFDFC_;
      unk2700NEMOEIFHIFC_ = other.unk2700NEMOEIFHIFC_;
      dungeonId_ = other.dungeonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NCJLMACGOCD_ClientNotify Clone() {
      return new Unk2700_NCJLMACGOCD_ClientNotify(this);
    }

    /// <summary>Field number for the "Unk2700_CCPALMMFDFC" field.</summary>
    public const int Unk2700CCPALMMFDFCFieldNumber = 5;
    private uint unk2700CCPALMMFDFC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700CCPALMMFDFC {
      get { return unk2700CCPALMMFDFC_; }
      set {
        unk2700CCPALMMFDFC_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_NEMOEIFHIFC" field.</summary>
    public const int Unk2700NEMOEIFHIFCFieldNumber = 10;
    private uint unk2700NEMOEIFHIFC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700NEMOEIFHIFC {
      get { return unk2700NEMOEIFHIFC_; }
      set {
        unk2700NEMOEIFHIFC_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 3;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_NCJLMACGOCD_ClientNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_NCJLMACGOCD_ClientNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700CCPALMMFDFC != other.Unk2700CCPALMMFDFC) return false;
      if (Unk2700NEMOEIFHIFC != other.Unk2700NEMOEIFHIFC) return false;
      if (DungeonId != other.DungeonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700CCPALMMFDFC != 0) hash ^= Unk2700CCPALMMFDFC.GetHashCode();
      if (Unk2700NEMOEIFHIFC != 0) hash ^= Unk2700NEMOEIFHIFC.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
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
      if (DungeonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonId);
      }
      if (Unk2700CCPALMMFDFC != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk2700CCPALMMFDFC);
      }
      if (Unk2700NEMOEIFHIFC != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2700NEMOEIFHIFC);
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
      if (DungeonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonId);
      }
      if (Unk2700CCPALMMFDFC != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk2700CCPALMMFDFC);
      }
      if (Unk2700NEMOEIFHIFC != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk2700NEMOEIFHIFC);
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
      if (Unk2700CCPALMMFDFC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700CCPALMMFDFC);
      }
      if (Unk2700NEMOEIFHIFC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700NEMOEIFHIFC);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_NCJLMACGOCD_ClientNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700CCPALMMFDFC != 0) {
        Unk2700CCPALMMFDFC = other.Unk2700CCPALMMFDFC;
      }
      if (other.Unk2700NEMOEIFHIFC != 0) {
        Unk2700NEMOEIFHIFC = other.Unk2700NEMOEIFHIFC;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
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
          case 24: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk2700CCPALMMFDFC = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700NEMOEIFHIFC = input.ReadUInt32();
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
            DungeonId = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk2700CCPALMMFDFC = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk2700NEMOEIFHIFC = input.ReadUInt32();
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
