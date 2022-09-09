using System.Collections;

namespace MindCompression.DataObjects;

public class ClubStatus : INameValueList
{
	private ArrayList _list;

	public ArrayList List => _list;

	public ClubStatus()
	{
		_list = new ArrayList();
		_list.Add(new NameValueObject("Professional", 1));
		_list.Add(new NameValueObject("Semi-professional", 2));
		_list.Add(new NameValueObject("Amateur", 3));
	}
}
