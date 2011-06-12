﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace HandBrake.Interop
{
	[StructLayout(LayoutKind.Sequential)]
	public struct hb_audio_s
	{
		/// int
		public int id;

		/// hb_audio_config_t->hb_audio_config_s
		public hb_audio_config_s config;

		// Padding for the part of the struct we don't care about marshaling.
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = MarshalingConstants.AudioPaddingBytes, ArraySubType = UnmanagedType.U1)]
		public byte[] padding;

		/// Anonymous_e6c7b779_b5a3_4e80_9fa8_13619d14f545
		//public Anonymous_e6c7b779_b5a3_4e80_9fa8_13619d14f545 priv;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct hb_audio_config_s
	{
		public hb_audio_config_output_s output;
		public hb_audio_config_input_s input;

		/// Anonymous_a0a59d69_d9a4_4003_a198_f7c51511e31d
		public Anonymous_a0a59d69_d9a4_4003_a198_f7c51511e31d flags;

		public hb_audio_config_lang_s lang;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct hb_audio_config_output_s
	{
		/// int
		public int track;

		/// uint32_t->unsigned int
		public uint codec;

		/// int
		public int samplerate;

		/// int
		public int bitrate;

		/// int
		public int mixdown;

		/// double
		public double dynamic_range_compression;

		public double gain;

		/// char*
		//[MarshalAs(UnmanagedType.LPStr)]
		//public string name;

		public IntPtr name;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct hb_audio_config_input_s
	{
		/// int
		public int track;

		/// uint32_t->unsigned int
		public uint codec;

		public uint reg_desc;

		public uint stream_type;

		public uint substream_type;

		/// uint32_t->unsigned int
		public uint codec_param;

		/// uint32_t->unsigned int
		public uint version;

		/// uint32_t->unsigned int
		public uint mode;

		/// int
		public int samplerate;

		/// int
		public int bitrate;

		/// int
		public int channel_layout;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct hb_audio_config_lang_s
	{
		/// char[1024]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string description;

		/// char[1024]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string simple;

		/// char[4]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
		public string iso639_2;

		/// uint8_t->unsigned char
		public byte type;
	}
}
