// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DragonSpineCoinChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from DragonSpineCoinChangeNotify.proto</summary>
  public static partial class DragonSpineCoinChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DragonSpineCoinChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DragonSpineCoinChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFEcmFnb25TcGluZUNvaW5DaGFuZ2VOb3RpZnkucHJvdG8ifgobRHJhZ29u",
            "U3BpbmVDb2luQ2hhbmdlTm90aWZ5EhoKEnNoaW1tZXJpbmdfZXNzZW5jZRgE",
            "IAEoDRIUCgx3YXJtX2Vzc2VuY2UYDSABKA0SEwoLc2NoZWR1bGVfaWQYDCAB",
            "KA0SGAoQd29uZHJvdXNfZXNzZW5jZRgLIAEoDUIaqgIXV2VlZHdhY2tlci5T",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.DragonSpineCoinChangeNotify), global::Weedwacker.Server.Proto.DragonSpineCoinChangeNotify.Parser, new[]{ "ShimmeringEssence", "WarmEssence", "ScheduleId", "WondrousEssence" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2088
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class DragonSpineCoinChangeNotify : pb::IMessage<DragonSpineCoinChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DragonSpineCoinChangeNotify> _parser = new pb::MessageParser<DragonSpineCoinChangeNotify>(() => new DragonSpineCoinChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DragonSpineCoinChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.DragonSpineCoinChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineCoinChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineCoinChangeNotify(DragonSpineCoinChangeNotify other) : this() {
      shimmeringEssence_ = other.shimmeringEssence_;
      warmEssence_ = other.warmEssence_;
      scheduleId_ = other.scheduleId_;
      wondrousEssence_ = other.wondrousEssence_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineCoinChangeNotify Clone() {
      return new DragonSpineCoinChangeNotify(this);
    }

    /// <summary>Field number for the "shimmering_essence" field.</summary>
    public const int ShimmeringEssenceFieldNumber = 4;
    private uint shimmeringEssence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShimmeringEssence {
      get { return shimmeringEssence_; }
      set {
        shimmeringEssence_ = value;
      }
    }

    /// <summary>Field number for the "warm_essence" field.</summary>
    public const int WarmEssenceFieldNumber = 13;
    private uint warmEssence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WarmEssence {
      get { return warmEssence_; }
      set {
        warmEssence_ = value;
      }
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 12;
    private uint scheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = value;
      }
    }

    /// <summary>Field number for the "wondrous_essence" field.</summary>
    public const int WondrousEssenceFieldNumber = 11;
    private uint wondrousEssence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WondrousEssence {
      get { return wondrousEssence_; }
      set {
        wondrousEssence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DragonSpineCoinChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DragonSpineCoinChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShimmeringEssence != other.ShimmeringEssence) return false;
      if (WarmEssence != other.WarmEssence) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if (WondrousEssence != other.WondrousEssence) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShimmeringEssence != 0) hash ^= ShimmeringEssence.GetHashCode();
      if (WarmEssence != 0) hash ^= WarmEssence.GetHashCode();
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
      if (WondrousEssence != 0) hash ^= WondrousEssence.GetHashCode();
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
      if (ShimmeringEssence != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ShimmeringEssence);
      }
      if (WondrousEssence != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WondrousEssence);
      }
      if (ScheduleId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ScheduleId);
      }
      if (WarmEssence != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(WarmEssence);
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
      if (ShimmeringEssence != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ShimmeringEssence);
      }
      if (WondrousEssence != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WondrousEssence);
      }
      if (ScheduleId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ScheduleId);
      }
      if (WarmEssence != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(WarmEssence);
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
      if (ShimmeringEssence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShimmeringEssence);
      }
      if (WarmEssence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WarmEssence);
      }
      if (ScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
      }
      if (WondrousEssence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WondrousEssence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DragonSpineCoinChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.ShimmeringEssence != 0) {
        ShimmeringEssence = other.ShimmeringEssence;
      }
      if (other.WarmEssence != 0) {
        WarmEssence = other.WarmEssence;
      }
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.WondrousEssence != 0) {
        WondrousEssence = other.WondrousEssence;
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
          case 32: {
            ShimmeringEssence = input.ReadUInt32();
            break;
          }
          case 88: {
            WondrousEssence = input.ReadUInt32();
            break;
          }
          case 96: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 104: {
            WarmEssence = input.ReadUInt32();
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
          case 32: {
            ShimmeringEssence = input.ReadUInt32();
            break;
          }
          case 88: {
            WondrousEssence = input.ReadUInt32();
            break;
          }
          case 96: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 104: {
            WarmEssence = input.ReadUInt32();
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
