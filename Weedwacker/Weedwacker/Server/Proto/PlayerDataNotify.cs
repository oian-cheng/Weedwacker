// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from PlayerDataNotify.proto</summary>
  public static partial class PlayerDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJEYXRhTm90aWZ5LnByb3RvGg9Qcm9wVmFsdWUucHJvdG8i2QEK",
            "EFBsYXllckRhdGFOb3RpZnkSEwoLc2VydmVyX3RpbWUYByABKAQSEQoJbmlj",
            "a19uYW1lGAggASgJEhwKFGlzX2ZpcnN0X2xvZ2luX3RvZGF5GAwgASgIEhEK",
            "CXJlZ2lvbl9pZBgGIAEoDRIwCghwcm9wX21hcBgPIAMoCzIeLlBsYXllckRh",
            "dGFOb3RpZnkuUHJvcE1hcEVudHJ5GjoKDFByb3BNYXBFbnRyeRILCgNrZXkY",
            "ASABKA0SGQoFdmFsdWUYAiABKAsyCi5Qcm9wVmFsdWU6AjgBQhqqAhdXZWVk",
            "d2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.PropValueReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.PlayerDataNotify), global::Weedwacker.Server.Proto.PlayerDataNotify.Parser, new[]{ "ServerTime", "NickName", "IsFirstLoginToday", "RegionId", "PropMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 190
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerDataNotify : pb::IMessage<PlayerDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerDataNotify> _parser = new pb::MessageParser<PlayerDataNotify>(() => new PlayerDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.PlayerDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDataNotify(PlayerDataNotify other) : this() {
      serverTime_ = other.serverTime_;
      nickName_ = other.nickName_;
      isFirstLoginToday_ = other.isFirstLoginToday_;
      regionId_ = other.regionId_;
      propMap_ = other.propMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDataNotify Clone() {
      return new PlayerDataNotify(this);
    }

    /// <summary>Field number for the "server_time" field.</summary>
    public const int ServerTimeFieldNumber = 7;
    private ulong serverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ServerTime {
      get { return serverTime_; }
      set {
        serverTime_ = value;
      }
    }

    /// <summary>Field number for the "nick_name" field.</summary>
    public const int NickNameFieldNumber = 8;
    private string nickName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NickName {
      get { return nickName_; }
      set {
        nickName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_first_login_today" field.</summary>
    public const int IsFirstLoginTodayFieldNumber = 12;
    private bool isFirstLoginToday_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstLoginToday {
      get { return isFirstLoginToday_; }
      set {
        isFirstLoginToday_ = value;
      }
    }

    /// <summary>Field number for the "region_id" field.</summary>
    public const int RegionIdFieldNumber = 6;
    private uint regionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RegionId {
      get { return regionId_; }
      set {
        regionId_ = value;
      }
    }

    /// <summary>Field number for the "prop_map" field.</summary>
    public const int PropMapFieldNumber = 15;
    private static readonly pbc::MapField<uint, global::Weedwacker.Server.Proto.PropValue>.Codec _map_propMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Server.Proto.PropValue>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Server.Proto.PropValue.Parser), 122);
    private readonly pbc::MapField<uint, global::Weedwacker.Server.Proto.PropValue> propMap_ = new pbc::MapField<uint, global::Weedwacker.Server.Proto.PropValue>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Server.Proto.PropValue> PropMap {
      get { return propMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerTime != other.ServerTime) return false;
      if (NickName != other.NickName) return false;
      if (IsFirstLoginToday != other.IsFirstLoginToday) return false;
      if (RegionId != other.RegionId) return false;
      if (!PropMap.Equals(other.PropMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerTime != 0UL) hash ^= ServerTime.GetHashCode();
      if (NickName.Length != 0) hash ^= NickName.GetHashCode();
      if (IsFirstLoginToday != false) hash ^= IsFirstLoginToday.GetHashCode();
      if (RegionId != 0) hash ^= RegionId.GetHashCode();
      hash ^= PropMap.GetHashCode();
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
      if (RegionId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RegionId);
      }
      if (ServerTime != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(ServerTime);
      }
      if (NickName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(NickName);
      }
      if (IsFirstLoginToday != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsFirstLoginToday);
      }
      propMap_.WriteTo(output, _map_propMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (RegionId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RegionId);
      }
      if (ServerTime != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(ServerTime);
      }
      if (NickName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(NickName);
      }
      if (IsFirstLoginToday != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsFirstLoginToday);
      }
      propMap_.WriteTo(ref output, _map_propMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ServerTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ServerTime);
      }
      if (NickName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NickName);
      }
      if (IsFirstLoginToday != false) {
        size += 1 + 1;
      }
      if (RegionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionId);
      }
      size += propMap_.CalculateSize(_map_propMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerDataNotify other) {
      if (other == null) {
        return;
      }
      if (other.ServerTime != 0UL) {
        ServerTime = other.ServerTime;
      }
      if (other.NickName.Length != 0) {
        NickName = other.NickName;
      }
      if (other.IsFirstLoginToday != false) {
        IsFirstLoginToday = other.IsFirstLoginToday;
      }
      if (other.RegionId != 0) {
        RegionId = other.RegionId;
      }
      propMap_.Add(other.propMap_);
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
          case 48: {
            RegionId = input.ReadUInt32();
            break;
          }
          case 56: {
            ServerTime = input.ReadUInt64();
            break;
          }
          case 66: {
            NickName = input.ReadString();
            break;
          }
          case 96: {
            IsFirstLoginToday = input.ReadBool();
            break;
          }
          case 122: {
            propMap_.AddEntriesFrom(input, _map_propMap_codec);
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
          case 48: {
            RegionId = input.ReadUInt32();
            break;
          }
          case 56: {
            ServerTime = input.ReadUInt64();
            break;
          }
          case 66: {
            NickName = input.ReadString();
            break;
          }
          case 96: {
            IsFirstLoginToday = input.ReadBool();
            break;
          }
          case 122: {
            propMap_.AddEntriesFrom(ref input, _map_propMap_codec);
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
