// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerEyePointStateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerEyePointStateNotify.proto</summary>
  public static partial class PlayerEyePointStateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerEyePointStateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerEyePointStateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9QbGF5ZXJFeWVQb2ludFN0YXRlTm90aWZ5LnByb3RvEh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvGhhDeWxpbmRlclJlZ2lvblNpemUucHJv",
            "dG8aF1BvbHlnb25SZWdpb25TaXplLnByb3RvGgxWZWN0b3IucHJvdG8ipQQK",
            "GVBsYXllckV5ZVBvaW50U3RhdGVOb3RpZnkSPgoNZXllX3BvaW50X3BvcxgM",
            "IAEoCzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9y",
            "EhsKE1VuazMzMDBfS0ZPSE9CTE1NTEIYCSABKAgSGwoTVW5rMzMwMF9HTkZK",
            "SU9FR0hPRRgBIAEoDRIbChNVbmszMzAwX0JJSEVLTkZERERJGAggASgNEhUK",
            "DWZpeF9sb2RfbGV2ZWwYCyABKAUSGwoTVW5rMzMwMF9OSVBGQ0ZDQkZBRRgO",
            "IAEoCBIbChNVbmszMzAwX0pHRU1LS0pBSEtBGA0gASgNEhsKE1VuazMzMDBf",
            "RU9QRk5CQkJHUEsYBiABKA0SGAoNc3BoZXJlX3JhZGl1cxiFCyABKAJIABI+",
            "CgpjdWJpY19zaXplGNIKIAEoCzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8uVmVjdG9ySAASTQoNY3lsaW5kZXJfc2l6ZRjiCSABKAsyMy5X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkN5bGluZGVyUmVnaW9u",
            "U2l6ZUgAEksKDHBvbHlnb25fc2l6ZRjgBCABKAsyMi5XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvLlBvbHlnb25SZWdpb25TaXplSABCDQoLcmVn",
            "aW9uX3NpemViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CylinderRegionSizeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.PolygonRegionSizeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerEyePointStateNotify), global::Weedwacker.Shared.Network.Proto.PlayerEyePointStateNotify.Parser, new[]{ "EyePointPos", "Unk3300KFOHOBLMMLB", "Unk3300GNFJIOEGHOE", "Unk3300BIHEKNFDDDI", "FixLodLevel", "Unk3300NIPFCFCBFAE", "Unk3300JGEMKKJAHKA", "Unk3300EOPFNBBBGPK", "SphereRadius", "CubicSize", "CylinderSize", "PolygonSize" }, new[]{ "RegionSize" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 3079;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerEyePointStateNotify : pb::IMessage<PlayerEyePointStateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerEyePointStateNotify> _parser = new pb::MessageParser<PlayerEyePointStateNotify>(() => new PlayerEyePointStateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerEyePointStateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerEyePointStateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEyePointStateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEyePointStateNotify(PlayerEyePointStateNotify other) : this() {
      eyePointPos_ = other.eyePointPos_ != null ? other.eyePointPos_.Clone() : null;
      unk3300KFOHOBLMMLB_ = other.unk3300KFOHOBLMMLB_;
      unk3300GNFJIOEGHOE_ = other.unk3300GNFJIOEGHOE_;
      unk3300BIHEKNFDDDI_ = other.unk3300BIHEKNFDDDI_;
      fixLodLevel_ = other.fixLodLevel_;
      unk3300NIPFCFCBFAE_ = other.unk3300NIPFCFCBFAE_;
      unk3300JGEMKKJAHKA_ = other.unk3300JGEMKKJAHKA_;
      unk3300EOPFNBBBGPK_ = other.unk3300EOPFNBBBGPK_;
      switch (other.RegionSizeCase) {
        case RegionSizeOneofCase.SphereRadius:
          SphereRadius = other.SphereRadius;
          break;
        case RegionSizeOneofCase.CubicSize:
          CubicSize = other.CubicSize.Clone();
          break;
        case RegionSizeOneofCase.CylinderSize:
          CylinderSize = other.CylinderSize.Clone();
          break;
        case RegionSizeOneofCase.PolygonSize:
          PolygonSize = other.PolygonSize.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEyePointStateNotify Clone() {
      return new PlayerEyePointStateNotify(this);
    }

    /// <summary>Field number for the "eye_point_pos" field.</summary>
    public const int EyePointPosFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.Vector eyePointPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector EyePointPos {
      get { return eyePointPos_; }
      set {
        eyePointPos_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KFOHOBLMMLB" field.</summary>
    public const int Unk3300KFOHOBLMMLBFieldNumber = 9;
    private bool unk3300KFOHOBLMMLB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300KFOHOBLMMLB {
      get { return unk3300KFOHOBLMMLB_; }
      set {
        unk3300KFOHOBLMMLB_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GNFJIOEGHOE" field.</summary>
    public const int Unk3300GNFJIOEGHOEFieldNumber = 1;
    private uint unk3300GNFJIOEGHOE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GNFJIOEGHOE {
      get { return unk3300GNFJIOEGHOE_; }
      set {
        unk3300GNFJIOEGHOE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BIHEKNFDDDI" field.</summary>
    public const int Unk3300BIHEKNFDDDIFieldNumber = 8;
    private uint unk3300BIHEKNFDDDI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300BIHEKNFDDDI {
      get { return unk3300BIHEKNFDDDI_; }
      set {
        unk3300BIHEKNFDDDI_ = value;
      }
    }

    /// <summary>Field number for the "fix_lod_level" field.</summary>
    public const int FixLodLevelFieldNumber = 11;
    private int fixLodLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FixLodLevel {
      get { return fixLodLevel_; }
      set {
        fixLodLevel_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NIPFCFCBFAE" field.</summary>
    public const int Unk3300NIPFCFCBFAEFieldNumber = 14;
    private bool unk3300NIPFCFCBFAE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300NIPFCFCBFAE {
      get { return unk3300NIPFCFCBFAE_; }
      set {
        unk3300NIPFCFCBFAE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JGEMKKJAHKA" field.</summary>
    public const int Unk3300JGEMKKJAHKAFieldNumber = 13;
    private uint unk3300JGEMKKJAHKA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JGEMKKJAHKA {
      get { return unk3300JGEMKKJAHKA_; }
      set {
        unk3300JGEMKKJAHKA_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EOPFNBBBGPK" field.</summary>
    public const int Unk3300EOPFNBBBGPKFieldNumber = 6;
    private uint unk3300EOPFNBBBGPK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EOPFNBBBGPK {
      get { return unk3300EOPFNBBBGPK_; }
      set {
        unk3300EOPFNBBBGPK_ = value;
      }
    }

    /// <summary>Field number for the "sphere_radius" field.</summary>
    public const int SphereRadiusFieldNumber = 1413;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float SphereRadius {
      get { return regionSizeCase_ == RegionSizeOneofCase.SphereRadius ? (float) regionSize_ : 0F; }
      set {
        regionSize_ = value;
        regionSizeCase_ = RegionSizeOneofCase.SphereRadius;
      }
    }

    /// <summary>Field number for the "cubic_size" field.</summary>
    public const int CubicSizeFieldNumber = 1362;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector CubicSize {
      get { return regionSizeCase_ == RegionSizeOneofCase.CubicSize ? (global::Weedwacker.Shared.Network.Proto.Vector) regionSize_ : null; }
      set {
        regionSize_ = value;
        regionSizeCase_ = value == null ? RegionSizeOneofCase.None : RegionSizeOneofCase.CubicSize;
      }
    }

    /// <summary>Field number for the "cylinder_size" field.</summary>
    public const int CylinderSizeFieldNumber = 1250;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CylinderRegionSize CylinderSize {
      get { return regionSizeCase_ == RegionSizeOneofCase.CylinderSize ? (global::Weedwacker.Shared.Network.Proto.CylinderRegionSize) regionSize_ : null; }
      set {
        regionSize_ = value;
        regionSizeCase_ = value == null ? RegionSizeOneofCase.None : RegionSizeOneofCase.CylinderSize;
      }
    }

    /// <summary>Field number for the "polygon_size" field.</summary>
    public const int PolygonSizeFieldNumber = 608;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.PolygonRegionSize PolygonSize {
      get { return regionSizeCase_ == RegionSizeOneofCase.PolygonSize ? (global::Weedwacker.Shared.Network.Proto.PolygonRegionSize) regionSize_ : null; }
      set {
        regionSize_ = value;
        regionSizeCase_ = value == null ? RegionSizeOneofCase.None : RegionSizeOneofCase.PolygonSize;
      }
    }

    private object regionSize_;
    /// <summary>Enum of possible cases for the "region_size" oneof.</summary>
    public enum RegionSizeOneofCase {
      None = 0,
      SphereRadius = 1413,
      CubicSize = 1362,
      CylinderSize = 1250,
      PolygonSize = 608,
    }
    private RegionSizeOneofCase regionSizeCase_ = RegionSizeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegionSizeOneofCase RegionSizeCase {
      get { return regionSizeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRegionSize() {
      regionSizeCase_ = RegionSizeOneofCase.None;
      regionSize_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerEyePointStateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerEyePointStateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EyePointPos, other.EyePointPos)) return false;
      if (Unk3300KFOHOBLMMLB != other.Unk3300KFOHOBLMMLB) return false;
      if (Unk3300GNFJIOEGHOE != other.Unk3300GNFJIOEGHOE) return false;
      if (Unk3300BIHEKNFDDDI != other.Unk3300BIHEKNFDDDI) return false;
      if (FixLodLevel != other.FixLodLevel) return false;
      if (Unk3300NIPFCFCBFAE != other.Unk3300NIPFCFCBFAE) return false;
      if (Unk3300JGEMKKJAHKA != other.Unk3300JGEMKKJAHKA) return false;
      if (Unk3300EOPFNBBBGPK != other.Unk3300EOPFNBBBGPK) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SphereRadius, other.SphereRadius)) return false;
      if (!object.Equals(CubicSize, other.CubicSize)) return false;
      if (!object.Equals(CylinderSize, other.CylinderSize)) return false;
      if (!object.Equals(PolygonSize, other.PolygonSize)) return false;
      if (RegionSizeCase != other.RegionSizeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eyePointPos_ != null) hash ^= EyePointPos.GetHashCode();
      if (Unk3300KFOHOBLMMLB != false) hash ^= Unk3300KFOHOBLMMLB.GetHashCode();
      if (Unk3300GNFJIOEGHOE != 0) hash ^= Unk3300GNFJIOEGHOE.GetHashCode();
      if (Unk3300BIHEKNFDDDI != 0) hash ^= Unk3300BIHEKNFDDDI.GetHashCode();
      if (FixLodLevel != 0) hash ^= FixLodLevel.GetHashCode();
      if (Unk3300NIPFCFCBFAE != false) hash ^= Unk3300NIPFCFCBFAE.GetHashCode();
      if (Unk3300JGEMKKJAHKA != 0) hash ^= Unk3300JGEMKKJAHKA.GetHashCode();
      if (Unk3300EOPFNBBBGPK != 0) hash ^= Unk3300EOPFNBBBGPK.GetHashCode();
      if (regionSizeCase_ == RegionSizeOneofCase.SphereRadius) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SphereRadius);
      if (regionSizeCase_ == RegionSizeOneofCase.CubicSize) hash ^= CubicSize.GetHashCode();
      if (regionSizeCase_ == RegionSizeOneofCase.CylinderSize) hash ^= CylinderSize.GetHashCode();
      if (regionSizeCase_ == RegionSizeOneofCase.PolygonSize) hash ^= PolygonSize.GetHashCode();
      hash ^= (int) regionSizeCase_;
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
      if (Unk3300GNFJIOEGHOE != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300GNFJIOEGHOE);
      }
      if (Unk3300EOPFNBBBGPK != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300EOPFNBBBGPK);
      }
      if (Unk3300BIHEKNFDDDI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300BIHEKNFDDDI);
      }
      if (Unk3300KFOHOBLMMLB != false) {
        output.WriteRawTag(72);
        output.WriteBool(Unk3300KFOHOBLMMLB);
      }
      if (FixLodLevel != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(FixLodLevel);
      }
      if (eyePointPos_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(EyePointPos);
      }
      if (Unk3300JGEMKKJAHKA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300JGEMKKJAHKA);
      }
      if (Unk3300NIPFCFCBFAE != false) {
        output.WriteRawTag(112);
        output.WriteBool(Unk3300NIPFCFCBFAE);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.PolygonSize) {
        output.WriteRawTag(130, 38);
        output.WriteMessage(PolygonSize);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.CylinderSize) {
        output.WriteRawTag(146, 78);
        output.WriteMessage(CylinderSize);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.CubicSize) {
        output.WriteRawTag(146, 85);
        output.WriteMessage(CubicSize);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.SphereRadius) {
        output.WriteRawTag(173, 88);
        output.WriteFloat(SphereRadius);
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
      if (Unk3300GNFJIOEGHOE != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300GNFJIOEGHOE);
      }
      if (Unk3300EOPFNBBBGPK != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300EOPFNBBBGPK);
      }
      if (Unk3300BIHEKNFDDDI != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300BIHEKNFDDDI);
      }
      if (Unk3300KFOHOBLMMLB != false) {
        output.WriteRawTag(72);
        output.WriteBool(Unk3300KFOHOBLMMLB);
      }
      if (FixLodLevel != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(FixLodLevel);
      }
      if (eyePointPos_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(EyePointPos);
      }
      if (Unk3300JGEMKKJAHKA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300JGEMKKJAHKA);
      }
      if (Unk3300NIPFCFCBFAE != false) {
        output.WriteRawTag(112);
        output.WriteBool(Unk3300NIPFCFCBFAE);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.PolygonSize) {
        output.WriteRawTag(130, 38);
        output.WriteMessage(PolygonSize);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.CylinderSize) {
        output.WriteRawTag(146, 78);
        output.WriteMessage(CylinderSize);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.CubicSize) {
        output.WriteRawTag(146, 85);
        output.WriteMessage(CubicSize);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.SphereRadius) {
        output.WriteRawTag(173, 88);
        output.WriteFloat(SphereRadius);
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
      if (eyePointPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EyePointPos);
      }
      if (Unk3300KFOHOBLMMLB != false) {
        size += 1 + 1;
      }
      if (Unk3300GNFJIOEGHOE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GNFJIOEGHOE);
      }
      if (Unk3300BIHEKNFDDDI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300BIHEKNFDDDI);
      }
      if (FixLodLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FixLodLevel);
      }
      if (Unk3300NIPFCFCBFAE != false) {
        size += 1 + 1;
      }
      if (Unk3300JGEMKKJAHKA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JGEMKKJAHKA);
      }
      if (Unk3300EOPFNBBBGPK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EOPFNBBBGPK);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.SphereRadius) {
        size += 2 + 4;
      }
      if (regionSizeCase_ == RegionSizeOneofCase.CubicSize) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CubicSize);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.CylinderSize) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CylinderSize);
      }
      if (regionSizeCase_ == RegionSizeOneofCase.PolygonSize) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(PolygonSize);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerEyePointStateNotify other) {
      if (other == null) {
        return;
      }
      if (other.eyePointPos_ != null) {
        if (eyePointPos_ == null) {
          EyePointPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        EyePointPos.MergeFrom(other.EyePointPos);
      }
      if (other.Unk3300KFOHOBLMMLB != false) {
        Unk3300KFOHOBLMMLB = other.Unk3300KFOHOBLMMLB;
      }
      if (other.Unk3300GNFJIOEGHOE != 0) {
        Unk3300GNFJIOEGHOE = other.Unk3300GNFJIOEGHOE;
      }
      if (other.Unk3300BIHEKNFDDDI != 0) {
        Unk3300BIHEKNFDDDI = other.Unk3300BIHEKNFDDDI;
      }
      if (other.FixLodLevel != 0) {
        FixLodLevel = other.FixLodLevel;
      }
      if (other.Unk3300NIPFCFCBFAE != false) {
        Unk3300NIPFCFCBFAE = other.Unk3300NIPFCFCBFAE;
      }
      if (other.Unk3300JGEMKKJAHKA != 0) {
        Unk3300JGEMKKJAHKA = other.Unk3300JGEMKKJAHKA;
      }
      if (other.Unk3300EOPFNBBBGPK != 0) {
        Unk3300EOPFNBBBGPK = other.Unk3300EOPFNBBBGPK;
      }
      switch (other.RegionSizeCase) {
        case RegionSizeOneofCase.SphereRadius:
          SphereRadius = other.SphereRadius;
          break;
        case RegionSizeOneofCase.CubicSize:
          if (CubicSize == null) {
            CubicSize = new global::Weedwacker.Shared.Network.Proto.Vector();
          }
          CubicSize.MergeFrom(other.CubicSize);
          break;
        case RegionSizeOneofCase.CylinderSize:
          if (CylinderSize == null) {
            CylinderSize = new global::Weedwacker.Shared.Network.Proto.CylinderRegionSize();
          }
          CylinderSize.MergeFrom(other.CylinderSize);
          break;
        case RegionSizeOneofCase.PolygonSize:
          if (PolygonSize == null) {
            PolygonSize = new global::Weedwacker.Shared.Network.Proto.PolygonRegionSize();
          }
          PolygonSize.MergeFrom(other.PolygonSize);
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
            Unk3300GNFJIOEGHOE = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300EOPFNBBBGPK = input.ReadUInt32();
            break;
          }
          case 64: {
            Unk3300BIHEKNFDDDI = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300KFOHOBLMMLB = input.ReadBool();
            break;
          }
          case 88: {
            FixLodLevel = input.ReadInt32();
            break;
          }
          case 98: {
            if (eyePointPos_ == null) {
              EyePointPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(EyePointPos);
            break;
          }
          case 104: {
            Unk3300JGEMKKJAHKA = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300NIPFCFCBFAE = input.ReadBool();
            break;
          }
          case 4866: {
            global::Weedwacker.Shared.Network.Proto.PolygonRegionSize subBuilder = new global::Weedwacker.Shared.Network.Proto.PolygonRegionSize();
            if (regionSizeCase_ == RegionSizeOneofCase.PolygonSize) {
              subBuilder.MergeFrom(PolygonSize);
            }
            input.ReadMessage(subBuilder);
            PolygonSize = subBuilder;
            break;
          }
          case 10002: {
            global::Weedwacker.Shared.Network.Proto.CylinderRegionSize subBuilder = new global::Weedwacker.Shared.Network.Proto.CylinderRegionSize();
            if (regionSizeCase_ == RegionSizeOneofCase.CylinderSize) {
              subBuilder.MergeFrom(CylinderSize);
            }
            input.ReadMessage(subBuilder);
            CylinderSize = subBuilder;
            break;
          }
          case 10898: {
            global::Weedwacker.Shared.Network.Proto.Vector subBuilder = new global::Weedwacker.Shared.Network.Proto.Vector();
            if (regionSizeCase_ == RegionSizeOneofCase.CubicSize) {
              subBuilder.MergeFrom(CubicSize);
            }
            input.ReadMessage(subBuilder);
            CubicSize = subBuilder;
            break;
          }
          case 11309: {
            SphereRadius = input.ReadFloat();
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
            Unk3300GNFJIOEGHOE = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300EOPFNBBBGPK = input.ReadUInt32();
            break;
          }
          case 64: {
            Unk3300BIHEKNFDDDI = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300KFOHOBLMMLB = input.ReadBool();
            break;
          }
          case 88: {
            FixLodLevel = input.ReadInt32();
            break;
          }
          case 98: {
            if (eyePointPos_ == null) {
              EyePointPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(EyePointPos);
            break;
          }
          case 104: {
            Unk3300JGEMKKJAHKA = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300NIPFCFCBFAE = input.ReadBool();
            break;
          }
          case 4866: {
            global::Weedwacker.Shared.Network.Proto.PolygonRegionSize subBuilder = new global::Weedwacker.Shared.Network.Proto.PolygonRegionSize();
            if (regionSizeCase_ == RegionSizeOneofCase.PolygonSize) {
              subBuilder.MergeFrom(PolygonSize);
            }
            input.ReadMessage(subBuilder);
            PolygonSize = subBuilder;
            break;
          }
          case 10002: {
            global::Weedwacker.Shared.Network.Proto.CylinderRegionSize subBuilder = new global::Weedwacker.Shared.Network.Proto.CylinderRegionSize();
            if (regionSizeCase_ == RegionSizeOneofCase.CylinderSize) {
              subBuilder.MergeFrom(CylinderSize);
            }
            input.ReadMessage(subBuilder);
            CylinderSize = subBuilder;
            break;
          }
          case 10898: {
            global::Weedwacker.Shared.Network.Proto.Vector subBuilder = new global::Weedwacker.Shared.Network.Proto.Vector();
            if (regionSizeCase_ == RegionSizeOneofCase.CubicSize) {
              subBuilder.MergeFrom(CubicSize);
            }
            input.ReadMessage(subBuilder);
            CubicSize = subBuilder;
            break;
          }
          case 11309: {
            SphereRadius = input.ReadFloat();
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
