// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairMinigameInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FleurFairMinigameInfo.proto</summary>
  public static partial class FleurFairMinigameInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairMinigameInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairMinigameInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtGbGV1ckZhaXJNaW5pZ2FtZUluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aGkZsZXVyRmFpckJhbGxvb25JbmZvLnByb3Rv",
            "GhdGbGV1ckZhaXJGYWxsSW5mby5wcm90bxocRmxldXJGYWlyTXVzaWNHYW1l",
            "SW5mby5wcm90byLBAgoVRmxldXJGYWlyTWluaWdhbWVJbmZvEhMKC21pbmln",
            "YW1lX2lkGAMgASgNEg8KB2lzX29wZW4YDyABKAgSEQoJb3Blbl90aW1lGA0g",
            "ASgNEk0KDGJhbGxvb25faW5mbxgBIAEoCzI1LldlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8uRmxldXJGYWlyQmFsbG9vbkluZm9IABJHCglmYWxs",
            "X2luZm8YCiABKAsyMi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "LkZsZXVyRmFpckZhbGxJbmZvSAASTQoKbXVzaWNfaW5mbxgOIAEoCzI3Lldl",
            "ZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uRmxldXJGYWlyTXVzaWNH",
            "YW1lSW5mb0gAQggKBmRldGFpbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FleurFairBalloonInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.FleurFairFallInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.FleurFairMusicGameInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FleurFairMinigameInfo), global::Weedwacker.Shared.Network.Proto.FleurFairMinigameInfo.Parser, new[]{ "MinigameId", "IsOpen", "OpenTime", "BalloonInfo", "FallInfo", "MusicInfo" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FleurFairMinigameInfo : pb::IMessage<FleurFairMinigameInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairMinigameInfo> _parser = new pb::MessageParser<FleurFairMinigameInfo>(() => new FleurFairMinigameInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairMinigameInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FleurFairMinigameInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMinigameInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMinigameInfo(FleurFairMinigameInfo other) : this() {
      minigameId_ = other.minigameId_;
      isOpen_ = other.isOpen_;
      openTime_ = other.openTime_;
      switch (other.DetailCase) {
        case DetailOneofCase.BalloonInfo:
          BalloonInfo = other.BalloonInfo.Clone();
          break;
        case DetailOneofCase.FallInfo:
          FallInfo = other.FallInfo.Clone();
          break;
        case DetailOneofCase.MusicInfo:
          MusicInfo = other.MusicInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMinigameInfo Clone() {
      return new FleurFairMinigameInfo(this);
    }

    /// <summary>Field number for the "minigame_id" field.</summary>
    public const int MinigameIdFieldNumber = 3;
    private uint minigameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinigameId {
      get { return minigameId_; }
      set {
        minigameId_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 15;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 13;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "balloon_info" field.</summary>
    public const int BalloonInfoFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FleurFairBalloonInfo BalloonInfo {
      get { return detailCase_ == DetailOneofCase.BalloonInfo ? (global::Weedwacker.Shared.Network.Proto.FleurFairBalloonInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.BalloonInfo;
      }
    }

    /// <summary>Field number for the "fall_info" field.</summary>
    public const int FallInfoFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FleurFairFallInfo FallInfo {
      get { return detailCase_ == DetailOneofCase.FallInfo ? (global::Weedwacker.Shared.Network.Proto.FleurFairFallInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.FallInfo;
      }
    }

    /// <summary>Field number for the "music_info" field.</summary>
    public const int MusicInfoFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FleurFairMusicGameInfo MusicInfo {
      get { return detailCase_ == DetailOneofCase.MusicInfo ? (global::Weedwacker.Shared.Network.Proto.FleurFairMusicGameInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.MusicInfo;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      BalloonInfo = 1,
      FallInfo = 10,
      MusicInfo = 14,
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
      return Equals(other as FleurFairMinigameInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairMinigameInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinigameId != other.MinigameId) return false;
      if (IsOpen != other.IsOpen) return false;
      if (OpenTime != other.OpenTime) return false;
      if (!object.Equals(BalloonInfo, other.BalloonInfo)) return false;
      if (!object.Equals(FallInfo, other.FallInfo)) return false;
      if (!object.Equals(MusicInfo, other.MusicInfo)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MinigameId != 0) hash ^= MinigameId.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (detailCase_ == DetailOneofCase.BalloonInfo) hash ^= BalloonInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.FallInfo) hash ^= FallInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.MusicInfo) hash ^= MusicInfo.GetHashCode();
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
      if (detailCase_ == DetailOneofCase.BalloonInfo) {
        output.WriteRawTag(10);
        output.WriteMessage(BalloonInfo);
      }
      if (MinigameId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MinigameId);
      }
      if (detailCase_ == DetailOneofCase.FallInfo) {
        output.WriteRawTag(82);
        output.WriteMessage(FallInfo);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(OpenTime);
      }
      if (detailCase_ == DetailOneofCase.MusicInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(MusicInfo);
      }
      if (IsOpen != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsOpen);
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
      if (detailCase_ == DetailOneofCase.BalloonInfo) {
        output.WriteRawTag(10);
        output.WriteMessage(BalloonInfo);
      }
      if (MinigameId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MinigameId);
      }
      if (detailCase_ == DetailOneofCase.FallInfo) {
        output.WriteRawTag(82);
        output.WriteMessage(FallInfo);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(OpenTime);
      }
      if (detailCase_ == DetailOneofCase.MusicInfo) {
        output.WriteRawTag(114);
        output.WriteMessage(MusicInfo);
      }
      if (IsOpen != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsOpen);
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
      if (MinigameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinigameId);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (detailCase_ == DetailOneofCase.BalloonInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BalloonInfo);
      }
      if (detailCase_ == DetailOneofCase.FallInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FallInfo);
      }
      if (detailCase_ == DetailOneofCase.MusicInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MusicInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairMinigameInfo other) {
      if (other == null) {
        return;
      }
      if (other.MinigameId != 0) {
        MinigameId = other.MinigameId;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.BalloonInfo:
          if (BalloonInfo == null) {
            BalloonInfo = new global::Weedwacker.Shared.Network.Proto.FleurFairBalloonInfo();
          }
          BalloonInfo.MergeFrom(other.BalloonInfo);
          break;
        case DetailOneofCase.FallInfo:
          if (FallInfo == null) {
            FallInfo = new global::Weedwacker.Shared.Network.Proto.FleurFairFallInfo();
          }
          FallInfo.MergeFrom(other.FallInfo);
          break;
        case DetailOneofCase.MusicInfo:
          if (MusicInfo == null) {
            MusicInfo = new global::Weedwacker.Shared.Network.Proto.FleurFairMusicGameInfo();
          }
          MusicInfo.MergeFrom(other.MusicInfo);
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
          case 10: {
            global::Weedwacker.Shared.Network.Proto.FleurFairBalloonInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairBalloonInfo();
            if (detailCase_ == DetailOneofCase.BalloonInfo) {
              subBuilder.MergeFrom(BalloonInfo);
            }
            input.ReadMessage(subBuilder);
            BalloonInfo = subBuilder;
            break;
          }
          case 24: {
            MinigameId = input.ReadUInt32();
            break;
          }
          case 82: {
            global::Weedwacker.Shared.Network.Proto.FleurFairFallInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairFallInfo();
            if (detailCase_ == DetailOneofCase.FallInfo) {
              subBuilder.MergeFrom(FallInfo);
            }
            input.ReadMessage(subBuilder);
            FallInfo = subBuilder;
            break;
          }
          case 104: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 114: {
            global::Weedwacker.Shared.Network.Proto.FleurFairMusicGameInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairMusicGameInfo();
            if (detailCase_ == DetailOneofCase.MusicInfo) {
              subBuilder.MergeFrom(MusicInfo);
            }
            input.ReadMessage(subBuilder);
            MusicInfo = subBuilder;
            break;
          }
          case 120: {
            IsOpen = input.ReadBool();
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
            global::Weedwacker.Shared.Network.Proto.FleurFairBalloonInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairBalloonInfo();
            if (detailCase_ == DetailOneofCase.BalloonInfo) {
              subBuilder.MergeFrom(BalloonInfo);
            }
            input.ReadMessage(subBuilder);
            BalloonInfo = subBuilder;
            break;
          }
          case 24: {
            MinigameId = input.ReadUInt32();
            break;
          }
          case 82: {
            global::Weedwacker.Shared.Network.Proto.FleurFairFallInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairFallInfo();
            if (detailCase_ == DetailOneofCase.FallInfo) {
              subBuilder.MergeFrom(FallInfo);
            }
            input.ReadMessage(subBuilder);
            FallInfo = subBuilder;
            break;
          }
          case 104: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 114: {
            global::Weedwacker.Shared.Network.Proto.FleurFairMusicGameInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.FleurFairMusicGameInfo();
            if (detailCase_ == DetailOneofCase.MusicInfo) {
              subBuilder.MergeFrom(MusicInfo);
            }
            input.ReadMessage(subBuilder);
            MusicInfo = subBuilder;
            break;
          }
          case 120: {
            IsOpen = input.ReadBool();
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
