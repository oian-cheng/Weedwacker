// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Shop.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Shop.proto</summary>
  public static partial class ShopReflection {

    #region Descriptor
    /// <summary>File descriptor for Shop.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShopReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpTaG9wLnByb3RvGhVTaG9wQ2FyZFByb2R1Y3QucHJvdG8aGFNob3BDb25j",
            "ZXJ0UHJvZHVjdC5wcm90bxoPU2hvcEdvb2RzLnByb3RvGhZTaG9wTWNvaW5Q",
            "cm9kdWN0LnByb3RvIpMCCgRTaG9wEjEKFGNvbmNlcnRfcHJvZHVjdF9saXN0",
            "GAMgAygLMhMuU2hvcENvbmNlcnRQcm9kdWN0Eh4KCmdvb2RzX2xpc3QYDyAD",
            "KAsyCi5TaG9wR29vZHMSHQoVY2l0eV9yZXB1dGF0aW9uX2xldmVsGAIgASgN",
            "EisKEWNhcmRfcHJvZHVjdF9saXN0GA4gAygLMhAuU2hvcENhcmRQcm9kdWN0",
            "Ei0KEm1jb2luX3Byb2R1Y3RfbGlzdBgHIAMoCzIRLlNob3BNY29pblByb2R1",
            "Y3QSGQoRbmV4dF9yZWZyZXNoX3RpbWUYCyABKA0SDwoHY2l0eV9pZBgKIAEo",
            "DRIRCglzaG9wX3R5cGUYDSABKA1CGqoCF1dlZWR3YWNrZXIuU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.ShopCardProductReflection.Descriptor, global::Weedwacker.Server.Proto.ShopConcertProductReflection.Descriptor, global::Weedwacker.Server.Proto.ShopGoodsReflection.Descriptor, global::Weedwacker.Server.Proto.ShopMcoinProductReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Shop), global::Weedwacker.Server.Proto.Shop.Parser, new[]{ "ConcertProductList", "GoodsList", "CityReputationLevel", "CardProductList", "McoinProductList", "NextRefreshTime", "CityId", "ShopType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Shop : pb::IMessage<Shop>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Shop> _parser = new pb::MessageParser<Shop>(() => new Shop());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Shop> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ShopReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop(Shop other) : this() {
      concertProductList_ = other.concertProductList_.Clone();
      goodsList_ = other.goodsList_.Clone();
      cityReputationLevel_ = other.cityReputationLevel_;
      cardProductList_ = other.cardProductList_.Clone();
      mcoinProductList_ = other.mcoinProductList_.Clone();
      nextRefreshTime_ = other.nextRefreshTime_;
      cityId_ = other.cityId_;
      shopType_ = other.shopType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop Clone() {
      return new Shop(this);
    }

    /// <summary>Field number for the "concert_product_list" field.</summary>
    public const int ConcertProductListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ShopConcertProduct> _repeated_concertProductList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Server.Proto.ShopConcertProduct.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopConcertProduct> concertProductList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopConcertProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopConcertProduct> ConcertProductList {
      get { return concertProductList_; }
    }

    /// <summary>Field number for the "goods_list" field.</summary>
    public const int GoodsListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ShopGoods> _repeated_goodsList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Server.Proto.ShopGoods.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopGoods> goodsList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopGoods>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopGoods> GoodsList {
      get { return goodsList_; }
    }

    /// <summary>Field number for the "city_reputation_level" field.</summary>
    public const int CityReputationLevelFieldNumber = 2;
    private uint cityReputationLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityReputationLevel {
      get { return cityReputationLevel_; }
      set {
        cityReputationLevel_ = value;
      }
    }

    /// <summary>Field number for the "card_product_list" field.</summary>
    public const int CardProductListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ShopCardProduct> _repeated_cardProductList_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Server.Proto.ShopCardProduct.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopCardProduct> cardProductList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopCardProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopCardProduct> CardProductList {
      get { return cardProductList_; }
    }

    /// <summary>Field number for the "mcoin_product_list" field.</summary>
    public const int McoinProductListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ShopMcoinProduct> _repeated_mcoinProductList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Server.Proto.ShopMcoinProduct.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopMcoinProduct> mcoinProductList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopMcoinProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ShopMcoinProduct> McoinProductList {
      get { return mcoinProductList_; }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 11;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "city_id" field.</summary>
    public const int CityIdFieldNumber = 10;
    private uint cityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityId {
      get { return cityId_; }
      set {
        cityId_ = value;
      }
    }

    /// <summary>Field number for the "shop_type" field.</summary>
    public const int ShopTypeFieldNumber = 13;
    private uint shopType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopType {
      get { return shopType_; }
      set {
        shopType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Shop);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Shop other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!concertProductList_.Equals(other.concertProductList_)) return false;
      if(!goodsList_.Equals(other.goodsList_)) return false;
      if (CityReputationLevel != other.CityReputationLevel) return false;
      if(!cardProductList_.Equals(other.cardProductList_)) return false;
      if(!mcoinProductList_.Equals(other.mcoinProductList_)) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if (CityId != other.CityId) return false;
      if (ShopType != other.ShopType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= concertProductList_.GetHashCode();
      hash ^= goodsList_.GetHashCode();
      if (CityReputationLevel != 0) hash ^= CityReputationLevel.GetHashCode();
      hash ^= cardProductList_.GetHashCode();
      hash ^= mcoinProductList_.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      if (CityId != 0) hash ^= CityId.GetHashCode();
      if (ShopType != 0) hash ^= ShopType.GetHashCode();
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
      if (CityReputationLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CityReputationLevel);
      }
      concertProductList_.WriteTo(output, _repeated_concertProductList_codec);
      mcoinProductList_.WriteTo(output, _repeated_mcoinProductList_codec);
      if (CityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CityId);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NextRefreshTime);
      }
      if (ShopType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ShopType);
      }
      cardProductList_.WriteTo(output, _repeated_cardProductList_codec);
      goodsList_.WriteTo(output, _repeated_goodsList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CityReputationLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CityReputationLevel);
      }
      concertProductList_.WriteTo(ref output, _repeated_concertProductList_codec);
      mcoinProductList_.WriteTo(ref output, _repeated_mcoinProductList_codec);
      if (CityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CityId);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(NextRefreshTime);
      }
      if (ShopType != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ShopType);
      }
      cardProductList_.WriteTo(ref output, _repeated_cardProductList_codec);
      goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += concertProductList_.CalculateSize(_repeated_concertProductList_codec);
      size += goodsList_.CalculateSize(_repeated_goodsList_codec);
      if (CityReputationLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityReputationLevel);
      }
      size += cardProductList_.CalculateSize(_repeated_cardProductList_codec);
      size += mcoinProductList_.CalculateSize(_repeated_mcoinProductList_codec);
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      if (CityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
      }
      if (ShopType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Shop other) {
      if (other == null) {
        return;
      }
      concertProductList_.Add(other.concertProductList_);
      goodsList_.Add(other.goodsList_);
      if (other.CityReputationLevel != 0) {
        CityReputationLevel = other.CityReputationLevel;
      }
      cardProductList_.Add(other.cardProductList_);
      mcoinProductList_.Add(other.mcoinProductList_);
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      if (other.CityId != 0) {
        CityId = other.CityId;
      }
      if (other.ShopType != 0) {
        ShopType = other.ShopType;
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
            CityReputationLevel = input.ReadUInt32();
            break;
          }
          case 26: {
            concertProductList_.AddEntriesFrom(input, _repeated_concertProductList_codec);
            break;
          }
          case 58: {
            mcoinProductList_.AddEntriesFrom(input, _repeated_mcoinProductList_codec);
            break;
          }
          case 80: {
            CityId = input.ReadUInt32();
            break;
          }
          case 88: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 104: {
            ShopType = input.ReadUInt32();
            break;
          }
          case 114: {
            cardProductList_.AddEntriesFrom(input, _repeated_cardProductList_codec);
            break;
          }
          case 122: {
            goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
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
            CityReputationLevel = input.ReadUInt32();
            break;
          }
          case 26: {
            concertProductList_.AddEntriesFrom(ref input, _repeated_concertProductList_codec);
            break;
          }
          case 58: {
            mcoinProductList_.AddEntriesFrom(ref input, _repeated_mcoinProductList_codec);
            break;
          }
          case 80: {
            CityId = input.ReadUInt32();
            break;
          }
          case 88: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 104: {
            ShopType = input.ReadUInt32();
            break;
          }
          case 114: {
            cardProductList_.AddEntriesFrom(ref input, _repeated_cardProductList_codec);
            break;
          }
          case 122: {
            goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
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
