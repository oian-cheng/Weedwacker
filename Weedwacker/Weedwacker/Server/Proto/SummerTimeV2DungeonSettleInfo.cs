// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SummerTimeV2DungeonSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from SummerTimeV2DungeonSettleInfo.proto</summary>
  public static partial class SummerTimeV2DungeonSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SummerTimeV2DungeonSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SummerTimeV2DungeonSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNTdW1tZXJUaW1lVjJEdW5nZW9uU2V0dGxlSW5mby5wcm90byJtCh1TdW1t",
            "ZXJUaW1lVjJEdW5nZW9uU2V0dGxlSW5mbxISCgppc19zdWNjZXNzGAUgASgI",
            "EhsKE1VuazI4MDBfRUxIQkNOUEtPSkcYAiABKA0SGwoTVW5rMjgwMF9IREVG",
            "SktHRE5FSBgLIAEoDUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.SummerTimeV2DungeonSettleInfo), global::Weedwacker.Server.Proto.SummerTimeV2DungeonSettleInfo.Parser, new[]{ "IsSuccess", "Unk2800ELHBCNPKOJG", "Unk2800HDEFJKGDNEH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SummerTimeV2DungeonSettleInfo : pb::IMessage<SummerTimeV2DungeonSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SummerTimeV2DungeonSettleInfo> _parser = new pb::MessageParser<SummerTimeV2DungeonSettleInfo>(() => new SummerTimeV2DungeonSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SummerTimeV2DungeonSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.SummerTimeV2DungeonSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeV2DungeonSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeV2DungeonSettleInfo(SummerTimeV2DungeonSettleInfo other) : this() {
      isSuccess_ = other.isSuccess_;
      unk2800ELHBCNPKOJG_ = other.unk2800ELHBCNPKOJG_;
      unk2800HDEFJKGDNEH_ = other.unk2800HDEFJKGDNEH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeV2DungeonSettleInfo Clone() {
      return new SummerTimeV2DungeonSettleInfo(this);
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 5;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_ELHBCNPKOJG" field.</summary>
    public const int Unk2800ELHBCNPKOJGFieldNumber = 2;
    private uint unk2800ELHBCNPKOJG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2800ELHBCNPKOJG {
      get { return unk2800ELHBCNPKOJG_; }
      set {
        unk2800ELHBCNPKOJG_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_HDEFJKGDNEH" field.</summary>
    public const int Unk2800HDEFJKGDNEHFieldNumber = 11;
    private uint unk2800HDEFJKGDNEH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2800HDEFJKGDNEH {
      get { return unk2800HDEFJKGDNEH_; }
      set {
        unk2800HDEFJKGDNEH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SummerTimeV2DungeonSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SummerTimeV2DungeonSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if (Unk2800ELHBCNPKOJG != other.Unk2800ELHBCNPKOJG) return false;
      if (Unk2800HDEFJKGDNEH != other.Unk2800HDEFJKGDNEH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (Unk2800ELHBCNPKOJG != 0) hash ^= Unk2800ELHBCNPKOJG.GetHashCode();
      if (Unk2800HDEFJKGDNEH != 0) hash ^= Unk2800HDEFJKGDNEH.GetHashCode();
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
      if (Unk2800ELHBCNPKOJG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk2800ELHBCNPKOJG);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSuccess);
      }
      if (Unk2800HDEFJKGDNEH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk2800HDEFJKGDNEH);
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
      if (Unk2800ELHBCNPKOJG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk2800ELHBCNPKOJG);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSuccess);
      }
      if (Unk2800HDEFJKGDNEH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk2800HDEFJKGDNEH);
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
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (Unk2800ELHBCNPKOJG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2800ELHBCNPKOJG);
      }
      if (Unk2800HDEFJKGDNEH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2800HDEFJKGDNEH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SummerTimeV2DungeonSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.Unk2800ELHBCNPKOJG != 0) {
        Unk2800ELHBCNPKOJG = other.Unk2800ELHBCNPKOJG;
      }
      if (other.Unk2800HDEFJKGDNEH != 0) {
        Unk2800HDEFJKGDNEH = other.Unk2800HDEFJKGDNEH;
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
            Unk2800ELHBCNPKOJG = input.ReadUInt32();
            break;
          }
          case 40: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 88: {
            Unk2800HDEFJKGDNEH = input.ReadUInt32();
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
            Unk2800ELHBCNPKOJG = input.ReadUInt32();
            break;
          }
          case 40: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 88: {
            Unk2800HDEFJKGDNEH = input.ReadUInt32();
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
