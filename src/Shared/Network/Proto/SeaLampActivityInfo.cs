// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SeaLampActivityInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SeaLampActivityInfo.proto</summary>
  public static partial class SeaLampActivityInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SeaLampActivityInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SeaLampActivityInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTZWFMYW1wQWN0aXZpdHlJbmZvLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvGhhTZWFMYW1wU2VjdGlvbkluZm8ucHJvdG8irQIK",
            "E1NlYUxhbXBBY3Rpdml0eUluZm8SEQoJZGF5X2luZGV4GA4gASgNEhkKEWlz",
            "X2NvbnRlbnRfY2xvc2VkGA8gASgIEk4KEXNlY3Rpb25faW5mb19saXN0GAEg",
            "AygLMjMuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5TZWFMYW1w",
            "U2VjdGlvbkluZm8SFQoNbWVjaGFuaWN1c19pZBgHIAEoDRIcChRmaXJzdF9k",
            "YXlfc3RhcnRfdGltZRgGIAEoDRIVCg1zZWFfbGFtcF9jb2luGAsgASgNEhIK",
            "CnBvcHVsYXJpdHkYAiABKA0SGwoTVW5rMzMwMF9KTVBDSkdKSFBJSBgNIAEo",
            "CBIbChNVbmszMzAwX0JBSklHTkdKQUxHGAkgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.SeaLampSectionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SeaLampActivityInfo), global::Weedwacker.Shared.Network.Proto.SeaLampActivityInfo.Parser, new[]{ "DayIndex", "IsContentClosed", "SectionInfoList", "MechanicusId", "FirstDayStartTime", "SeaLampCoin", "Popularity", "Unk3300JMPCJGJHPIH", "Unk3300BAJIGNGJALG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SeaLampActivityInfo : pb::IMessage<SeaLampActivityInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SeaLampActivityInfo> _parser = new pb::MessageParser<SeaLampActivityInfo>(() => new SeaLampActivityInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SeaLampActivityInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SeaLampActivityInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampActivityInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampActivityInfo(SeaLampActivityInfo other) : this() {
      dayIndex_ = other.dayIndex_;
      isContentClosed_ = other.isContentClosed_;
      sectionInfoList_ = other.sectionInfoList_.Clone();
      mechanicusId_ = other.mechanicusId_;
      firstDayStartTime_ = other.firstDayStartTime_;
      seaLampCoin_ = other.seaLampCoin_;
      popularity_ = other.popularity_;
      unk3300JMPCJGJHPIH_ = other.unk3300JMPCJGJHPIH_;
      unk3300BAJIGNGJALG_ = other.unk3300BAJIGNGJALG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampActivityInfo Clone() {
      return new SeaLampActivityInfo(this);
    }

    /// <summary>Field number for the "day_index" field.</summary>
    public const int DayIndexFieldNumber = 14;
    private uint dayIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DayIndex {
      get { return dayIndex_; }
      set {
        dayIndex_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 15;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "section_info_list" field.</summary>
    public const int SectionInfoListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.SeaLampSectionInfo> _repeated_sectionInfoList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.SeaLampSectionInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SeaLampSectionInfo> sectionInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SeaLampSectionInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SeaLampSectionInfo> SectionInfoList {
      get { return sectionInfoList_; }
    }

    /// <summary>Field number for the "mechanicus_id" field.</summary>
    public const int MechanicusIdFieldNumber = 7;
    private uint mechanicusId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MechanicusId {
      get { return mechanicusId_; }
      set {
        mechanicusId_ = value;
      }
    }

    /// <summary>Field number for the "first_day_start_time" field.</summary>
    public const int FirstDayStartTimeFieldNumber = 6;
    private uint firstDayStartTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FirstDayStartTime {
      get { return firstDayStartTime_; }
      set {
        firstDayStartTime_ = value;
      }
    }

    /// <summary>Field number for the "sea_lamp_coin" field.</summary>
    public const int SeaLampCoinFieldNumber = 11;
    private uint seaLampCoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SeaLampCoin {
      get { return seaLampCoin_; }
      set {
        seaLampCoin_ = value;
      }
    }

    /// <summary>Field number for the "popularity" field.</summary>
    public const int PopularityFieldNumber = 2;
    private uint popularity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Popularity {
      get { return popularity_; }
      set {
        popularity_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JMPCJGJHPIH" field.</summary>
    public const int Unk3300JMPCJGJHPIHFieldNumber = 13;
    private bool unk3300JMPCJGJHPIH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300JMPCJGJHPIH {
      get { return unk3300JMPCJGJHPIH_; }
      set {
        unk3300JMPCJGJHPIH_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BAJIGNGJALG" field.</summary>
    public const int Unk3300BAJIGNGJALGFieldNumber = 9;
    private bool unk3300BAJIGNGJALG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300BAJIGNGJALG {
      get { return unk3300BAJIGNGJALG_; }
      set {
        unk3300BAJIGNGJALG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SeaLampActivityInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SeaLampActivityInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DayIndex != other.DayIndex) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if(!sectionInfoList_.Equals(other.sectionInfoList_)) return false;
      if (MechanicusId != other.MechanicusId) return false;
      if (FirstDayStartTime != other.FirstDayStartTime) return false;
      if (SeaLampCoin != other.SeaLampCoin) return false;
      if (Popularity != other.Popularity) return false;
      if (Unk3300JMPCJGJHPIH != other.Unk3300JMPCJGJHPIH) return false;
      if (Unk3300BAJIGNGJALG != other.Unk3300BAJIGNGJALG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DayIndex != 0) hash ^= DayIndex.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      hash ^= sectionInfoList_.GetHashCode();
      if (MechanicusId != 0) hash ^= MechanicusId.GetHashCode();
      if (FirstDayStartTime != 0) hash ^= FirstDayStartTime.GetHashCode();
      if (SeaLampCoin != 0) hash ^= SeaLampCoin.GetHashCode();
      if (Popularity != 0) hash ^= Popularity.GetHashCode();
      if (Unk3300JMPCJGJHPIH != false) hash ^= Unk3300JMPCJGJHPIH.GetHashCode();
      if (Unk3300BAJIGNGJALG != false) hash ^= Unk3300BAJIGNGJALG.GetHashCode();
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
      sectionInfoList_.WriteTo(output, _repeated_sectionInfoList_codec);
      if (Popularity != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Popularity);
      }
      if (FirstDayStartTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FirstDayStartTime);
      }
      if (MechanicusId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MechanicusId);
      }
      if (Unk3300BAJIGNGJALG != false) {
        output.WriteRawTag(72);
        output.WriteBool(Unk3300BAJIGNGJALG);
      }
      if (SeaLampCoin != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SeaLampCoin);
      }
      if (Unk3300JMPCJGJHPIH != false) {
        output.WriteRawTag(104);
        output.WriteBool(Unk3300JMPCJGJHPIH);
      }
      if (DayIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DayIndex);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsContentClosed);
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
      sectionInfoList_.WriteTo(ref output, _repeated_sectionInfoList_codec);
      if (Popularity != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Popularity);
      }
      if (FirstDayStartTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FirstDayStartTime);
      }
      if (MechanicusId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MechanicusId);
      }
      if (Unk3300BAJIGNGJALG != false) {
        output.WriteRawTag(72);
        output.WriteBool(Unk3300BAJIGNGJALG);
      }
      if (SeaLampCoin != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SeaLampCoin);
      }
      if (Unk3300JMPCJGJHPIH != false) {
        output.WriteRawTag(104);
        output.WriteBool(Unk3300JMPCJGJHPIH);
      }
      if (DayIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DayIndex);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsContentClosed);
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
      if (DayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DayIndex);
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      size += sectionInfoList_.CalculateSize(_repeated_sectionInfoList_codec);
      if (MechanicusId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusId);
      }
      if (FirstDayStartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FirstDayStartTime);
      }
      if (SeaLampCoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SeaLampCoin);
      }
      if (Popularity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Popularity);
      }
      if (Unk3300JMPCJGJHPIH != false) {
        size += 1 + 1;
      }
      if (Unk3300BAJIGNGJALG != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SeaLampActivityInfo other) {
      if (other == null) {
        return;
      }
      if (other.DayIndex != 0) {
        DayIndex = other.DayIndex;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      sectionInfoList_.Add(other.sectionInfoList_);
      if (other.MechanicusId != 0) {
        MechanicusId = other.MechanicusId;
      }
      if (other.FirstDayStartTime != 0) {
        FirstDayStartTime = other.FirstDayStartTime;
      }
      if (other.SeaLampCoin != 0) {
        SeaLampCoin = other.SeaLampCoin;
      }
      if (other.Popularity != 0) {
        Popularity = other.Popularity;
      }
      if (other.Unk3300JMPCJGJHPIH != false) {
        Unk3300JMPCJGJHPIH = other.Unk3300JMPCJGJHPIH;
      }
      if (other.Unk3300BAJIGNGJALG != false) {
        Unk3300BAJIGNGJALG = other.Unk3300BAJIGNGJALG;
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
          case 10: {
            sectionInfoList_.AddEntriesFrom(input, _repeated_sectionInfoList_codec);
            break;
          }
          case 16: {
            Popularity = input.ReadUInt32();
            break;
          }
          case 48: {
            FirstDayStartTime = input.ReadUInt32();
            break;
          }
          case 56: {
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300BAJIGNGJALG = input.ReadBool();
            break;
          }
          case 88: {
            SeaLampCoin = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300JMPCJGJHPIH = input.ReadBool();
            break;
          }
          case 112: {
            DayIndex = input.ReadUInt32();
            break;
          }
          case 120: {
            IsContentClosed = input.ReadBool();
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
            sectionInfoList_.AddEntriesFrom(ref input, _repeated_sectionInfoList_codec);
            break;
          }
          case 16: {
            Popularity = input.ReadUInt32();
            break;
          }
          case 48: {
            FirstDayStartTime = input.ReadUInt32();
            break;
          }
          case 56: {
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300BAJIGNGJALG = input.ReadBool();
            break;
          }
          case 88: {
            SeaLampCoin = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300JMPCJGJHPIH = input.ReadBool();
            break;
          }
          case 112: {
            DayIndex = input.ReadUInt32();
            break;
          }
          case 120: {
            IsContentClosed = input.ReadBool();
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
