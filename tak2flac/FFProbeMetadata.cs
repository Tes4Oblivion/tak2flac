using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tak2flac
{
	public class Streams
	{
		public int index { get; set; } = 0;
		public string codec_name { get; set; } = string.Empty;
		public string codec_long_name { get; set; } = string.Empty;
		public string codec_type { get; set; } = string.Empty;
		public ulong duration_ts { get; set; } = 0;
		public double duration { get; set; } = 0;
		public int start_pts { get; set; } = 0;
		public double start_time { get; set; } = 0;
	}
	public class Format
	{
		public string filename { get; set; } = string.Empty;
		public string format_name { get; set; } = string.Empty;
		public double start_time { get; set; } = 0;
		public double duration { get; set; } = 0;
		public ulong size { get; set; } = 0;
		public long bit_rate { get; set; } = 0;
		public Tags tags { get; set; }
	}
	public class Tags
	{
		public string Album { get; set; } = string.Empty;
		public string Artist { get; set; } = string.Empty;
		public string comment { get; set; } = string.Empty;
		public string Year { get; set; } = string.Empty;
		public string Discid { get; set; } = string.Empty;
		public string Genre { get; set; } = string.Empty;
		public string Cuesheet { get; set; } = string.Empty;
	}
	public class Metadata
	{
		public List<Streams> streams { get; set; }
		public Format format { get; set; }
	}
}
