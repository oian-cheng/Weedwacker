// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriMasterLevelDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from IrodoriMasterLevelDetailInfo.proto</summary>
  public static partial class IrodoriMasterLevelDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for IrodoriMasterLevelDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IrodoriMasterLevelDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJJcm9kb3JpTWFzdGVyTGV2ZWxEZXRhaWxJbmZvLnByb3RvEh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvInMKHElyb2RvcmlNYXN0ZXJMZXZl",
            "bERldGFpbEluZm8SEQoJaXNfZmluaXNoGAogASgIEhIKCmRpZmZpY3VsdHkY",
            "CyABKA0SEwoLaXNfaGF2ZV90cnkYDyABKAgSFwoPbWluX2ZpbmlzaF90aW1l",
            "GAwgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelDetailInfo), global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelDetailInfo.Parser, new[]{ "IsFinish", "Difficulty", "IsHaveTry", "MinFinishTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IrodoriMasterLevelDetailInfo : pb::IMessage<IrodoriMasterLevelDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IrodoriMasterLevelDetailInfo> _parser = new pb::MessageParser<IrodoriMasterLevelDetailInfo>(() => new IrodoriMasterLevelDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IrodoriMasterLevelDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.IrodoriMasterLevelDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriMasterLevelDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriMasterLevelDetailInfo(IrodoriMasterLevelDetailInfo other) : this() {
      isFinish_ = other.isFinish_;
      difficulty_ = other.difficulty_;
      isHaveTry_ = other.isHaveTry_;
      minFinishTime_ = other.minFinishTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriMasterLevelDetailInfo Clone() {
      return new IrodoriMasterLevelDetailInfo(this);
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 10;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 11;
    private uint difficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = value;
      }
    }

    /// <summary>Field number for the "is_have_try" field.</summary>
    public const int IsHaveTryFieldNumber = 15;
    private bool isHaveTry_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsHaveTry {
      get { return isHaveTry_; }
      set {
        isHaveTry_ = value;
      }
    }

    /// <summary>Field number for the "min_finish_time" field.</summary>
    public const int MinFinishTimeFieldNumber = 12;
    private uint minFinishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinFinishTime {
      get { return minFinishTime_; }
      set {
        minFinishTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IrodoriMasterLevelDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IrodoriMasterLevelDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFinish != other.IsFinish) return false;
      if (Difficulty != other.Difficulty) return false;
      if (IsHaveTry != other.IsHaveTry) return false;
      if (MinFinishTime != other.MinFinishTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
      if (Difficulty != 0) hash ^= Difficulty.GetHashCode();
      if (IsHaveTry != false) hash ^= IsHaveTry.GetHashCode();
      if (MinFinishTime != 0) hash ^= MinFinishTime.GetHashCode();
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
      if (IsFinish != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsFinish);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Difficulty);
      }
      if (MinFinishTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MinFinishTime);
      }
      if (IsHaveTry != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsHaveTry);
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
      if (IsFinish != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsFinish);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Difficulty);
      }
      if (MinFinishTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MinFinishTime);
      }
      if (IsHaveTry != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsHaveTry);
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
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (Difficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Difficulty);
      }
      if (IsHaveTry != false) {
        size += 1 + 1;
      }
      if (MinFinishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinFinishTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IrodoriMasterLevelDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
      }
      if (other.Difficulty != 0) {
        Difficulty = other.Difficulty;
      }
      if (other.IsHaveTry != false) {
        IsHaveTry = other.IsHaveTry;
      }
      if (other.MinFinishTime != 0) {
        MinFinishTime = other.MinFinishTime;
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
            IsFinish = input.ReadBool();
            break;
          }
          case 88: {
            Difficulty = input.ReadUInt32();
            break;
          }
          case 96: {
            MinFinishTime = input.ReadUInt32();
            break;
          }
          case 120: {
            IsHaveTry = input.ReadBool();
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
            IsFinish = input.ReadBool();
            break;
          }
          case 88: {
            Difficulty = input.ReadUInt32();
            break;
          }
          case 96: {
            MinFinishTime = input.ReadUInt32();
            break;
          }
          case 120: {
            IsHaveTry = input.ReadBool();
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
