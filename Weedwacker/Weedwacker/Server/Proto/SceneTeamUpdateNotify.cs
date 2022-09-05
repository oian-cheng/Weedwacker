// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneTeamUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from SceneTeamUpdateNotify.proto</summary>
  public static partial class SceneTeamUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneTeamUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneTeamUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtTY2VuZVRlYW1VcGRhdGVOb3RpZnkucHJvdG8aFVNjZW5lVGVhbUF2YXRh",
            "ci5wcm90byJbChVTY2VuZVRlYW1VcGRhdGVOb3RpZnkSMAoWc2NlbmVfdGVh",
            "bV9hdmF0YXJfbGlzdBgLIAMoCzIQLlNjZW5lVGVhbUF2YXRhchIQCghpc19p",
            "bl9tcBgPIAEoCEIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.SceneTeamAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.SceneTeamUpdateNotify), global::Weedwacker.Server.Proto.SceneTeamUpdateNotify.Parser, new[]{ "SceneTeamAvatarList", "IsInMp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1775
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class SceneTeamUpdateNotify : pb::IMessage<SceneTeamUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneTeamUpdateNotify> _parser = new pb::MessageParser<SceneTeamUpdateNotify>(() => new SceneTeamUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneTeamUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.SceneTeamUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneTeamUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneTeamUpdateNotify(SceneTeamUpdateNotify other) : this() {
      sceneTeamAvatarList_ = other.sceneTeamAvatarList_.Clone();
      isInMp_ = other.isInMp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneTeamUpdateNotify Clone() {
      return new SceneTeamUpdateNotify(this);
    }

    /// <summary>Field number for the "scene_team_avatar_list" field.</summary>
    public const int SceneTeamAvatarListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.SceneTeamAvatar> _repeated_sceneTeamAvatarList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Server.Proto.SceneTeamAvatar.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.SceneTeamAvatar> sceneTeamAvatarList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.SceneTeamAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.SceneTeamAvatar> SceneTeamAvatarList {
      get { return sceneTeamAvatarList_; }
    }

    /// <summary>Field number for the "is_in_mp" field.</summary>
    public const int IsInMpFieldNumber = 15;
    private bool isInMp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInMp {
      get { return isInMp_; }
      set {
        isInMp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneTeamUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneTeamUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sceneTeamAvatarList_.Equals(other.sceneTeamAvatarList_)) return false;
      if (IsInMp != other.IsInMp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sceneTeamAvatarList_.GetHashCode();
      if (IsInMp != false) hash ^= IsInMp.GetHashCode();
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
      sceneTeamAvatarList_.WriteTo(output, _repeated_sceneTeamAvatarList_codec);
      if (IsInMp != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsInMp);
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
      sceneTeamAvatarList_.WriteTo(ref output, _repeated_sceneTeamAvatarList_codec);
      if (IsInMp != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsInMp);
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
      size += sceneTeamAvatarList_.CalculateSize(_repeated_sceneTeamAvatarList_codec);
      if (IsInMp != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneTeamUpdateNotify other) {
      if (other == null) {
        return;
      }
      sceneTeamAvatarList_.Add(other.sceneTeamAvatarList_);
      if (other.IsInMp != false) {
        IsInMp = other.IsInMp;
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
          case 90: {
            sceneTeamAvatarList_.AddEntriesFrom(input, _repeated_sceneTeamAvatarList_codec);
            break;
          }
          case 120: {
            IsInMp = input.ReadBool();
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
          case 90: {
            sceneTeamAvatarList_.AddEntriesFrom(ref input, _repeated_sceneTeamAvatarList_codec);
            break;
          }
          case 120: {
            IsInMp = input.ReadBool();
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
