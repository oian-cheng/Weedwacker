// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishtankFishInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FishtankFishInfo.proto</summary>
  public static partial class FishtankFishInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FishtankFishInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishtankFishInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGaXNodGFua0Zpc2hJbmZvLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvImQKEEZpc2h0YW5rRmlzaEluZm8SIAoYZmlzaF9kaXN0",
            "YW5jZV9mcm9tX3dhdGVyGAEgASgCEhIKCmZpc2hfc2NhbGUYAiABKAISGgoS",
            "aW5pdGlhbF9yb3RhdGlvbl95GAMgASgCYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FishtankFishInfo), global::Weedwacker.Shared.Network.Proto.FishtankFishInfo.Parser, new[]{ "FishDistanceFromWater", "FishScale", "InitialRotationY" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FishtankFishInfo : pb::IMessage<FishtankFishInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FishtankFishInfo> _parser = new pb::MessageParser<FishtankFishInfo>(() => new FishtankFishInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FishtankFishInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FishtankFishInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishtankFishInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishtankFishInfo(FishtankFishInfo other) : this() {
      fishDistanceFromWater_ = other.fishDistanceFromWater_;
      fishScale_ = other.fishScale_;
      initialRotationY_ = other.initialRotationY_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishtankFishInfo Clone() {
      return new FishtankFishInfo(this);
    }

    /// <summary>Field number for the "fish_distance_from_water" field.</summary>
    public const int FishDistanceFromWaterFieldNumber = 1;
    private float fishDistanceFromWater_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float FishDistanceFromWater {
      get { return fishDistanceFromWater_; }
      set {
        fishDistanceFromWater_ = value;
      }
    }

    /// <summary>Field number for the "fish_scale" field.</summary>
    public const int FishScaleFieldNumber = 2;
    private float fishScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float FishScale {
      get { return fishScale_; }
      set {
        fishScale_ = value;
      }
    }

    /// <summary>Field number for the "initial_rotation_y" field.</summary>
    public const int InitialRotationYFieldNumber = 3;
    private float initialRotationY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float InitialRotationY {
      get { return initialRotationY_; }
      set {
        initialRotationY_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FishtankFishInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FishtankFishInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FishDistanceFromWater, other.FishDistanceFromWater)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FishScale, other.FishScale)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InitialRotationY, other.InitialRotationY)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FishDistanceFromWater != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FishDistanceFromWater);
      if (FishScale != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FishScale);
      if (InitialRotationY != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InitialRotationY);
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
      if (FishDistanceFromWater != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(FishDistanceFromWater);
      }
      if (FishScale != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(FishScale);
      }
      if (InitialRotationY != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(InitialRotationY);
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
      if (FishDistanceFromWater != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(FishDistanceFromWater);
      }
      if (FishScale != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(FishScale);
      }
      if (InitialRotationY != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(InitialRotationY);
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
      if (FishDistanceFromWater != 0F) {
        size += 1 + 4;
      }
      if (FishScale != 0F) {
        size += 1 + 4;
      }
      if (InitialRotationY != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FishtankFishInfo other) {
      if (other == null) {
        return;
      }
      if (other.FishDistanceFromWater != 0F) {
        FishDistanceFromWater = other.FishDistanceFromWater;
      }
      if (other.FishScale != 0F) {
        FishScale = other.FishScale;
      }
      if (other.InitialRotationY != 0F) {
        InitialRotationY = other.InitialRotationY;
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
          case 13: {
            FishDistanceFromWater = input.ReadFloat();
            break;
          }
          case 21: {
            FishScale = input.ReadFloat();
            break;
          }
          case 29: {
            InitialRotationY = input.ReadFloat();
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
          case 13: {
            FishDistanceFromWater = input.ReadFloat();
            break;
          }
          case 21: {
            FishScale = input.ReadFloat();
            break;
          }
          case 29: {
            InitialRotationY = input.ReadFloat();
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
