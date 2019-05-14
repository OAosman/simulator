// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/map/relative_map/proto/navigator_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.RelativeMap {

  /// <summary>Holder for reflection information generated from modules/map/relative_map/proto/navigator_config.proto</summary>
  public static partial class NavigatorConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/map/relative_map/proto/navigator_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NavigatorConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVtb2R1bGVzL21hcC9yZWxhdGl2ZV9tYXAvcHJvdG8vbmF2aWdhdG9yX2Nv",
            "bmZpZy5wcm90bxITYXBvbGxvLnJlbGF0aXZlX21hcCLfAQoLU2FtcGxlUGFy",
            "YW0SIAoYc3RyYWlnaHRfc2FtcGxlX2ludGVydmFsGAEgASgBEiMKG3NtYWxs",
            "X2thcHBhX3NhbXBsZV9pbnRlcnZhbBgCIAEoARIkChxtaWRkbGVfa2FwcGFf",
            "c2FtcGxlX2ludGVydmFsGAMgASgBEiMKG2xhcmdlX2thcHBhX3NhbXBsZV9p",
            "bnRlcnZhbBgEIAEoARITCgtzbWFsbF9rYXBwYRgFIAEoARIUCgxtaWRkbGVf",
            "a2FwcGEYBiABKAESEwoLbGFyZ2Vfa2FwcGEYByABKAEibgoPTmF2aWdhdG9y",
            "Q29uZmlnEiMKG2VuYWJsZV9uYXZpZ2F0b3JfZG93bnNhbXBsZRgBIAEoCBI2",
            "CgxzYW1wbGVfcGFyYW0YAiABKAsyIC5hcG9sbG8ucmVsYXRpdmVfbWFwLlNh",
            "bXBsZVBhcmFtYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.RelativeMap.SampleParam), global::Apollo.RelativeMap.SampleParam.Parser, new[]{ "StraightSampleInterval", "SmallKappaSampleInterval", "MiddleKappaSampleInterval", "LargeKappaSampleInterval", "SmallKappa", "MiddleKappa", "LargeKappa" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.RelativeMap.NavigatorConfig), global::Apollo.RelativeMap.NavigatorConfig.Parser, new[]{ "EnableNavigatorDownsample", "SampleParam" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SampleParam : pb::IMessage<SampleParam> {
    private static readonly pb::MessageParser<SampleParam> _parser = new pb::MessageParser<SampleParam>(() => new SampleParam());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SampleParam> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.RelativeMap.NavigatorConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SampleParam() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SampleParam(SampleParam other) : this() {
      straightSampleInterval_ = other.straightSampleInterval_;
      smallKappaSampleInterval_ = other.smallKappaSampleInterval_;
      middleKappaSampleInterval_ = other.middleKappaSampleInterval_;
      largeKappaSampleInterval_ = other.largeKappaSampleInterval_;
      smallKappa_ = other.smallKappa_;
      middleKappa_ = other.middleKappa_;
      largeKappa_ = other.largeKappa_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SampleParam Clone() {
      return new SampleParam(this);
    }

    /// <summary>Field number for the "straight_sample_interval" field.</summary>
    public const int StraightSampleIntervalFieldNumber = 1;
    private double straightSampleInterval_;
    /// <summary>
    /// Sampling interval for a straight line.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double StraightSampleInterval {
      get { return straightSampleInterval_; }
      set {
        straightSampleInterval_ = value;
      }
    }

    /// <summary>Field number for the "small_kappa_sample_interval" field.</summary>
    public const int SmallKappaSampleIntervalFieldNumber = 2;
    private double smallKappaSampleInterval_;
    /// <summary>
    /// Sampling interval for a curve segment with a small curvature.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SmallKappaSampleInterval {
      get { return smallKappaSampleInterval_; }
      set {
        smallKappaSampleInterval_ = value;
      }
    }

    /// <summary>Field number for the "middle_kappa_sample_interval" field.</summary>
    public const int MiddleKappaSampleIntervalFieldNumber = 3;
    private double middleKappaSampleInterval_;
    /// <summary>
    /// Sampling interval for a curve segment with a middle curvature.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MiddleKappaSampleInterval {
      get { return middleKappaSampleInterval_; }
      set {
        middleKappaSampleInterval_ = value;
      }
    }

    /// <summary>Field number for the "large_kappa_sample_interval" field.</summary>
    public const int LargeKappaSampleIntervalFieldNumber = 4;
    private double largeKappaSampleInterval_;
    /// <summary>
    /// Sampling interval for a curve segment with a large curvature.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LargeKappaSampleInterval {
      get { return largeKappaSampleInterval_; }
      set {
        largeKappaSampleInterval_ = value;
      }
    }

    /// <summary>Field number for the "small_kappa" field.</summary>
    public const int SmallKappaFieldNumber = 5;
    private double smallKappa_;
    /// <summary>
    /// Small curvature threshold.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double SmallKappa {
      get { return smallKappa_; }
      set {
        smallKappa_ = value;
      }
    }

    /// <summary>Field number for the "middle_kappa" field.</summary>
    public const int MiddleKappaFieldNumber = 6;
    private double middleKappa_;
    /// <summary>
    /// Middle curvature threshold.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MiddleKappa {
      get { return middleKappa_; }
      set {
        middleKappa_ = value;
      }
    }

    /// <summary>Field number for the "large_kappa" field.</summary>
    public const int LargeKappaFieldNumber = 7;
    private double largeKappa_;
    /// <summary>
    /// Large curvature threshold.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double LargeKappa {
      get { return largeKappa_; }
      set {
        largeKappa_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SampleParam);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SampleParam other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StraightSampleInterval != other.StraightSampleInterval) return false;
      if (SmallKappaSampleInterval != other.SmallKappaSampleInterval) return false;
      if (MiddleKappaSampleInterval != other.MiddleKappaSampleInterval) return false;
      if (LargeKappaSampleInterval != other.LargeKappaSampleInterval) return false;
      if (SmallKappa != other.SmallKappa) return false;
      if (MiddleKappa != other.MiddleKappa) return false;
      if (LargeKappa != other.LargeKappa) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StraightSampleInterval != 0D) hash ^= StraightSampleInterval.GetHashCode();
      if (SmallKappaSampleInterval != 0D) hash ^= SmallKappaSampleInterval.GetHashCode();
      if (MiddleKappaSampleInterval != 0D) hash ^= MiddleKappaSampleInterval.GetHashCode();
      if (LargeKappaSampleInterval != 0D) hash ^= LargeKappaSampleInterval.GetHashCode();
      if (SmallKappa != 0D) hash ^= SmallKappa.GetHashCode();
      if (MiddleKappa != 0D) hash ^= MiddleKappa.GetHashCode();
      if (LargeKappa != 0D) hash ^= LargeKappa.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StraightSampleInterval != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(StraightSampleInterval);
      }
      if (SmallKappaSampleInterval != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(SmallKappaSampleInterval);
      }
      if (MiddleKappaSampleInterval != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(MiddleKappaSampleInterval);
      }
      if (LargeKappaSampleInterval != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(LargeKappaSampleInterval);
      }
      if (SmallKappa != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(SmallKappa);
      }
      if (MiddleKappa != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(MiddleKappa);
      }
      if (LargeKappa != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(LargeKappa);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StraightSampleInterval != 0D) {
        size += 1 + 8;
      }
      if (SmallKappaSampleInterval != 0D) {
        size += 1 + 8;
      }
      if (MiddleKappaSampleInterval != 0D) {
        size += 1 + 8;
      }
      if (LargeKappaSampleInterval != 0D) {
        size += 1 + 8;
      }
      if (SmallKappa != 0D) {
        size += 1 + 8;
      }
      if (MiddleKappa != 0D) {
        size += 1 + 8;
      }
      if (LargeKappa != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SampleParam other) {
      if (other == null) {
        return;
      }
      if (other.StraightSampleInterval != 0D) {
        StraightSampleInterval = other.StraightSampleInterval;
      }
      if (other.SmallKappaSampleInterval != 0D) {
        SmallKappaSampleInterval = other.SmallKappaSampleInterval;
      }
      if (other.MiddleKappaSampleInterval != 0D) {
        MiddleKappaSampleInterval = other.MiddleKappaSampleInterval;
      }
      if (other.LargeKappaSampleInterval != 0D) {
        LargeKappaSampleInterval = other.LargeKappaSampleInterval;
      }
      if (other.SmallKappa != 0D) {
        SmallKappa = other.SmallKappa;
      }
      if (other.MiddleKappa != 0D) {
        MiddleKappa = other.MiddleKappa;
      }
      if (other.LargeKappa != 0D) {
        LargeKappa = other.LargeKappa;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 9: {
            StraightSampleInterval = input.ReadDouble();
            break;
          }
          case 17: {
            SmallKappaSampleInterval = input.ReadDouble();
            break;
          }
          case 25: {
            MiddleKappaSampleInterval = input.ReadDouble();
            break;
          }
          case 33: {
            LargeKappaSampleInterval = input.ReadDouble();
            break;
          }
          case 41: {
            SmallKappa = input.ReadDouble();
            break;
          }
          case 49: {
            MiddleKappa = input.ReadDouble();
            break;
          }
          case 57: {
            LargeKappa = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class NavigatorConfig : pb::IMessage<NavigatorConfig> {
    private static readonly pb::MessageParser<NavigatorConfig> _parser = new pb::MessageParser<NavigatorConfig>(() => new NavigatorConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NavigatorConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.RelativeMap.NavigatorConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NavigatorConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NavigatorConfig(NavigatorConfig other) : this() {
      enableNavigatorDownsample_ = other.enableNavigatorDownsample_;
      SampleParam = other.sampleParam_ != null ? other.SampleParam.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NavigatorConfig Clone() {
      return new NavigatorConfig(this);
    }

    /// <summary>Field number for the "enable_navigator_downsample" field.</summary>
    public const int EnableNavigatorDownsampleFieldNumber = 1;
    private bool enableNavigatorDownsample_;
    /// <summary>
    /// When a navigation line is sent, the original data is downsampled to reduce
    /// unnecessary memory consumption.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableNavigatorDownsample {
      get { return enableNavigatorDownsample_; }
      set {
        enableNavigatorDownsample_ = value;
      }
    }

    /// <summary>Field number for the "sample_param" field.</summary>
    public const int SampleParamFieldNumber = 2;
    private global::Apollo.RelativeMap.SampleParam sampleParam_;
    /// <summary>
    /// Smapling paramters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.RelativeMap.SampleParam SampleParam {
      get { return sampleParam_; }
      set {
        sampleParam_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NavigatorConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NavigatorConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnableNavigatorDownsample != other.EnableNavigatorDownsample) return false;
      if (!object.Equals(SampleParam, other.SampleParam)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EnableNavigatorDownsample != false) hash ^= EnableNavigatorDownsample.GetHashCode();
      if (sampleParam_ != null) hash ^= SampleParam.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EnableNavigatorDownsample != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnableNavigatorDownsample);
      }
      if (sampleParam_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SampleParam);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EnableNavigatorDownsample != false) {
        size += 1 + 1;
      }
      if (sampleParam_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SampleParam);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NavigatorConfig other) {
      if (other == null) {
        return;
      }
      if (other.EnableNavigatorDownsample != false) {
        EnableNavigatorDownsample = other.EnableNavigatorDownsample;
      }
      if (other.sampleParam_ != null) {
        if (sampleParam_ == null) {
          sampleParam_ = new global::Apollo.RelativeMap.SampleParam();
        }
        SampleParam.MergeFrom(other.SampleParam);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            EnableNavigatorDownsample = input.ReadBool();
            break;
          }
          case 18: {
            if (sampleParam_ == null) {
              sampleParam_ = new global::Apollo.RelativeMap.SampleParam();
            }
            input.ReadMessage(sampleParam_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code