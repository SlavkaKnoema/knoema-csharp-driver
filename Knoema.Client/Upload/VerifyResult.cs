﻿using System.Collections.Generic;

namespace Knoema.Upload
{
	public class VerifyResult
	{
		public bool Successful { get; set; }
		public string FilePath { get; set; }
		public List<string> ErrorList { get; set; }
		public object UploadFormatType { get; set; }
		public List<object> Columns { get; set; }
		public DatasetUploadDetails MetadataDetails { get; set; }
		public FlatDatasetUpdateOptions FlatDSUpdateOptions { get; set; }
		public RegularDatasetUpdateOptions? RegularDSUpdateOptions { get; set; }
		public DatasetUploadReport AdvanceReport { get; set; }
	}
}
