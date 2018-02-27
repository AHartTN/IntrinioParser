﻿using System.ComponentModel.DataAnnotations.Schema;
using IntrinioParser.Enumerators;
using IntrinioParser.Interfaces.Base;

namespace IntrinioParser.Models.Abstract
{
	public abstract class IntrinioAbstract : BaseAbstract, IIntrinio
	{
		[NotMapped]
		public FileType FileType { get; set; } = FileType.CSV;

		[NotMapped]
		public DataType DataType { get; set; }
	}
}