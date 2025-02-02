// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AnnounceData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AnnounceData.proto</summary>
  public static partial class AnnounceDataReflection {

    #region Descriptor
    /// <summary>File descriptor for AnnounceData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnnounceDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJBbm5vdW5jZURhdGEucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8iiAIKDEFubm91bmNlRGF0YRISCgpiZWdpbl90aW1lGAogASgN",
            "Ei0KJWlzX2NlbnRlcl9zeXN0ZW1fbGFzdF81X2V2ZXJ5X21pbnV0ZXMYAyAB",
            "KAgSEAoIZW5kX3RpbWUYASABKA0SEQoJY29uZmlnX2lkGAIgASgNEhoKEmNl",
            "bnRlcl9zeXN0ZW1fdGV4dBgLIAEoCRIcChRjb3VudF9kb3duX2ZyZXF1ZW5j",
            "eRgFIAEoDRIfChdjZW50ZXJfc3lzdGVtX2ZyZXF1ZW5jeRgNIAEoDRIcChRk",
            "dW5nZW9uX2NvbmZpcm1fdGV4dBgEIAEoCRIXCg9jb3VudF9kb3duX3RleHQY",
            "BiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AnnounceData), global::Weedwacker.Shared.Network.Proto.AnnounceData.Parser, new[]{ "BeginTime", "IsCenterSystemLast5EveryMinutes", "EndTime", "ConfigId", "CenterSystemText", "CountDownFrequency", "CenterSystemFrequency", "DungeonConfirmText", "CountDownText" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AnnounceData : pb::IMessage<AnnounceData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnnounceData> _parser = new pb::MessageParser<AnnounceData>(() => new AnnounceData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AnnounceData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AnnounceDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnnounceData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnnounceData(AnnounceData other) : this() {
      beginTime_ = other.beginTime_;
      isCenterSystemLast5EveryMinutes_ = other.isCenterSystemLast5EveryMinutes_;
      endTime_ = other.endTime_;
      configId_ = other.configId_;
      centerSystemText_ = other.centerSystemText_;
      countDownFrequency_ = other.countDownFrequency_;
      centerSystemFrequency_ = other.centerSystemFrequency_;
      dungeonConfirmText_ = other.dungeonConfirmText_;
      countDownText_ = other.countDownText_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnnounceData Clone() {
      return new AnnounceData(this);
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 10;
    private uint beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "is_center_system_last_5_every_minutes" field.</summary>
    public const int IsCenterSystemLast5EveryMinutesFieldNumber = 3;
    private bool isCenterSystemLast5EveryMinutes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCenterSystemLast5EveryMinutes {
      get { return isCenterSystemLast5EveryMinutes_; }
      set {
        isCenterSystemLast5EveryMinutes_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 1;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
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

    /// <summary>Field number for the "center_system_text" field.</summary>
    public const int CenterSystemTextFieldNumber = 11;
    private string centerSystemText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CenterSystemText {
      get { return centerSystemText_; }
      set {
        centerSystemText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "count_down_frequency" field.</summary>
    public const int CountDownFrequencyFieldNumber = 5;
    private uint countDownFrequency_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CountDownFrequency {
      get { return countDownFrequency_; }
      set {
        countDownFrequency_ = value;
      }
    }

    /// <summary>Field number for the "center_system_frequency" field.</summary>
    public const int CenterSystemFrequencyFieldNumber = 13;
    private uint centerSystemFrequency_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CenterSystemFrequency {
      get { return centerSystemFrequency_; }
      set {
        centerSystemFrequency_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_confirm_text" field.</summary>
    public const int DungeonConfirmTextFieldNumber = 4;
    private string dungeonConfirmText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DungeonConfirmText {
      get { return dungeonConfirmText_; }
      set {
        dungeonConfirmText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "count_down_text" field.</summary>
    public const int CountDownTextFieldNumber = 6;
    private string countDownText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CountDownText {
      get { return countDownText_; }
      set {
        countDownText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AnnounceData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AnnounceData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BeginTime != other.BeginTime) return false;
      if (IsCenterSystemLast5EveryMinutes != other.IsCenterSystemLast5EveryMinutes) return false;
      if (EndTime != other.EndTime) return false;
      if (ConfigId != other.ConfigId) return false;
      if (CenterSystemText != other.CenterSystemText) return false;
      if (CountDownFrequency != other.CountDownFrequency) return false;
      if (CenterSystemFrequency != other.CenterSystemFrequency) return false;
      if (DungeonConfirmText != other.DungeonConfirmText) return false;
      if (CountDownText != other.CountDownText) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
      if (IsCenterSystemLast5EveryMinutes != false) hash ^= IsCenterSystemLast5EveryMinutes.GetHashCode();
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (CenterSystemText.Length != 0) hash ^= CenterSystemText.GetHashCode();
      if (CountDownFrequency != 0) hash ^= CountDownFrequency.GetHashCode();
      if (CenterSystemFrequency != 0) hash ^= CenterSystemFrequency.GetHashCode();
      if (DungeonConfirmText.Length != 0) hash ^= DungeonConfirmText.GetHashCode();
      if (CountDownText.Length != 0) hash ^= CountDownText.GetHashCode();
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
      if (EndTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EndTime);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ConfigId);
      }
      if (IsCenterSystemLast5EveryMinutes != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsCenterSystemLast5EveryMinutes);
      }
      if (DungeonConfirmText.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DungeonConfirmText);
      }
      if (CountDownFrequency != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CountDownFrequency);
      }
      if (CountDownText.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CountDownText);
      }
      if (BeginTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BeginTime);
      }
      if (CenterSystemText.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(CenterSystemText);
      }
      if (CenterSystemFrequency != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CenterSystemFrequency);
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
      if (EndTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EndTime);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ConfigId);
      }
      if (IsCenterSystemLast5EveryMinutes != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsCenterSystemLast5EveryMinutes);
      }
      if (DungeonConfirmText.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DungeonConfirmText);
      }
      if (CountDownFrequency != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CountDownFrequency);
      }
      if (CountDownText.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CountDownText);
      }
      if (BeginTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BeginTime);
      }
      if (CenterSystemText.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(CenterSystemText);
      }
      if (CenterSystemFrequency != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CenterSystemFrequency);
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
      if (BeginTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginTime);
      }
      if (IsCenterSystemLast5EveryMinutes != false) {
        size += 1 + 1;
      }
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (CenterSystemText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CenterSystemText);
      }
      if (CountDownFrequency != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CountDownFrequency);
      }
      if (CenterSystemFrequency != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CenterSystemFrequency);
      }
      if (DungeonConfirmText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DungeonConfirmText);
      }
      if (CountDownText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CountDownText);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AnnounceData other) {
      if (other == null) {
        return;
      }
      if (other.BeginTime != 0) {
        BeginTime = other.BeginTime;
      }
      if (other.IsCenterSystemLast5EveryMinutes != false) {
        IsCenterSystemLast5EveryMinutes = other.IsCenterSystemLast5EveryMinutes;
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.CenterSystemText.Length != 0) {
        CenterSystemText = other.CenterSystemText;
      }
      if (other.CountDownFrequency != 0) {
        CountDownFrequency = other.CountDownFrequency;
      }
      if (other.CenterSystemFrequency != 0) {
        CenterSystemFrequency = other.CenterSystemFrequency;
      }
      if (other.DungeonConfirmText.Length != 0) {
        DungeonConfirmText = other.DungeonConfirmText;
      }
      if (other.CountDownText.Length != 0) {
        CountDownText = other.CountDownText;
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
            EndTime = input.ReadUInt32();
            break;
          }
          case 16: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsCenterSystemLast5EveryMinutes = input.ReadBool();
            break;
          }
          case 34: {
            DungeonConfirmText = input.ReadString();
            break;
          }
          case 40: {
            CountDownFrequency = input.ReadUInt32();
            break;
          }
          case 50: {
            CountDownText = input.ReadString();
            break;
          }
          case 80: {
            BeginTime = input.ReadUInt32();
            break;
          }
          case 90: {
            CenterSystemText = input.ReadString();
            break;
          }
          case 104: {
            CenterSystemFrequency = input.ReadUInt32();
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
            EndTime = input.ReadUInt32();
            break;
          }
          case 16: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsCenterSystemLast5EveryMinutes = input.ReadBool();
            break;
          }
          case 34: {
            DungeonConfirmText = input.ReadString();
            break;
          }
          case 40: {
            CountDownFrequency = input.ReadUInt32();
            break;
          }
          case 50: {
            CountDownText = input.ReadString();
            break;
          }
          case 80: {
            BeginTime = input.ReadUInt32();
            break;
          }
          case 90: {
            CenterSystemText = input.ReadString();
            break;
          }
          case 104: {
            CenterSystemFrequency = input.ReadUInt32();
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
