// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BeginCameraSceneLookNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BeginCameraSceneLookNotify.proto</summary>
  public static partial class BeginCameraSceneLookNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BeginCameraSceneLookNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BeginCameraSceneLookNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBCZWdpbkNhbWVyYVNjZW5lTG9va05vdGlmeS5wcm90bxIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90bxoMVmVjdG9yLnByb3RvIpgGChpCZWdp",
            "bkNhbWVyYVNjZW5lTG9va05vdGlmeRIcChNVbmszMzAwX0hLS0NIQ0VNSklF",
            "GLQNIAEoAhIbChNVbmszMzAwX0RGUENNT0ZPTk5LGA8gASgIEhsKE1VuazMz",
            "MDBfRUVMTk9BSUNIT0oYBCABKAgSGwoTVW5rMzMwMF9PREFETUJCRlBBUBgH",
            "IAEoCBIQCghkdXJhdGlvbhgCIAEoAhIcChNVbmszMzAwX0tDSEtLQk9ETkNK",
            "GNINIAEoDRIbChNVbmszMzAwX0ZJT0xHQ0lLRkxIGAogASgCEhQKDG90aGVy",
            "X3BhcmFtcxgJIAMoCRIbChNVbmszMzAwX05KTEJJTUpERkhKGAMgASgIEhwK",
            "E1VuazMzMDBfQUFPR0JDQ05KQUYYyAkgASgIEhIKCWVudGl0eV9pZBj7CiAB",
            "KA0SXgoNa2VlcF9yb3RfdHlwZRgLIAEoDjJHLldlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8uQmVnaW5DYW1lcmFTY2VuZUxvb2tOb3RpZnkuS2Vl",
            "cFJvdFR5cGUSRAoTVW5rMzMwMF9QUENJRElDTUlFThgIIAEoCzInLldlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9yEhwKE1VuazMzMDBf",
            "QUpFRU5FT0NGT04YxQcgASgNEhsKE1VuazMzMDBfT05CRE1DSEZQREwYBSAB",
            "KAgSGwoTVW5rMzMwMF9QSUVGTEFFR0dCSRgGIAEoCBJEChNVbmszMzAwX0ZK",
            "REZHTE5MTUJOGA0gASgLMicuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90by5WZWN0b3ISGwoTVW5rMzMwMF9JTE1IRExITEtHShgBIAEoCBIbChNV",
            "bmszMzAwX0hDTFBHR0FPSUFDGAwgASgCEhsKE1VuazMzMDBfSEZQQ0hGTkZK",
            "S1AYDiABKAIiOAoLS2VlcFJvdFR5cGUSEwoPS0VFUF9ST1RfVFlQRV9YEAAS",
            "FAoQS0VFUF9ST1RfVFlQRV9YWRABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify), global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Parser, new[]{ "Unk3300HKKCHCEMJIE", "Unk3300DFPCMOFONNK", "Unk3300EELNOAICHOJ", "Unk3300ODADMBBFPAP", "Duration", "Unk3300KCHKKBODNCJ", "Unk3300FIOLGCIKFLH", "OtherParams", "Unk3300NJLBIMJDFHJ", "Unk3300AAOGBCCNJAF", "EntityId", "KeepRotType", "Unk3300PPCIDICMIEN", "Unk3300AJEENEOCFON", "Unk3300ONBDMCHFPDL", "Unk3300PIEFLAEGGBI", "Unk3300FJDFGLNLMBN", "Unk3300ILMHDLHLKGJ", "Unk3300HCLPGGAOIAC", "Unk3300HFPCHFNFJKP" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 249;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class BeginCameraSceneLookNotify : pb::IMessage<BeginCameraSceneLookNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BeginCameraSceneLookNotify> _parser = new pb::MessageParser<BeginCameraSceneLookNotify>(() => new BeginCameraSceneLookNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BeginCameraSceneLookNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify(BeginCameraSceneLookNotify other) : this() {
      unk3300HKKCHCEMJIE_ = other.unk3300HKKCHCEMJIE_;
      unk3300DFPCMOFONNK_ = other.unk3300DFPCMOFONNK_;
      unk3300EELNOAICHOJ_ = other.unk3300EELNOAICHOJ_;
      unk3300ODADMBBFPAP_ = other.unk3300ODADMBBFPAP_;
      duration_ = other.duration_;
      unk3300KCHKKBODNCJ_ = other.unk3300KCHKKBODNCJ_;
      unk3300FIOLGCIKFLH_ = other.unk3300FIOLGCIKFLH_;
      otherParams_ = other.otherParams_.Clone();
      unk3300NJLBIMJDFHJ_ = other.unk3300NJLBIMJDFHJ_;
      unk3300AAOGBCCNJAF_ = other.unk3300AAOGBCCNJAF_;
      entityId_ = other.entityId_;
      keepRotType_ = other.keepRotType_;
      unk3300PPCIDICMIEN_ = other.unk3300PPCIDICMIEN_ != null ? other.unk3300PPCIDICMIEN_.Clone() : null;
      unk3300AJEENEOCFON_ = other.unk3300AJEENEOCFON_;
      unk3300ONBDMCHFPDL_ = other.unk3300ONBDMCHFPDL_;
      unk3300PIEFLAEGGBI_ = other.unk3300PIEFLAEGGBI_;
      unk3300FJDFGLNLMBN_ = other.unk3300FJDFGLNLMBN_ != null ? other.unk3300FJDFGLNLMBN_.Clone() : null;
      unk3300ILMHDLHLKGJ_ = other.unk3300ILMHDLHLKGJ_;
      unk3300HCLPGGAOIAC_ = other.unk3300HCLPGGAOIAC_;
      unk3300HFPCHFNFJKP_ = other.unk3300HFPCHFNFJKP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify Clone() {
      return new BeginCameraSceneLookNotify(this);
    }

    /// <summary>Field number for the "Unk3300_HKKCHCEMJIE" field.</summary>
    public const int Unk3300HKKCHCEMJIEFieldNumber = 1716;
    private float unk3300HKKCHCEMJIE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300HKKCHCEMJIE {
      get { return unk3300HKKCHCEMJIE_; }
      set {
        unk3300HKKCHCEMJIE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DFPCMOFONNK" field.</summary>
    public const int Unk3300DFPCMOFONNKFieldNumber = 15;
    private bool unk3300DFPCMOFONNK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300DFPCMOFONNK {
      get { return unk3300DFPCMOFONNK_; }
      set {
        unk3300DFPCMOFONNK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EELNOAICHOJ" field.</summary>
    public const int Unk3300EELNOAICHOJFieldNumber = 4;
    private bool unk3300EELNOAICHOJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300EELNOAICHOJ {
      get { return unk3300EELNOAICHOJ_; }
      set {
        unk3300EELNOAICHOJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ODADMBBFPAP" field.</summary>
    public const int Unk3300ODADMBBFPAPFieldNumber = 7;
    private bool unk3300ODADMBBFPAP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300ODADMBBFPAP {
      get { return unk3300ODADMBBFPAP_; }
      set {
        unk3300ODADMBBFPAP_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 2;
    private float duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KCHKKBODNCJ" field.</summary>
    public const int Unk3300KCHKKBODNCJFieldNumber = 1746;
    private uint unk3300KCHKKBODNCJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KCHKKBODNCJ {
      get { return unk3300KCHKKBODNCJ_; }
      set {
        unk3300KCHKKBODNCJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FIOLGCIKFLH" field.</summary>
    public const int Unk3300FIOLGCIKFLHFieldNumber = 10;
    private float unk3300FIOLGCIKFLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300FIOLGCIKFLH {
      get { return unk3300FIOLGCIKFLH_; }
      set {
        unk3300FIOLGCIKFLH_ = value;
      }
    }

    /// <summary>Field number for the "other_params" field.</summary>
    public const int OtherParamsFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _repeated_otherParams_codec
        = pb::FieldCodec.ForString(74);
    private readonly pbc::RepeatedField<string> otherParams_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> OtherParams {
      get { return otherParams_; }
    }

    /// <summary>Field number for the "Unk3300_NJLBIMJDFHJ" field.</summary>
    public const int Unk3300NJLBIMJDFHJFieldNumber = 3;
    private bool unk3300NJLBIMJDFHJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300NJLBIMJDFHJ {
      get { return unk3300NJLBIMJDFHJ_; }
      set {
        unk3300NJLBIMJDFHJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AAOGBCCNJAF" field.</summary>
    public const int Unk3300AAOGBCCNJAFFieldNumber = 1224;
    private bool unk3300AAOGBCCNJAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300AAOGBCCNJAF {
      get { return unk3300AAOGBCCNJAF_; }
      set {
        unk3300AAOGBCCNJAF_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1403;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "keep_rot_type" field.</summary>
    public const int KeepRotTypeFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType keepRotType_ = global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType KeepRotType {
      get { return keepRotType_; }
      set {
        keepRotType_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PPCIDICMIEN" field.</summary>
    public const int Unk3300PPCIDICMIENFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.Vector unk3300PPCIDICMIEN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Unk3300PPCIDICMIEN {
      get { return unk3300PPCIDICMIEN_; }
      set {
        unk3300PPCIDICMIEN_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AJEENEOCFON" field.</summary>
    public const int Unk3300AJEENEOCFONFieldNumber = 965;
    private uint unk3300AJEENEOCFON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AJEENEOCFON {
      get { return unk3300AJEENEOCFON_; }
      set {
        unk3300AJEENEOCFON_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ONBDMCHFPDL" field.</summary>
    public const int Unk3300ONBDMCHFPDLFieldNumber = 5;
    private bool unk3300ONBDMCHFPDL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300ONBDMCHFPDL {
      get { return unk3300ONBDMCHFPDL_; }
      set {
        unk3300ONBDMCHFPDL_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PIEFLAEGGBI" field.</summary>
    public const int Unk3300PIEFLAEGGBIFieldNumber = 6;
    private bool unk3300PIEFLAEGGBI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300PIEFLAEGGBI {
      get { return unk3300PIEFLAEGGBI_; }
      set {
        unk3300PIEFLAEGGBI_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FJDFGLNLMBN" field.</summary>
    public const int Unk3300FJDFGLNLMBNFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.Vector unk3300FJDFGLNLMBN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Unk3300FJDFGLNLMBN {
      get { return unk3300FJDFGLNLMBN_; }
      set {
        unk3300FJDFGLNLMBN_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ILMHDLHLKGJ" field.</summary>
    public const int Unk3300ILMHDLHLKGJFieldNumber = 1;
    private bool unk3300ILMHDLHLKGJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300ILMHDLHLKGJ {
      get { return unk3300ILMHDLHLKGJ_; }
      set {
        unk3300ILMHDLHLKGJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HCLPGGAOIAC" field.</summary>
    public const int Unk3300HCLPGGAOIACFieldNumber = 12;
    private float unk3300HCLPGGAOIAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300HCLPGGAOIAC {
      get { return unk3300HCLPGGAOIAC_; }
      set {
        unk3300HCLPGGAOIAC_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HFPCHFNFJKP" field.</summary>
    public const int Unk3300HFPCHFNFJKPFieldNumber = 14;
    private float unk3300HFPCHFNFJKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300HFPCHFNFJKP {
      get { return unk3300HFPCHFNFJKP_; }
      set {
        unk3300HFPCHFNFJKP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BeginCameraSceneLookNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BeginCameraSceneLookNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300HKKCHCEMJIE, other.Unk3300HKKCHCEMJIE)) return false;
      if (Unk3300DFPCMOFONNK != other.Unk3300DFPCMOFONNK) return false;
      if (Unk3300EELNOAICHOJ != other.Unk3300EELNOAICHOJ) return false;
      if (Unk3300ODADMBBFPAP != other.Unk3300ODADMBBFPAP) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Duration, other.Duration)) return false;
      if (Unk3300KCHKKBODNCJ != other.Unk3300KCHKKBODNCJ) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300FIOLGCIKFLH, other.Unk3300FIOLGCIKFLH)) return false;
      if(!otherParams_.Equals(other.otherParams_)) return false;
      if (Unk3300NJLBIMJDFHJ != other.Unk3300NJLBIMJDFHJ) return false;
      if (Unk3300AAOGBCCNJAF != other.Unk3300AAOGBCCNJAF) return false;
      if (EntityId != other.EntityId) return false;
      if (KeepRotType != other.KeepRotType) return false;
      if (!object.Equals(Unk3300PPCIDICMIEN, other.Unk3300PPCIDICMIEN)) return false;
      if (Unk3300AJEENEOCFON != other.Unk3300AJEENEOCFON) return false;
      if (Unk3300ONBDMCHFPDL != other.Unk3300ONBDMCHFPDL) return false;
      if (Unk3300PIEFLAEGGBI != other.Unk3300PIEFLAEGGBI) return false;
      if (!object.Equals(Unk3300FJDFGLNLMBN, other.Unk3300FJDFGLNLMBN)) return false;
      if (Unk3300ILMHDLHLKGJ != other.Unk3300ILMHDLHLKGJ) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300HCLPGGAOIAC, other.Unk3300HCLPGGAOIAC)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300HFPCHFNFJKP, other.Unk3300HFPCHFNFJKP)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300HKKCHCEMJIE != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300HKKCHCEMJIE);
      if (Unk3300DFPCMOFONNK != false) hash ^= Unk3300DFPCMOFONNK.GetHashCode();
      if (Unk3300EELNOAICHOJ != false) hash ^= Unk3300EELNOAICHOJ.GetHashCode();
      if (Unk3300ODADMBBFPAP != false) hash ^= Unk3300ODADMBBFPAP.GetHashCode();
      if (Duration != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Duration);
      if (Unk3300KCHKKBODNCJ != 0) hash ^= Unk3300KCHKKBODNCJ.GetHashCode();
      if (Unk3300FIOLGCIKFLH != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300FIOLGCIKFLH);
      hash ^= otherParams_.GetHashCode();
      if (Unk3300NJLBIMJDFHJ != false) hash ^= Unk3300NJLBIMJDFHJ.GetHashCode();
      if (Unk3300AAOGBCCNJAF != false) hash ^= Unk3300AAOGBCCNJAF.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) hash ^= KeepRotType.GetHashCode();
      if (unk3300PPCIDICMIEN_ != null) hash ^= Unk3300PPCIDICMIEN.GetHashCode();
      if (Unk3300AJEENEOCFON != 0) hash ^= Unk3300AJEENEOCFON.GetHashCode();
      if (Unk3300ONBDMCHFPDL != false) hash ^= Unk3300ONBDMCHFPDL.GetHashCode();
      if (Unk3300PIEFLAEGGBI != false) hash ^= Unk3300PIEFLAEGGBI.GetHashCode();
      if (unk3300FJDFGLNLMBN_ != null) hash ^= Unk3300FJDFGLNLMBN.GetHashCode();
      if (Unk3300ILMHDLHLKGJ != false) hash ^= Unk3300ILMHDLHLKGJ.GetHashCode();
      if (Unk3300HCLPGGAOIAC != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300HCLPGGAOIAC);
      if (Unk3300HFPCHFNFJKP != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300HFPCHFNFJKP);
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
      if (Unk3300ILMHDLHLKGJ != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300ILMHDLHLKGJ);
      }
      if (Duration != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Duration);
      }
      if (Unk3300NJLBIMJDFHJ != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300NJLBIMJDFHJ);
      }
      if (Unk3300EELNOAICHOJ != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk3300EELNOAICHOJ);
      }
      if (Unk3300ONBDMCHFPDL != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unk3300ONBDMCHFPDL);
      }
      if (Unk3300PIEFLAEGGBI != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300PIEFLAEGGBI);
      }
      if (Unk3300ODADMBBFPAP != false) {
        output.WriteRawTag(56);
        output.WriteBool(Unk3300ODADMBBFPAP);
      }
      if (unk3300PPCIDICMIEN_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Unk3300PPCIDICMIEN);
      }
      otherParams_.WriteTo(output, _repeated_otherParams_codec);
      if (Unk3300FIOLGCIKFLH != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(Unk3300FIOLGCIKFLH);
      }
      if (KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        output.WriteRawTag(88);
        output.WriteEnum((int) KeepRotType);
      }
      if (Unk3300HCLPGGAOIAC != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(Unk3300HCLPGGAOIAC);
      }
      if (unk3300FJDFGLNLMBN_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Unk3300FJDFGLNLMBN);
      }
      if (Unk3300HFPCHFNFJKP != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(Unk3300HFPCHFNFJKP);
      }
      if (Unk3300DFPCMOFONNK != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk3300DFPCMOFONNK);
      }
      if (Unk3300AJEENEOCFON != 0) {
        output.WriteRawTag(168, 60);
        output.WriteUInt32(Unk3300AJEENEOCFON);
      }
      if (Unk3300AAOGBCCNJAF != false) {
        output.WriteRawTag(192, 76);
        output.WriteBool(Unk3300AAOGBCCNJAF);
      }
      if (EntityId != 0) {
        output.WriteRawTag(216, 87);
        output.WriteUInt32(EntityId);
      }
      if (Unk3300HKKCHCEMJIE != 0F) {
        output.WriteRawTag(165, 107);
        output.WriteFloat(Unk3300HKKCHCEMJIE);
      }
      if (Unk3300KCHKKBODNCJ != 0) {
        output.WriteRawTag(144, 109);
        output.WriteUInt32(Unk3300KCHKKBODNCJ);
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
      if (Unk3300ILMHDLHLKGJ != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300ILMHDLHLKGJ);
      }
      if (Duration != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Duration);
      }
      if (Unk3300NJLBIMJDFHJ != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300NJLBIMJDFHJ);
      }
      if (Unk3300EELNOAICHOJ != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk3300EELNOAICHOJ);
      }
      if (Unk3300ONBDMCHFPDL != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unk3300ONBDMCHFPDL);
      }
      if (Unk3300PIEFLAEGGBI != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300PIEFLAEGGBI);
      }
      if (Unk3300ODADMBBFPAP != false) {
        output.WriteRawTag(56);
        output.WriteBool(Unk3300ODADMBBFPAP);
      }
      if (unk3300PPCIDICMIEN_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Unk3300PPCIDICMIEN);
      }
      otherParams_.WriteTo(ref output, _repeated_otherParams_codec);
      if (Unk3300FIOLGCIKFLH != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(Unk3300FIOLGCIKFLH);
      }
      if (KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        output.WriteRawTag(88);
        output.WriteEnum((int) KeepRotType);
      }
      if (Unk3300HCLPGGAOIAC != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(Unk3300HCLPGGAOIAC);
      }
      if (unk3300FJDFGLNLMBN_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Unk3300FJDFGLNLMBN);
      }
      if (Unk3300HFPCHFNFJKP != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(Unk3300HFPCHFNFJKP);
      }
      if (Unk3300DFPCMOFONNK != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk3300DFPCMOFONNK);
      }
      if (Unk3300AJEENEOCFON != 0) {
        output.WriteRawTag(168, 60);
        output.WriteUInt32(Unk3300AJEENEOCFON);
      }
      if (Unk3300AAOGBCCNJAF != false) {
        output.WriteRawTag(192, 76);
        output.WriteBool(Unk3300AAOGBCCNJAF);
      }
      if (EntityId != 0) {
        output.WriteRawTag(216, 87);
        output.WriteUInt32(EntityId);
      }
      if (Unk3300HKKCHCEMJIE != 0F) {
        output.WriteRawTag(165, 107);
        output.WriteFloat(Unk3300HKKCHCEMJIE);
      }
      if (Unk3300KCHKKBODNCJ != 0) {
        output.WriteRawTag(144, 109);
        output.WriteUInt32(Unk3300KCHKKBODNCJ);
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
      if (Unk3300HKKCHCEMJIE != 0F) {
        size += 2 + 4;
      }
      if (Unk3300DFPCMOFONNK != false) {
        size += 1 + 1;
      }
      if (Unk3300EELNOAICHOJ != false) {
        size += 1 + 1;
      }
      if (Unk3300ODADMBBFPAP != false) {
        size += 1 + 1;
      }
      if (Duration != 0F) {
        size += 1 + 4;
      }
      if (Unk3300KCHKKBODNCJ != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KCHKKBODNCJ);
      }
      if (Unk3300FIOLGCIKFLH != 0F) {
        size += 1 + 4;
      }
      size += otherParams_.CalculateSize(_repeated_otherParams_codec);
      if (Unk3300NJLBIMJDFHJ != false) {
        size += 1 + 1;
      }
      if (Unk3300AAOGBCCNJAF != false) {
        size += 2 + 1;
      }
      if (EntityId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) KeepRotType);
      }
      if (unk3300PPCIDICMIEN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3300PPCIDICMIEN);
      }
      if (Unk3300AJEENEOCFON != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AJEENEOCFON);
      }
      if (Unk3300ONBDMCHFPDL != false) {
        size += 1 + 1;
      }
      if (Unk3300PIEFLAEGGBI != false) {
        size += 1 + 1;
      }
      if (unk3300FJDFGLNLMBN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3300FJDFGLNLMBN);
      }
      if (Unk3300ILMHDLHLKGJ != false) {
        size += 1 + 1;
      }
      if (Unk3300HCLPGGAOIAC != 0F) {
        size += 1 + 4;
      }
      if (Unk3300HFPCHFNFJKP != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BeginCameraSceneLookNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300HKKCHCEMJIE != 0F) {
        Unk3300HKKCHCEMJIE = other.Unk3300HKKCHCEMJIE;
      }
      if (other.Unk3300DFPCMOFONNK != false) {
        Unk3300DFPCMOFONNK = other.Unk3300DFPCMOFONNK;
      }
      if (other.Unk3300EELNOAICHOJ != false) {
        Unk3300EELNOAICHOJ = other.Unk3300EELNOAICHOJ;
      }
      if (other.Unk3300ODADMBBFPAP != false) {
        Unk3300ODADMBBFPAP = other.Unk3300ODADMBBFPAP;
      }
      if (other.Duration != 0F) {
        Duration = other.Duration;
      }
      if (other.Unk3300KCHKKBODNCJ != 0) {
        Unk3300KCHKKBODNCJ = other.Unk3300KCHKKBODNCJ;
      }
      if (other.Unk3300FIOLGCIKFLH != 0F) {
        Unk3300FIOLGCIKFLH = other.Unk3300FIOLGCIKFLH;
      }
      otherParams_.Add(other.otherParams_);
      if (other.Unk3300NJLBIMJDFHJ != false) {
        Unk3300NJLBIMJDFHJ = other.Unk3300NJLBIMJDFHJ;
      }
      if (other.Unk3300AAOGBCCNJAF != false) {
        Unk3300AAOGBCCNJAF = other.Unk3300AAOGBCCNJAF;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        KeepRotType = other.KeepRotType;
      }
      if (other.unk3300PPCIDICMIEN_ != null) {
        if (unk3300PPCIDICMIEN_ == null) {
          Unk3300PPCIDICMIEN = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Unk3300PPCIDICMIEN.MergeFrom(other.Unk3300PPCIDICMIEN);
      }
      if (other.Unk3300AJEENEOCFON != 0) {
        Unk3300AJEENEOCFON = other.Unk3300AJEENEOCFON;
      }
      if (other.Unk3300ONBDMCHFPDL != false) {
        Unk3300ONBDMCHFPDL = other.Unk3300ONBDMCHFPDL;
      }
      if (other.Unk3300PIEFLAEGGBI != false) {
        Unk3300PIEFLAEGGBI = other.Unk3300PIEFLAEGGBI;
      }
      if (other.unk3300FJDFGLNLMBN_ != null) {
        if (unk3300FJDFGLNLMBN_ == null) {
          Unk3300FJDFGLNLMBN = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Unk3300FJDFGLNLMBN.MergeFrom(other.Unk3300FJDFGLNLMBN);
      }
      if (other.Unk3300ILMHDLHLKGJ != false) {
        Unk3300ILMHDLHLKGJ = other.Unk3300ILMHDLHLKGJ;
      }
      if (other.Unk3300HCLPGGAOIAC != 0F) {
        Unk3300HCLPGGAOIAC = other.Unk3300HCLPGGAOIAC;
      }
      if (other.Unk3300HFPCHFNFJKP != 0F) {
        Unk3300HFPCHFNFJKP = other.Unk3300HFPCHFNFJKP;
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
            Unk3300ILMHDLHLKGJ = input.ReadBool();
            break;
          }
          case 21: {
            Duration = input.ReadFloat();
            break;
          }
          case 24: {
            Unk3300NJLBIMJDFHJ = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300EELNOAICHOJ = input.ReadBool();
            break;
          }
          case 40: {
            Unk3300ONBDMCHFPDL = input.ReadBool();
            break;
          }
          case 48: {
            Unk3300PIEFLAEGGBI = input.ReadBool();
            break;
          }
          case 56: {
            Unk3300ODADMBBFPAP = input.ReadBool();
            break;
          }
          case 66: {
            if (unk3300PPCIDICMIEN_ == null) {
              Unk3300PPCIDICMIEN = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk3300PPCIDICMIEN);
            break;
          }
          case 74: {
            otherParams_.AddEntriesFrom(input, _repeated_otherParams_codec);
            break;
          }
          case 85: {
            Unk3300FIOLGCIKFLH = input.ReadFloat();
            break;
          }
          case 88: {
            KeepRotType = (global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType) input.ReadEnum();
            break;
          }
          case 101: {
            Unk3300HCLPGGAOIAC = input.ReadFloat();
            break;
          }
          case 106: {
            if (unk3300FJDFGLNLMBN_ == null) {
              Unk3300FJDFGLNLMBN = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk3300FJDFGLNLMBN);
            break;
          }
          case 117: {
            Unk3300HFPCHFNFJKP = input.ReadFloat();
            break;
          }
          case 120: {
            Unk3300DFPCMOFONNK = input.ReadBool();
            break;
          }
          case 7720: {
            Unk3300AJEENEOCFON = input.ReadUInt32();
            break;
          }
          case 9792: {
            Unk3300AAOGBCCNJAF = input.ReadBool();
            break;
          }
          case 11224: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 13733: {
            Unk3300HKKCHCEMJIE = input.ReadFloat();
            break;
          }
          case 13968: {
            Unk3300KCHKKBODNCJ = input.ReadUInt32();
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
            Unk3300ILMHDLHLKGJ = input.ReadBool();
            break;
          }
          case 21: {
            Duration = input.ReadFloat();
            break;
          }
          case 24: {
            Unk3300NJLBIMJDFHJ = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300EELNOAICHOJ = input.ReadBool();
            break;
          }
          case 40: {
            Unk3300ONBDMCHFPDL = input.ReadBool();
            break;
          }
          case 48: {
            Unk3300PIEFLAEGGBI = input.ReadBool();
            break;
          }
          case 56: {
            Unk3300ODADMBBFPAP = input.ReadBool();
            break;
          }
          case 66: {
            if (unk3300PPCIDICMIEN_ == null) {
              Unk3300PPCIDICMIEN = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk3300PPCIDICMIEN);
            break;
          }
          case 74: {
            otherParams_.AddEntriesFrom(ref input, _repeated_otherParams_codec);
            break;
          }
          case 85: {
            Unk3300FIOLGCIKFLH = input.ReadFloat();
            break;
          }
          case 88: {
            KeepRotType = (global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType) input.ReadEnum();
            break;
          }
          case 101: {
            Unk3300HCLPGGAOIAC = input.ReadFloat();
            break;
          }
          case 106: {
            if (unk3300FJDFGLNLMBN_ == null) {
              Unk3300FJDFGLNLMBN = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk3300FJDFGLNLMBN);
            break;
          }
          case 117: {
            Unk3300HFPCHFNFJKP = input.ReadFloat();
            break;
          }
          case 120: {
            Unk3300DFPCMOFONNK = input.ReadBool();
            break;
          }
          case 7720: {
            Unk3300AJEENEOCFON = input.ReadUInt32();
            break;
          }
          case 9792: {
            Unk3300AAOGBCCNJAF = input.ReadBool();
            break;
          }
          case 11224: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 13733: {
            Unk3300HKKCHCEMJIE = input.ReadFloat();
            break;
          }
          case 13968: {
            Unk3300KCHKKBODNCJ = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the BeginCameraSceneLookNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum KeepRotType {
        [pbr::OriginalName("KEEP_ROT_TYPE_X")] X = 0,
        [pbr::OriginalName("KEEP_ROT_TYPE_XY")] Xy = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
