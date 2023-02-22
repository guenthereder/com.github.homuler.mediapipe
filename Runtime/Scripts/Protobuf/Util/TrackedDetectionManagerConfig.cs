// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/util/tracking/tracked_detection_manager_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/util/tracking/tracked_detection_manager_config.proto</summary>
  public static partial class TrackedDetectionManagerConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/util/tracking/tracked_detection_manager_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrackedDetectionManagerConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5tZWRpYXBpcGUvdXRpbC90cmFja2luZy90cmFja2VkX2RldGVjdGlvbl9t",
            "YW5hZ2VyX2NvbmZpZy5wcm90bxIJbWVkaWFwaXBlIn4KHVRyYWNrZWREZXRl",
            "Y3Rpb25NYW5hZ2VyQ29uZmlnEisKIGlzX3NhbWVfZGV0ZWN0aW9uX21heF9h",
            "cmVhX3JhdGlvGAEgASgCOgEzEjAKI2lzX3NhbWVfZGV0ZWN0aW9uX21pbl9v",
            "dmVybGFwX3JhdGlvGAIgASgCOgMwLjU="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.TrackedDetectionManagerConfig), global::Mediapipe.TrackedDetectionManagerConfig.Parser, new[]{ "IsSameDetectionMaxAreaRatio", "IsSameDetectionMinOverlapRatio" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TrackedDetectionManagerConfig : pb::IMessage<TrackedDetectionManagerConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrackedDetectionManagerConfig> _parser = new pb::MessageParser<TrackedDetectionManagerConfig>(() => new TrackedDetectionManagerConfig());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrackedDetectionManagerConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.TrackedDetectionManagerConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrackedDetectionManagerConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrackedDetectionManagerConfig(TrackedDetectionManagerConfig other) : this() {
      _hasBits0 = other._hasBits0;
      isSameDetectionMaxAreaRatio_ = other.isSameDetectionMaxAreaRatio_;
      isSameDetectionMinOverlapRatio_ = other.isSameDetectionMinOverlapRatio_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrackedDetectionManagerConfig Clone() {
      return new TrackedDetectionManagerConfig(this);
    }

    /// <summary>Field number for the "is_same_detection_max_area_ratio" field.</summary>
    public const int IsSameDetectionMaxAreaRatioFieldNumber = 1;
    private readonly static float IsSameDetectionMaxAreaRatioDefaultValue = 3F;

    private float isSameDetectionMaxAreaRatio_;
    /// <summary>
    /// When we compare two detection boxes, if the ratio of the area is
    /// larger than is_same_detection_max_area_ratio, we consider them being
    /// different detections.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float IsSameDetectionMaxAreaRatio {
      get { if ((_hasBits0 & 1) != 0) { return isSameDetectionMaxAreaRatio_; } else { return IsSameDetectionMaxAreaRatioDefaultValue; } }
      set {
        _hasBits0 |= 1;
        isSameDetectionMaxAreaRatio_ = value;
      }
    }
    /// <summary>Gets whether the "is_same_detection_max_area_ratio" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasIsSameDetectionMaxAreaRatio {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "is_same_detection_max_area_ratio" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearIsSameDetectionMaxAreaRatio() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "is_same_detection_min_overlap_ratio" field.</summary>
    public const int IsSameDetectionMinOverlapRatioFieldNumber = 2;
    private readonly static float IsSameDetectionMinOverlapRatioDefaultValue = 0.5F;

    private float isSameDetectionMinOverlapRatio_;
    /// <summary>
    /// When we compare two detection boxes, if the overlap ratio is larger
    /// than is_same_detection_min_overlap_ratio, we consider them being
    /// same detection.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float IsSameDetectionMinOverlapRatio {
      get { if ((_hasBits0 & 2) != 0) { return isSameDetectionMinOverlapRatio_; } else { return IsSameDetectionMinOverlapRatioDefaultValue; } }
      set {
        _hasBits0 |= 2;
        isSameDetectionMinOverlapRatio_ = value;
      }
    }
    /// <summary>Gets whether the "is_same_detection_min_overlap_ratio" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasIsSameDetectionMinOverlapRatio {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "is_same_detection_min_overlap_ratio" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearIsSameDetectionMinOverlapRatio() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrackedDetectionManagerConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrackedDetectionManagerConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(IsSameDetectionMaxAreaRatio, other.IsSameDetectionMaxAreaRatio)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(IsSameDetectionMinOverlapRatio, other.IsSameDetectionMinOverlapRatio)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasIsSameDetectionMaxAreaRatio) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(IsSameDetectionMaxAreaRatio);
      if (HasIsSameDetectionMinOverlapRatio) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(IsSameDetectionMinOverlapRatio);
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
      if (HasIsSameDetectionMaxAreaRatio) {
        output.WriteRawTag(13);
        output.WriteFloat(IsSameDetectionMaxAreaRatio);
      }
      if (HasIsSameDetectionMinOverlapRatio) {
        output.WriteRawTag(21);
        output.WriteFloat(IsSameDetectionMinOverlapRatio);
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
      if (HasIsSameDetectionMaxAreaRatio) {
        output.WriteRawTag(13);
        output.WriteFloat(IsSameDetectionMaxAreaRatio);
      }
      if (HasIsSameDetectionMinOverlapRatio) {
        output.WriteRawTag(21);
        output.WriteFloat(IsSameDetectionMinOverlapRatio);
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
      if (HasIsSameDetectionMaxAreaRatio) {
        size += 1 + 4;
      }
      if (HasIsSameDetectionMinOverlapRatio) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrackedDetectionManagerConfig other) {
      if (other == null) {
        return;
      }
      if (other.HasIsSameDetectionMaxAreaRatio) {
        IsSameDetectionMaxAreaRatio = other.IsSameDetectionMaxAreaRatio;
      }
      if (other.HasIsSameDetectionMinOverlapRatio) {
        IsSameDetectionMinOverlapRatio = other.IsSameDetectionMinOverlapRatio;
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
            IsSameDetectionMaxAreaRatio = input.ReadFloat();
            break;
          }
          case 21: {
            IsSameDetectionMinOverlapRatio = input.ReadFloat();
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
            IsSameDetectionMaxAreaRatio = input.ReadFloat();
            break;
          }
          case 21: {
            IsSameDetectionMinOverlapRatio = input.ReadFloat();
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
