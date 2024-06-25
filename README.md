# Conduit.Opus

> [!NOTE]
> This project was forked from [OpusDotNet](https://github.com/mrphil2105/OpusDotNet), 
and all of the code provided was from [Philip Mørch](https://github.com/mrphil2105). The 
project was forked to update the version of opus to 1.5.2 from 1.3.1.

This release removes all deprecated code.

The original Readme.md follows.

# OpusDotNet
[![OpusDotNet](https://img.shields.io/nuget/v/OpusDotNet.svg?style=flat-square&label=OpusDotNet)](https://www.nuget.org/packages/OpusDotNet)

OpusDotNet is a wrapper around the official `libopus`, and makes it easy to encode and decode audio.
The library is mainly suited for VoIP applications and at the moment only provides `libopus` binaries for Windows (compiled with the Win10 SDK).

## Getting Started
### Installation
Install OpusDotNet via the NuGet Package Manager:
```
Install-Package OpusDotNet
```

### Basic Usage
A simple example of encoding and decoding audio:
```csharp
using (var encoder = new OpusEncoder(Application.Audio, 48000, 2)
{
    Bitrate = 128000, // 128 kbps
    VBR = true // Variable bitrate
})
using (var decoder = new OpusDecoder(48000, 2))
{
    // 40 ms of silence at 48 KHz (2 channels).
    byte[] inputPCMBytes = new byte[40 * 48000 / 1000 * 2 * 2];
    byte[] opusBytes = encoder.Encode(inputPCMBytes, inputPCMBytes.Length, out int encodedLength);
    byte[] outputPCMBytes = decoder.Decode(opusBytes, encodedLength, out int decodedLength);
}
```

## Licenses
 - This project is licensed under the [MIT License](LICENSE.md).
 - **Opus Audio Codec** is licensed under the [BSD License](https://opus-codec.org/license/).
