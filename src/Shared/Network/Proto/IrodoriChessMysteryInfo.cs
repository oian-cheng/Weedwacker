// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriChessMysteryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from IrodoriChessMysteryInfo.proto</summary>
  public static partial class IrodoriChessMysteryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for IrodoriChessMysteryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IrodoriChessMysteryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Jcm9kb3JpQ2hlc3NNeXN0ZXJ5SW5mby5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90bxokSXJvZG9yaUNoZXNzRW50cmFuY2VEZXRh",
            "aWxJbmZvLnByb3RvIrQBChdJcm9kb3JpQ2hlc3NNeXN0ZXJ5SW5mbxJdChRl",
            "bnRyYW5jZV9kZXRhaWxfaW5mbxgDIAEoCzI/LldlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8uSXJvZG9yaUNoZXNzRW50cmFuY2VEZXRhaWxJbmZv",
            "EhoKEmV4aXRfcG9pbnRfaWRfbGlzdBgOIAMoDRIeChZlbnRyYW5jZV9wb2lu",
            "dF9pZF9saXN0GAsgAygNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.IrodoriChessEntranceDetailInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfo), global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfo.Parser, new[]{ "EntranceDetailInfo", "ExitPointIdList", "EntrancePointIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IrodoriChessMysteryInfo : pb::IMessage<IrodoriChessMysteryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IrodoriChessMysteryInfo> _parser = new pb::MessageParser<IrodoriChessMysteryInfo>(() => new IrodoriChessMysteryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IrodoriChessMysteryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessMysteryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessMysteryInfo(IrodoriChessMysteryInfo other) : this() {
      entranceDetailInfo_ = other.entranceDetailInfo_ != null ? other.entranceDetailInfo_.Clone() : null;
      exitPointIdList_ = other.exitPointIdList_.Clone();
      entrancePointIdList_ = other.entrancePointIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessMysteryInfo Clone() {
      return new IrodoriChessMysteryInfo(this);
    }

    /// <summary>Field number for the "entrance_detail_info" field.</summary>
    public const int EntranceDetailInfoFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.IrodoriChessEntranceDetailInfo entranceDetailInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.IrodoriChessEntranceDetailInfo EntranceDetailInfo {
      get { return entranceDetailInfo_; }
      set {
        entranceDetailInfo_ = value;
      }
    }

    /// <summary>Field number for the "exit_point_id_list" field.</summary>
    public const int ExitPointIdListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_exitPointIdList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> exitPointIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExitPointIdList {
      get { return exitPointIdList_; }
    }

    /// <summary>Field number for the "entrance_point_id_list" field.</summary>
    public const int EntrancePointIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_entrancePointIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> entrancePointIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EntrancePointIdList {
      get { return entrancePointIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IrodoriChessMysteryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IrodoriChessMysteryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntranceDetailInfo, other.EntranceDetailInfo)) return false;
      if(!exitPointIdList_.Equals(other.exitPointIdList_)) return false;
      if(!entrancePointIdList_.Equals(other.entrancePointIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (entranceDetailInfo_ != null) hash ^= EntranceDetailInfo.GetHashCode();
      hash ^= exitPointIdList_.GetHashCode();
      hash ^= entrancePointIdList_.GetHashCode();
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
      if (entranceDetailInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EntranceDetailInfo);
      }
      entrancePointIdList_.WriteTo(output, _repeated_entrancePointIdList_codec);
      exitPointIdList_.WriteTo(output, _repeated_exitPointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (entranceDetailInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(EntranceDetailInfo);
      }
      entrancePointIdList_.WriteTo(ref output, _repeated_entrancePointIdList_codec);
      exitPointIdList_.WriteTo(ref output, _repeated_exitPointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (entranceDetailInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntranceDetailInfo);
      }
      size += exitPointIdList_.CalculateSize(_repeated_exitPointIdList_codec);
      size += entrancePointIdList_.CalculateSize(_repeated_entrancePointIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IrodoriChessMysteryInfo other) {
      if (other == null) {
        return;
      }
      if (other.entranceDetailInfo_ != null) {
        if (entranceDetailInfo_ == null) {
          EntranceDetailInfo = new global::Weedwacker.Shared.Network.Proto.IrodoriChessEntranceDetailInfo();
        }
        EntranceDetailInfo.MergeFrom(other.EntranceDetailInfo);
      }
      exitPointIdList_.Add(other.exitPointIdList_);
      entrancePointIdList_.Add(other.entrancePointIdList_);
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
          case 26: {
            if (entranceDetailInfo_ == null) {
              EntranceDetailInfo = new global::Weedwacker.Shared.Network.Proto.IrodoriChessEntranceDetailInfo();
            }
            input.ReadMessage(EntranceDetailInfo);
            break;
          }
          case 90:
          case 88: {
            entrancePointIdList_.AddEntriesFrom(input, _repeated_entrancePointIdList_codec);
            break;
          }
          case 114:
          case 112: {
            exitPointIdList_.AddEntriesFrom(input, _repeated_exitPointIdList_codec);
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
          case 26: {
            if (entranceDetailInfo_ == null) {
              EntranceDetailInfo = new global::Weedwacker.Shared.Network.Proto.IrodoriChessEntranceDetailInfo();
            }
            input.ReadMessage(EntranceDetailInfo);
            break;
          }
          case 90:
          case 88: {
            entrancePointIdList_.AddEntriesFrom(ref input, _repeated_entrancePointIdList_codec);
            break;
          }
          case 114:
          case 112: {
            exitPointIdList_.AddEntriesFrom(ref input, _repeated_exitPointIdList_codec);
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
