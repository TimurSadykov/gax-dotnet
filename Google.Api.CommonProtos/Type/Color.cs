/*
 * Copyright 2016 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/type/color.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  /// <summary>Holder for reflection information generated from google/type/color.proto</summary>
  public static partial class ColorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/type/color.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ColorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chdnb29nbGUvdHlwZS9jb2xvci5wcm90bxILZ29vZ2xlLnR5cGUaHmdvb2ds",
            "ZS9wcm90b2J1Zi93cmFwcGVycy5wcm90byJdCgVDb2xvchILCgNyZWQYASAB",
            "KAISDQoFZ3JlZW4YAiABKAISDAoEYmx1ZRgDIAEoAhIqCgVhbHBoYRgEIAEo",
            "CzIbLmdvb2dsZS5wcm90b2J1Zi5GbG9hdFZhbHVlQl0KD2NvbS5nb29nbGUu",
            "dHlwZUIKQ29sb3JQcm90b1ABWjZnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL3R5cGUvY29sb3I7Y29sb3KiAgNHVFBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Type.Color), global::Google.Type.Color.Parser, new[]{ "Red", "Green", "Blue", "Alpha" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a color in the RGBA color space. This representation is designed
  /// for simplicity of conversion to/from color representations in various
  /// languages over compactness; for example, the fields of this representation
  /// can be trivially provided to the constructor of "java.awt.Color" in Java; it
  /// can also be trivially provided to UIColor's "+colorWithRed:green:blue:alpha"
  /// method in iOS; and, with just a little work, it can be easily formatted into
  /// a CSS "rgba()" string in JavaScript, as well. Here are some examples:
  ///
  /// Example (Java):
  ///
  ///      import com.google.type.Color;
  ///
  ///      // ...
  ///      public static java.awt.Color fromProto(Color protocolor) {
  ///        float alpha = protocolor.hasAlpha()
  ///            ? protocolor.getAlpha().getValue()
  ///            : 1.0;
  ///
  ///        return new java.awt.Color(
  ///            protocolor.getRed(),
  ///            protocolor.getGreen(),
  ///            protocolor.getBlue(),
  ///            alpha);
  ///      }
  ///
  ///      public static Color toProto(java.awt.Color color) {
  ///        float red = (float) color.getRed();
  ///        float green = (float) color.getGreen();
  ///        float blue = (float) color.getBlue();
  ///        float denominator = 255.0;
  ///        Color.Builder resultBuilder =
  ///            Color
  ///                .newBuilder()
  ///                .setRed(red / denominator)
  ///                .setGreen(green / denominator)
  ///                .setBlue(blue / denominator);
  ///        int alpha = color.getAlpha();
  ///        if (alpha != 255) {
  ///          result.setAlpha(
  ///              FloatValue
  ///                  .newBuilder()
  ///                  .setValue(((float) alpha) / denominator)
  ///                  .build());
  ///        }
  ///        return resultBuilder.build();
  ///      }
  ///      // ...
  ///
  /// Example (iOS / Obj-C):
  ///
  ///      // ...
  ///      static UIColor* fromProto(Color* protocolor) {
  ///         float red = [protocolor red];
  ///         float green = [protocolor green];
  ///         float blue = [protocolor blue];
  ///         FloatValue* alpha_wrapper = [protocolor alpha];
  ///         float alpha = 1.0;
  ///         if (alpha_wrapper != nil) {
  ///           alpha = [alpha_wrapper value];
  ///         }
  ///         return [UIColor colorWithRed:red green:green blue:blue alpha:alpha];
  ///      }
  ///
  ///      static Color* toProto(UIColor* color) {
  ///          CGFloat red, green, blue, alpha;
  ///          if (![color getRed:&amp;red green:&amp;green blue:&amp;blue alpha:&amp;alpha]) {
  ///            return nil;
  ///          }
  ///          Color* result = [Color alloc] init];
  ///          [result setRed:red];
  ///          [result setGreen:green];
  ///          [result setBlue:blue];
  ///          if (alpha &lt;= 0.9999) {
  ///            [result setAlpha:floatWrapperWithValue(alpha)];
  ///          }
  ///          [result autorelease];
  ///          return result;
  ///     }
  ///     // ...
  ///
  ///  Example (JavaScript):
  ///
  ///     // ...
  ///
  ///     var protoToCssColor = function(rgb_color) {
  ///        var redFrac = rgb_color.red || 0.0;
  ///        var greenFrac = rgb_color.green || 0.0;
  ///        var blueFrac = rgb_color.blue || 0.0;
  ///        var red = Math.floor(redFrac * 255);
  ///        var green = Math.floor(greenFrac * 255);
  ///        var blue = Math.floor(blueFrac * 255);
  ///
  ///        if (!('alpha' in rgb_color)) {
  ///           return rgbToCssColor_(red, green, blue);
  ///        }
  ///
  ///        var alphaFrac = rgb_color.alpha.value || 0.0;
  ///        var rgbParams = [red, green, blue].join(',');
  ///        return ['rgba(', rgbParams, ',', alphaFrac, ')'].join('');
  ///     };
  ///
  ///     var rgbToCssColor_ = function(red, green, blue) {
  ///       var rgbNumber = new Number((red &lt;&lt; 16) | (green &lt;&lt; 8) | blue);
  ///       var hexString = rgbNumber.toString(16);
  ///       var missingZeros = 6 - hexString.length;
  ///       var resultBuilder = ['#'];
  ///       for (var i = 0; i &lt; missingZeros; i++) {
  ///          resultBuilder.push('0');
  ///       }
  ///       resultBuilder.push(hexString);
  ///       return resultBuilder.join('');
  ///     };
  ///
  ///     // ...
  /// </summary>
  public sealed partial class Color : pb::IMessage<Color> {
    private static readonly pb::MessageParser<Color> _parser = new pb::MessageParser<Color>(() => new Color());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Color> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Type.ColorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Color() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Color(Color other) : this() {
      red_ = other.red_;
      green_ = other.green_;
      blue_ = other.blue_;
      Alpha = other.Alpha;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Color Clone() {
      return new Color(this);
    }

    /// <summary>Field number for the "red" field.</summary>
    public const int RedFieldNumber = 1;
    private float red_;
    /// <summary>
    /// The amount of red in the color as a value in the interval [0, 1].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Red {
      get { return red_; }
      set {
        red_ = value;
      }
    }

    /// <summary>Field number for the "green" field.</summary>
    public const int GreenFieldNumber = 2;
    private float green_;
    /// <summary>
    /// The amount of green in the color as a value in the interval [0, 1].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Green {
      get { return green_; }
      set {
        green_ = value;
      }
    }

    /// <summary>Field number for the "blue" field.</summary>
    public const int BlueFieldNumber = 3;
    private float blue_;
    /// <summary>
    /// The amount of blue in the color as a value in the interval [0, 1].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Blue {
      get { return blue_; }
      set {
        blue_ = value;
      }
    }

    /// <summary>Field number for the "alpha" field.</summary>
    public const int AlphaFieldNumber = 4;
    private static readonly pb::FieldCodec<float?> _single_alpha_codec = pb::FieldCodec.ForStructWrapper<float>(34);
    private float? alpha_;
    /// <summary>
    /// The fraction of this color that should be applied to the pixel. That is,
    /// the final pixel color is defined by the equation:
    ///
    ///   pixel color = alpha * (this color) + (1.0 - alpha) * (background color)
    ///
    /// This means that a value of 1.0 corresponds to a solid color, whereas
    /// a value of 0.0 corresponds to a completely transparent color. This
    /// uses a wrapper message rather than a simple float scalar so that it is
    /// possible to distinguish between a default value and the value being unset.
    /// If omitted, this color object is to be rendered as a solid color
    /// (as if the alpha value had been explicitly given with a value of 1.0).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float? Alpha {
      get { return alpha_; }
      set {
        alpha_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Color);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Color other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Red, other.Red)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Green, other.Green)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Blue, other.Blue)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.Equals(Alpha, other.Alpha)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Red != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Red);
      if (Green != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Green);
      if (Blue != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Blue);
      if (alpha_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparer.GetHashCode(Alpha);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Red != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Red);
      }
      if (Green != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Green);
      }
      if (Blue != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Blue);
      }
      if (alpha_ != null) {
        _single_alpha_codec.WriteTagAndValue(output, Alpha);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Red != 0F) {
        size += 1 + 4;
      }
      if (Green != 0F) {
        size += 1 + 4;
      }
      if (Blue != 0F) {
        size += 1 + 4;
      }
      if (alpha_ != null) {
        size += _single_alpha_codec.CalculateSizeWithTag(Alpha);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Color other) {
      if (other == null) {
        return;
      }
      if (other.Red != 0F) {
        Red = other.Red;
      }
      if (other.Green != 0F) {
        Green = other.Green;
      }
      if (other.Blue != 0F) {
        Blue = other.Blue;
      }
      if (other.alpha_ != null) {
        if (alpha_ == null || other.Alpha != 0F) {
          Alpha = other.Alpha;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            Red = input.ReadFloat();
            break;
          }
          case 21: {
            Green = input.ReadFloat();
            break;
          }
          case 29: {
            Blue = input.ReadFloat();
            break;
          }
          case 34: {
            float? value = _single_alpha_codec.Read(input);
            if (alpha_ == null || value != 0F) {
              Alpha = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code