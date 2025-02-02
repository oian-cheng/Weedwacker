// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ResinCardData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ResinCardData.proto</summary>
  public static partial class ResinCardDataReflection {

    #region Descriptor
    /// <summary>File descriptor for ResinCardData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResinCardDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNSZXNpbkNhcmREYXRhLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvInMKDVJlc2luQ2FyZERhdGESHgoWbGFzdF9kYWlseV9yZXdh",
            "cmRfdGltZRgKIAEoDRIRCgljb25maWdfaWQYAiABKA0SEwoLZXhwaXJlX3Rp",
            "bWUYDSABKA0SGgoScmVtYWluX3Jld2FyZF9kYXlzGAsgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ResinCardData), global::Weedwacker.Shared.Network.Proto.ResinCardData.Parser, new[]{ "LastDailyRewardTime", "ConfigId", "ExpireTime", "RemainRewardDays" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ResinCardData : pb::IMessage<ResinCardData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResinCardData> _parser = new pb::MessageParser<ResinCardData>(() => new ResinCardData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResinCardData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ResinCardDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResinCardData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResinCardData(ResinCardData other) : this() {
      lastDailyRewardTime_ = other.lastDailyRewardTime_;
      configId_ = other.configId_;
      expireTime_ = other.expireTime_;
      remainRewardDays_ = other.remainRewardDays_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResinCardData Clone() {
      return new ResinCardData(this);
    }

    /// <summary>Field number for the "last_daily_reward_time" field.</summary>
    public const int LastDailyRewardTimeFieldNumber = 10;
    private uint lastDailyRewardTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastDailyRewardTime {
      get { return lastDailyRewardTime_; }
      set {
        lastDailyRewardTime_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 2;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "expire_time" field.</summary>
    public const int ExpireTimeFieldNumber = 13;
    private uint expireTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExpireTime {
      get { return expireTime_; }
      set {
        expireTime_ = value;
      }
    }

    /// <summary>Field number for the "remain_reward_days" field.</summary>
    public const int RemainRewardDaysFieldNumber = 11;
    private uint remainRewardDays_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RemainRewardDays {
      get { return remainRewardDays_; }
      set {
        remainRewardDays_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResinCardData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResinCardData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LastDailyRewardTime != other.LastDailyRewardTime) return false;
      if (ConfigId != other.ConfigId) return false;
      if (ExpireTime != other.ExpireTime) return false;
      if (RemainRewardDays != other.RemainRewardDays) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LastDailyRewardTime != 0) hash ^= LastDailyRewardTime.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (ExpireTime != 0) hash ^= ExpireTime.GetHashCode();
      if (RemainRewardDays != 0) hash ^= RemainRewardDays.GetHashCode();
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
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ConfigId);
      }
      if (LastDailyRewardTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LastDailyRewardTime);
      }
      if (RemainRewardDays != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RemainRewardDays);
      }
      if (ExpireTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ExpireTime);
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
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ConfigId);
      }
      if (LastDailyRewardTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LastDailyRewardTime);
      }
      if (RemainRewardDays != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RemainRewardDays);
      }
      if (ExpireTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ExpireTime);
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
      if (LastDailyRewardTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastDailyRewardTime);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (ExpireTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExpireTime);
      }
      if (RemainRewardDays != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainRewardDays);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResinCardData other) {
      if (other == null) {
        return;
      }
      if (other.LastDailyRewardTime != 0) {
        LastDailyRewardTime = other.LastDailyRewardTime;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.ExpireTime != 0) {
        ExpireTime = other.ExpireTime;
      }
      if (other.RemainRewardDays != 0) {
        RemainRewardDays = other.RemainRewardDays;
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
            ConfigId = input.ReadUInt32();
            break;
          }
          case 80: {
            LastDailyRewardTime = input.ReadUInt32();
            break;
          }
          case 88: {
            RemainRewardDays = input.ReadUInt32();
            break;
          }
          case 104: {
            ExpireTime = input.ReadUInt32();
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
            ConfigId = input.ReadUInt32();
            break;
          }
          case 80: {
            LastDailyRewardTime = input.ReadUInt32();
            break;
          }
          case 88: {
            RemainRewardDays = input.ReadUInt32();
            break;
          }
          case 104: {
            ExpireTime = input.ReadUInt32();
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
