using System.Collections;

namespace MindCompression.DataObjects;

public class ClubTrainingGround : INameValueList
{
	private ArrayList _list;

	public ArrayList List => _list;

	public ClubTrainingGround()
	{
		_list = new ArrayList();
		_list.Add(new NameValueObject("Top facilities plus youth academy (20)", 20));
		_list.Add(new NameValueObject("Top facilities plus youth academy (19)", 19));
		_list.Add(new NameValueObject("Top facilities plus youth academy (18)", 18));
		_list.Add(new NameValueObject("Top facilities plus youth academy (17)", 17));
		_list.Add(new NameValueObject("Top facilities plus youth academy (16)", 16));
		_list.Add(new NameValueObject("Adequate facilities (15)", 15));
		_list.Add(new NameValueObject("Adequate facilities (14)", 14));
		_list.Add(new NameValueObject("Adequate facilities (13)", 13));
		_list.Add(new NameValueObject("Need some investment (12)", 12));
		_list.Add(new NameValueObject("Need some investment (11)", 11));
		_list.Add(new NameValueObject("Need some investment (10)", 10));
		_list.Add(new NameValueObject("Need major investment (9)", 9));
		_list.Add(new NameValueObject("Need major investment (8)", 8));
		_list.Add(new NameValueObject("Awfull facilities (7)", 7));
		_list.Add(new NameValueObject("Awfull facilities (6)", 6));
		_list.Add(new NameValueObject("Awfull facilities (5)", 5));
		_list.Add(new NameValueObject("Awfull facilities (4)", 4));
		_list.Add(new NameValueObject("Awfull facilities (3)", 3));
		_list.Add(new NameValueObject("Awfull facilities (2)", 2));
		_list.Add(new NameValueObject("Awfull facilities (1)", 1));
		_list.Add(new NameValueObject("Awfull facilities (0)", 0));
	}
}
