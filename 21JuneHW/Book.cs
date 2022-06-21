using System;
namespace _21JuneHW
{
	public class Book
	{
		public Book()
		{
			_totalCount++;
			_no = _totalCount;
		}
		private int _no;
		public int No
        {
			get => _no;
        }
		private static int _totalCount = 0;
		public int PageCount;
		public string AuthorName;
		public string Name;
	}
}

