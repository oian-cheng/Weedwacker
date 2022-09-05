// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FurnitureMakeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from FurnitureMakeRsp.proto</summary>
  public static partial class FurnitureMakeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for FurnitureMakeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FurnitureMakeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGdXJuaXR1cmVNYWtlUnNwLnByb3RvGh9GdXJuaXR1cmVNYWtlQmVIZWxw",
            "ZWREYXRhLnByb3RvGhtGdXJuaXR1cmVNYWtlSGVscERhdGEucHJvdG8aG0Z1",
            "cm5pdHVyZU1ha2VNYWtlSW5mby5wcm90bxoXRnVybml0dXJlTWFrZVNsb3Qu",
            "cHJvdG8i6gEKEEZ1cm5pdHVyZU1ha2VSc3ASNAoQaGVscGVkX2RhdGFfbGlz",
            "dBgNIAMoCzIaLkZ1cm5pdHVyZU1ha2VCZUhlbHBlZERhdGESLgoObWFrZV9p",
            "bmZvX2xpc3QYBCADKAsyFi5GdXJuaXR1cmVNYWtlTWFrZUluZm8SLwoTZnVy",
            "bml0dXJlX21ha2Vfc2xvdBgBIAEoCzISLkZ1cm5pdHVyZU1ha2VTbG90Eg8K",
            "B3JldGNvZGUYAyABKAUSLgoOaGVscF9kYXRhX2xpc3QYAiADKAsyFi5GdXJu",
            "aXR1cmVNYWtlSGVscERhdGFCGqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.FurnitureMakeBeHelpedDataReflection.Descriptor, global::Weedwacker.Server.Proto.FurnitureMakeHelpDataReflection.Descriptor, global::Weedwacker.Server.Proto.FurnitureMakeMakeInfoReflection.Descriptor, global::Weedwacker.Server.Proto.FurnitureMakeSlotReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.FurnitureMakeRsp), global::Weedwacker.Server.Proto.FurnitureMakeRsp.Parser, new[]{ "HelpedDataList", "MakeInfoList", "FurnitureMakeSlot", "Retcode", "HelpDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4782
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class FurnitureMakeRsp : pb::IMessage<FurnitureMakeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FurnitureMakeRsp> _parser = new pb::MessageParser<FurnitureMakeRsp>(() => new FurnitureMakeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FurnitureMakeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.FurnitureMakeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeRsp(FurnitureMakeRsp other) : this() {
      helpedDataList_ = other.helpedDataList_.Clone();
      makeInfoList_ = other.makeInfoList_.Clone();
      furnitureMakeSlot_ = other.furnitureMakeSlot_ != null ? other.furnitureMakeSlot_.Clone() : null;
      retcode_ = other.retcode_;
      helpDataList_ = other.helpDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeRsp Clone() {
      return new FurnitureMakeRsp(this);
    }

    /// <summary>Field number for the "helped_data_list" field.</summary>
    public const int HelpedDataListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.FurnitureMakeBeHelpedData> _repeated_helpedDataList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Server.Proto.FurnitureMakeBeHelpedData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeBeHelpedData> helpedDataList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeBeHelpedData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeBeHelpedData> HelpedDataList {
      get { return helpedDataList_; }
    }

    /// <summary>Field number for the "make_info_list" field.</summary>
    public const int MakeInfoListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.FurnitureMakeMakeInfo> _repeated_makeInfoList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Server.Proto.FurnitureMakeMakeInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeMakeInfo> makeInfoList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeMakeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeMakeInfo> MakeInfoList {
      get { return makeInfoList_; }
    }

    /// <summary>Field number for the "furniture_make_slot" field.</summary>
    public const int FurnitureMakeSlotFieldNumber = 1;
    private global::Weedwacker.Server.Proto.FurnitureMakeSlot furnitureMakeSlot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.FurnitureMakeSlot FurnitureMakeSlot {
      get { return furnitureMakeSlot_; }
      set {
        furnitureMakeSlot_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "help_data_list" field.</summary>
    public const int HelpDataListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.FurnitureMakeHelpData> _repeated_helpDataList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Server.Proto.FurnitureMakeHelpData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeHelpData> helpDataList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeHelpData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.FurnitureMakeHelpData> HelpDataList {
      get { return helpDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FurnitureMakeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FurnitureMakeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!helpedDataList_.Equals(other.helpedDataList_)) return false;
      if(!makeInfoList_.Equals(other.makeInfoList_)) return false;
      if (!object.Equals(FurnitureMakeSlot, other.FurnitureMakeSlot)) return false;
      if (Retcode != other.Retcode) return false;
      if(!helpDataList_.Equals(other.helpDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= helpedDataList_.GetHashCode();
      hash ^= makeInfoList_.GetHashCode();
      if (furnitureMakeSlot_ != null) hash ^= FurnitureMakeSlot.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= helpDataList_.GetHashCode();
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
      if (furnitureMakeSlot_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FurnitureMakeSlot);
      }
      helpDataList_.WriteTo(output, _repeated_helpDataList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Retcode);
      }
      makeInfoList_.WriteTo(output, _repeated_makeInfoList_codec);
      helpedDataList_.WriteTo(output, _repeated_helpedDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (furnitureMakeSlot_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FurnitureMakeSlot);
      }
      helpDataList_.WriteTo(ref output, _repeated_helpDataList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Retcode);
      }
      makeInfoList_.WriteTo(ref output, _repeated_makeInfoList_codec);
      helpedDataList_.WriteTo(ref output, _repeated_helpedDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += helpedDataList_.CalculateSize(_repeated_helpedDataList_codec);
      size += makeInfoList_.CalculateSize(_repeated_makeInfoList_codec);
      if (furnitureMakeSlot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FurnitureMakeSlot);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += helpDataList_.CalculateSize(_repeated_helpDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FurnitureMakeRsp other) {
      if (other == null) {
        return;
      }
      helpedDataList_.Add(other.helpedDataList_);
      makeInfoList_.Add(other.makeInfoList_);
      if (other.furnitureMakeSlot_ != null) {
        if (furnitureMakeSlot_ == null) {
          FurnitureMakeSlot = new global::Weedwacker.Server.Proto.FurnitureMakeSlot();
        }
        FurnitureMakeSlot.MergeFrom(other.FurnitureMakeSlot);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      helpDataList_.Add(other.helpDataList_);
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
          case 10: {
            if (furnitureMakeSlot_ == null) {
              FurnitureMakeSlot = new global::Weedwacker.Server.Proto.FurnitureMakeSlot();
            }
            input.ReadMessage(FurnitureMakeSlot);
            break;
          }
          case 18: {
            helpDataList_.AddEntriesFrom(input, _repeated_helpDataList_codec);
            break;
          }
          case 24: {
            Retcode = input.ReadInt32();
            break;
          }
          case 34: {
            makeInfoList_.AddEntriesFrom(input, _repeated_makeInfoList_codec);
            break;
          }
          case 106: {
            helpedDataList_.AddEntriesFrom(input, _repeated_helpedDataList_codec);
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
          case 10: {
            if (furnitureMakeSlot_ == null) {
              FurnitureMakeSlot = new global::Weedwacker.Server.Proto.FurnitureMakeSlot();
            }
            input.ReadMessage(FurnitureMakeSlot);
            break;
          }
          case 18: {
            helpDataList_.AddEntriesFrom(ref input, _repeated_helpDataList_codec);
            break;
          }
          case 24: {
            Retcode = input.ReadInt32();
            break;
          }
          case 34: {
            makeInfoList_.AddEntriesFrom(ref input, _repeated_makeInfoList_codec);
            break;
          }
          case 106: {
            helpedDataList_.AddEntriesFrom(ref input, _repeated_helpedDataList_codec);
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
