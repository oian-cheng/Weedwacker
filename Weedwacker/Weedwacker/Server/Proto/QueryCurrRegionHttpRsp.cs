// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QueryCurrRegionHttpRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from QueryCurrRegionHttpRsp.proto</summary>
  public static partial class QueryCurrRegionHttpRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QueryCurrRegionHttpRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryCurrRegionHttpRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxRdWVyeUN1cnJSZWdpb25IdHRwUnNwLnByb3RvGhVGb3JjZVVwZGF0ZUlu",
            "Zm8ucHJvdG8aEFJlZ2lvbkluZm8ucHJvdG8aFFN0b3BTZXJ2ZXJJbmZvLnBy",
            "b3RvIqYCChZRdWVyeUN1cnJSZWdpb25IdHRwUnNwEg8KB3JldGNvZGUYASAB",
            "KAUSCwoDbXNnGAIgASgJEiAKC3JlZ2lvbl9pbmZvGAMgASgLMgsuUmVnaW9u",
            "SW5mbxIZChFjbGllbnRfc2VjcmV0X2tleRgLIAEoDBImCh5yZWdpb25fY3Vz",
            "dG9tX2NvbmZpZ19lbmNyeXB0ZWQYDCABKAwSLQolY2xpZW50X3JlZ2lvbl9j",
            "dXN0b21fY29uZmlnX2VuY3J5cHRlZBgNIAEoDBIoCgxmb3JjZV91ZHBhdGUY",
            "BCABKAsyEC5Gb3JjZVVwZGF0ZUluZm9IABImCgtzdG9wX3NlcnZlchgFIAEo",
            "CzIPLlN0b3BTZXJ2ZXJJbmZvSABCCAoGZGV0YWlsQhqqAhdXZWVkd2Fja2Vy",
            "LlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.ForceUpdateInfoReflection.Descriptor, global::Weedwacker.Server.Proto.RegionInfoReflection.Descriptor, global::Weedwacker.Server.Proto.StopServerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.QueryCurrRegionHttpRsp), global::Weedwacker.Server.Proto.QueryCurrRegionHttpRsp.Parser, new[]{ "Retcode", "Msg", "RegionInfo", "ClientSecretKey", "RegionCustomConfigEncrypted", "ClientRegionCustomConfigEncrypted", "ForceUdpate", "StopServer" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QueryCurrRegionHttpRsp : pb::IMessage<QueryCurrRegionHttpRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryCurrRegionHttpRsp> _parser = new pb::MessageParser<QueryCurrRegionHttpRsp>(() => new QueryCurrRegionHttpRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryCurrRegionHttpRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.QueryCurrRegionHttpRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCurrRegionHttpRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCurrRegionHttpRsp(QueryCurrRegionHttpRsp other) : this() {
      retcode_ = other.retcode_;
      msg_ = other.msg_;
      regionInfo_ = other.regionInfo_ != null ? other.regionInfo_.Clone() : null;
      clientSecretKey_ = other.clientSecretKey_;
      regionCustomConfigEncrypted_ = other.regionCustomConfigEncrypted_;
      clientRegionCustomConfigEncrypted_ = other.clientRegionCustomConfigEncrypted_;
      switch (other.DetailCase) {
        case DetailOneofCase.ForceUdpate:
          ForceUdpate = other.ForceUdpate.Clone();
          break;
        case DetailOneofCase.StopServer:
          StopServer = other.StopServer.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCurrRegionHttpRsp Clone() {
      return new QueryCurrRegionHttpRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 2;
    private string msg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "region_info" field.</summary>
    public const int RegionInfoFieldNumber = 3;
    private global::Weedwacker.Server.Proto.RegionInfo regionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.RegionInfo RegionInfo {
      get { return regionInfo_; }
      set {
        regionInfo_ = value;
      }
    }

    /// <summary>Field number for the "client_secret_key" field.</summary>
    public const int ClientSecretKeyFieldNumber = 11;
    private pb::ByteString clientSecretKey_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ClientSecretKey {
      get { return clientSecretKey_; }
      set {
        clientSecretKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "region_custom_config_encrypted" field.</summary>
    public const int RegionCustomConfigEncryptedFieldNumber = 12;
    private pb::ByteString regionCustomConfigEncrypted_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString RegionCustomConfigEncrypted {
      get { return regionCustomConfigEncrypted_; }
      set {
        regionCustomConfigEncrypted_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_region_custom_config_encrypted" field.</summary>
    public const int ClientRegionCustomConfigEncryptedFieldNumber = 13;
    private pb::ByteString clientRegionCustomConfigEncrypted_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ClientRegionCustomConfigEncrypted {
      get { return clientRegionCustomConfigEncrypted_; }
      set {
        clientRegionCustomConfigEncrypted_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "force_udpate" field.</summary>
    public const int ForceUdpateFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.ForceUpdateInfo ForceUdpate {
      get { return detailCase_ == DetailOneofCase.ForceUdpate ? (global::Weedwacker.Server.Proto.ForceUpdateInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.ForceUdpate;
      }
    }

    /// <summary>Field number for the "stop_server" field.</summary>
    public const int StopServerFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.StopServerInfo StopServer {
      get { return detailCase_ == DetailOneofCase.StopServer ? (global::Weedwacker.Server.Proto.StopServerInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.StopServer;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      ForceUdpate = 4,
      StopServer = 5,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryCurrRegionHttpRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryCurrRegionHttpRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (Msg != other.Msg) return false;
      if (!object.Equals(RegionInfo, other.RegionInfo)) return false;
      if (ClientSecretKey != other.ClientSecretKey) return false;
      if (RegionCustomConfigEncrypted != other.RegionCustomConfigEncrypted) return false;
      if (ClientRegionCustomConfigEncrypted != other.ClientRegionCustomConfigEncrypted) return false;
      if (!object.Equals(ForceUdpate, other.ForceUdpate)) return false;
      if (!object.Equals(StopServer, other.StopServer)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (regionInfo_ != null) hash ^= RegionInfo.GetHashCode();
      if (ClientSecretKey.Length != 0) hash ^= ClientSecretKey.GetHashCode();
      if (RegionCustomConfigEncrypted.Length != 0) hash ^= RegionCustomConfigEncrypted.GetHashCode();
      if (ClientRegionCustomConfigEncrypted.Length != 0) hash ^= ClientRegionCustomConfigEncrypted.GetHashCode();
      if (detailCase_ == DetailOneofCase.ForceUdpate) hash ^= ForceUdpate.GetHashCode();
      if (detailCase_ == DetailOneofCase.StopServer) hash ^= StopServer.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Msg);
      }
      if (regionInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RegionInfo);
      }
      if (detailCase_ == DetailOneofCase.ForceUdpate) {
        output.WriteRawTag(34);
        output.WriteMessage(ForceUdpate);
      }
      if (detailCase_ == DetailOneofCase.StopServer) {
        output.WriteRawTag(42);
        output.WriteMessage(StopServer);
      }
      if (ClientSecretKey.Length != 0) {
        output.WriteRawTag(90);
        output.WriteBytes(ClientSecretKey);
      }
      if (RegionCustomConfigEncrypted.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(RegionCustomConfigEncrypted);
      }
      if (ClientRegionCustomConfigEncrypted.Length != 0) {
        output.WriteRawTag(106);
        output.WriteBytes(ClientRegionCustomConfigEncrypted);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Msg);
      }
      if (regionInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RegionInfo);
      }
      if (detailCase_ == DetailOneofCase.ForceUdpate) {
        output.WriteRawTag(34);
        output.WriteMessage(ForceUdpate);
      }
      if (detailCase_ == DetailOneofCase.StopServer) {
        output.WriteRawTag(42);
        output.WriteMessage(StopServer);
      }
      if (ClientSecretKey.Length != 0) {
        output.WriteRawTag(90);
        output.WriteBytes(ClientSecretKey);
      }
      if (RegionCustomConfigEncrypted.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(RegionCustomConfigEncrypted);
      }
      if (ClientRegionCustomConfigEncrypted.Length != 0) {
        output.WriteRawTag(106);
        output.WriteBytes(ClientRegionCustomConfigEncrypted);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (regionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RegionInfo);
      }
      if (ClientSecretKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ClientSecretKey);
      }
      if (RegionCustomConfigEncrypted.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(RegionCustomConfigEncrypted);
      }
      if (ClientRegionCustomConfigEncrypted.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ClientRegionCustomConfigEncrypted);
      }
      if (detailCase_ == DetailOneofCase.ForceUdpate) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ForceUdpate);
      }
      if (detailCase_ == DetailOneofCase.StopServer) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StopServer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryCurrRegionHttpRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      if (other.regionInfo_ != null) {
        if (regionInfo_ == null) {
          RegionInfo = new global::Weedwacker.Server.Proto.RegionInfo();
        }
        RegionInfo.MergeFrom(other.RegionInfo);
      }
      if (other.ClientSecretKey.Length != 0) {
        ClientSecretKey = other.ClientSecretKey;
      }
      if (other.RegionCustomConfigEncrypted.Length != 0) {
        RegionCustomConfigEncrypted = other.RegionCustomConfigEncrypted;
      }
      if (other.ClientRegionCustomConfigEncrypted.Length != 0) {
        ClientRegionCustomConfigEncrypted = other.ClientRegionCustomConfigEncrypted;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.ForceUdpate:
          if (ForceUdpate == null) {
            ForceUdpate = new global::Weedwacker.Server.Proto.ForceUpdateInfo();
          }
          ForceUdpate.MergeFrom(other.ForceUdpate);
          break;
        case DetailOneofCase.StopServer:
          if (StopServer == null) {
            StopServer = new global::Weedwacker.Server.Proto.StopServerInfo();
          }
          StopServer.MergeFrom(other.StopServer);
          break;
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
            Retcode = input.ReadInt32();
            break;
          }
          case 18: {
            Msg = input.ReadString();
            break;
          }
          case 26: {
            if (regionInfo_ == null) {
              RegionInfo = new global::Weedwacker.Server.Proto.RegionInfo();
            }
            input.ReadMessage(RegionInfo);
            break;
          }
          case 34: {
            global::Weedwacker.Server.Proto.ForceUpdateInfo subBuilder = new global::Weedwacker.Server.Proto.ForceUpdateInfo();
            if (detailCase_ == DetailOneofCase.ForceUdpate) {
              subBuilder.MergeFrom(ForceUdpate);
            }
            input.ReadMessage(subBuilder);
            ForceUdpate = subBuilder;
            break;
          }
          case 42: {
            global::Weedwacker.Server.Proto.StopServerInfo subBuilder = new global::Weedwacker.Server.Proto.StopServerInfo();
            if (detailCase_ == DetailOneofCase.StopServer) {
              subBuilder.MergeFrom(StopServer);
            }
            input.ReadMessage(subBuilder);
            StopServer = subBuilder;
            break;
          }
          case 90: {
            ClientSecretKey = input.ReadBytes();
            break;
          }
          case 98: {
            RegionCustomConfigEncrypted = input.ReadBytes();
            break;
          }
          case 106: {
            ClientRegionCustomConfigEncrypted = input.ReadBytes();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 18: {
            Msg = input.ReadString();
            break;
          }
          case 26: {
            if (regionInfo_ == null) {
              RegionInfo = new global::Weedwacker.Server.Proto.RegionInfo();
            }
            input.ReadMessage(RegionInfo);
            break;
          }
          case 34: {
            global::Weedwacker.Server.Proto.ForceUpdateInfo subBuilder = new global::Weedwacker.Server.Proto.ForceUpdateInfo();
            if (detailCase_ == DetailOneofCase.ForceUdpate) {
              subBuilder.MergeFrom(ForceUdpate);
            }
            input.ReadMessage(subBuilder);
            ForceUdpate = subBuilder;
            break;
          }
          case 42: {
            global::Weedwacker.Server.Proto.StopServerInfo subBuilder = new global::Weedwacker.Server.Proto.StopServerInfo();
            if (detailCase_ == DetailOneofCase.StopServer) {
              subBuilder.MergeFrom(StopServer);
            }
            input.ReadMessage(subBuilder);
            StopServer = subBuilder;
            break;
          }
          case 90: {
            ClientSecretKey = input.ReadBytes();
            break;
          }
          case 98: {
            RegionCustomConfigEncrypted = input.ReadBytes();
            break;
          }
          case 106: {
            ClientRegionCustomConfigEncrypted = input.ReadBytes();
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
