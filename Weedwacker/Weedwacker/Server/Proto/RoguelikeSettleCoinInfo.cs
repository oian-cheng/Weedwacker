// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoguelikeSettleCoinInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from RoguelikeSettleCoinInfo.proto</summary>
  public static partial class RoguelikeSettleCoinInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RoguelikeSettleCoinInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoguelikeSettleCoinInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Sb2d1ZWxpa2VTZXR0bGVDb2luSW5mby5wcm90byJLChdSb2d1ZWxpa2VT",
            "ZXR0bGVDb2luSW5mbxIOCgZjb2luX2MYCCABKA0SDgoGY29pbl9iGAogASgN",
            "EhAKCGNlbGxfbnVtGAEgASgNQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.RoguelikeSettleCoinInfo), global::Weedwacker.Server.Proto.RoguelikeSettleCoinInfo.Parser, new[]{ "CoinC", "CoinB", "CellNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoguelikeSettleCoinInfo : pb::IMessage<RoguelikeSettleCoinInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RoguelikeSettleCoinInfo> _parser = new pb::MessageParser<RoguelikeSettleCoinInfo>(() => new RoguelikeSettleCoinInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RoguelikeSettleCoinInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.RoguelikeSettleCoinInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeSettleCoinInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeSettleCoinInfo(RoguelikeSettleCoinInfo other) : this() {
      coinC_ = other.coinC_;
      coinB_ = other.coinB_;
      cellNum_ = other.cellNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeSettleCoinInfo Clone() {
      return new RoguelikeSettleCoinInfo(this);
    }

    /// <summary>Field number for the "coin_c" field.</summary>
    public const int CoinCFieldNumber = 8;
    private uint coinC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinC {
      get { return coinC_; }
      set {
        coinC_ = value;
      }
    }

    /// <summary>Field number for the "coin_b" field.</summary>
    public const int CoinBFieldNumber = 10;
    private uint coinB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinB {
      get { return coinB_; }
      set {
        coinB_ = value;
      }
    }

    /// <summary>Field number for the "cell_num" field.</summary>
    public const int CellNumFieldNumber = 1;
    private uint cellNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CellNum {
      get { return cellNum_; }
      set {
        cellNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RoguelikeSettleCoinInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RoguelikeSettleCoinInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CoinC != other.CoinC) return false;
      if (CoinB != other.CoinB) return false;
      if (CellNum != other.CellNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CoinC != 0) hash ^= CoinC.GetHashCode();
      if (CoinB != 0) hash ^= CoinB.GetHashCode();
      if (CellNum != 0) hash ^= CellNum.GetHashCode();
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
      if (CellNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CellNum);
      }
      if (CoinC != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CoinC);
      }
      if (CoinB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CoinB);
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
      if (CellNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CellNum);
      }
      if (CoinC != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CoinC);
      }
      if (CoinB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CoinB);
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
      if (CoinC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinC);
      }
      if (CoinB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinB);
      }
      if (CellNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CellNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RoguelikeSettleCoinInfo other) {
      if (other == null) {
        return;
      }
      if (other.CoinC != 0) {
        CoinC = other.CoinC;
      }
      if (other.CoinB != 0) {
        CoinB = other.CoinB;
      }
      if (other.CellNum != 0) {
        CellNum = other.CellNum;
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
            CellNum = input.ReadUInt32();
            break;
          }
          case 64: {
            CoinC = input.ReadUInt32();
            break;
          }
          case 80: {
            CoinB = input.ReadUInt32();
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
            CellNum = input.ReadUInt32();
            break;
          }
          case 64: {
            CoinC = input.ReadUInt32();
            break;
          }
          case 80: {
            CoinB = input.ReadUInt32();
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
