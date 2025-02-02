// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CityReputationExploreInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CityReputationExploreInfo.proto</summary>
  public static partial class CityReputationExploreInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CityReputationExploreInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CityReputationExploreInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DaXR5UmVwdXRhdGlvbkV4cGxvcmVJbmZvLnByb3RvEh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvImgKGUNpdHlSZXB1dGF0aW9uRXhwbG9y",
            "ZUluZm8SFwoPZXhwbG9yZV9wZXJjZW50GAEgASgNEiEKGXRha2VuX2V4cGxv",
            "cmVfcmV3YXJkX2xpc3QYDyADKA0SDwoHaXNfb3BlbhgNIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CityReputationExploreInfo), global::Weedwacker.Shared.Network.Proto.CityReputationExploreInfo.Parser, new[]{ "ExplorePercent", "TakenExploreRewardList", "IsOpen" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CityReputationExploreInfo : pb::IMessage<CityReputationExploreInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CityReputationExploreInfo> _parser = new pb::MessageParser<CityReputationExploreInfo>(() => new CityReputationExploreInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CityReputationExploreInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CityReputationExploreInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationExploreInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationExploreInfo(CityReputationExploreInfo other) : this() {
      explorePercent_ = other.explorePercent_;
      takenExploreRewardList_ = other.takenExploreRewardList_.Clone();
      isOpen_ = other.isOpen_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationExploreInfo Clone() {
      return new CityReputationExploreInfo(this);
    }

    /// <summary>Field number for the "explore_percent" field.</summary>
    public const int ExplorePercentFieldNumber = 1;
    private uint explorePercent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExplorePercent {
      get { return explorePercent_; }
      set {
        explorePercent_ = value;
      }
    }

    /// <summary>Field number for the "taken_explore_reward_list" field.</summary>
    public const int TakenExploreRewardListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_takenExploreRewardList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> takenExploreRewardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TakenExploreRewardList {
      get { return takenExploreRewardList_; }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 13;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CityReputationExploreInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CityReputationExploreInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ExplorePercent != other.ExplorePercent) return false;
      if(!takenExploreRewardList_.Equals(other.takenExploreRewardList_)) return false;
      if (IsOpen != other.IsOpen) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ExplorePercent != 0) hash ^= ExplorePercent.GetHashCode();
      hash ^= takenExploreRewardList_.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
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
      if (ExplorePercent != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ExplorePercent);
      }
      if (IsOpen != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsOpen);
      }
      takenExploreRewardList_.WriteTo(output, _repeated_takenExploreRewardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ExplorePercent != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ExplorePercent);
      }
      if (IsOpen != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsOpen);
      }
      takenExploreRewardList_.WriteTo(ref output, _repeated_takenExploreRewardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ExplorePercent != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExplorePercent);
      }
      size += takenExploreRewardList_.CalculateSize(_repeated_takenExploreRewardList_codec);
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CityReputationExploreInfo other) {
      if (other == null) {
        return;
      }
      if (other.ExplorePercent != 0) {
        ExplorePercent = other.ExplorePercent;
      }
      takenExploreRewardList_.Add(other.takenExploreRewardList_);
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
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
          case 8: {
            ExplorePercent = input.ReadUInt32();
            break;
          }
          case 104: {
            IsOpen = input.ReadBool();
            break;
          }
          case 122:
          case 120: {
            takenExploreRewardList_.AddEntriesFrom(input, _repeated_takenExploreRewardList_codec);
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
          case 8: {
            ExplorePercent = input.ReadUInt32();
            break;
          }
          case 104: {
            IsOpen = input.ReadBool();
            break;
          }
          case 122:
          case 120: {
            takenExploreRewardList_.AddEntriesFrom(ref input, _repeated_takenExploreRewardList_codec);
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
