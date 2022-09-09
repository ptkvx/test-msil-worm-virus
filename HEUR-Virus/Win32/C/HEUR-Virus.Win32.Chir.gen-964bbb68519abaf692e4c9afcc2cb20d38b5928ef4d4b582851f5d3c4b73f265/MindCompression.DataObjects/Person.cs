using System;
using System.Collections;

namespace MindCompression.DataObjects;

public abstract class Person : FmObject, IPerson
{
	[ExtendedCategory("Name", 1)]
	[PropertyInfo("First name", "The person's first name.", 1)]
	public abstract string FirstName { get; }

	[PropertyInfo("Last name", "The person's last name.", 3)]
	[ExtendedCategory("Name", 1)]
	public abstract string LastName { get; }

	[ExtendedCategory("Name", 1)]
	[PropertyInfo("Nickname", "The person's Nickname.", 2)]
	public abstract string Nickname { get; }

	[ExtendedCategory("General", 2)]
	[PropertyInfo("Date of birth", "The person's date of birth.", 1)]
	public abstract DateTime DateOfBirth { get; set; }

	[PropertyInfo("International caps", "The number of international appearances he has made.", 2)]
	[ExtendedCategory("General", 2)]
	public abstract byte InternationalCaps { get; set; }

	[PropertyInfo("International goals", "The number of international goals he has scored.", 3)]
	[ExtendedCategory("General", 2)]
	public abstract byte InternationalGoals { get; set; }

	[PropertyInfo("U21 international caps", "The number of U21 appearances he has made.", 4)]
	[ExtendedCategory("General", 2)]
	public abstract byte U21InternationalCaps { get; set; }

	[ExtendedCategory("General", 2)]
	[PropertyInfo("U21 international goals", "The number of U21 goals he has scored.", 5)]
	public abstract byte U21InternationalGoals { get; set; }

	[PropertyInfo("Nationality", "The person's nationality.", 6)]
	[ExtendedCategory("General", 2)]
	public abstract int Nationality { get; set; }

	[ExtendedCategory("General", 2)]
	[PropertyInfo("City of birth", "The person's city of birth.", 7)]
	public abstract int CityOfBirth { get; set; }

	public Person(FmObject obj)
		: base(obj.Address, obj.Name, obj.Type, obj.ProcMemory, obj.Id)
	{
	}

	public static FmObject GetPersonByAddress(int address)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.AddRange(FmObjectLists.Instance.GetList(FmObjectType.Player));
		arrayList.AddRange(FmObjectLists.Instance.GetList(FmObjectType.PlayerCoach));
		arrayList.AddRange(FmObjectLists.Instance.GetList(FmObjectType.Coach));
		foreach (FmObject item in arrayList)
		{
			if (item.Address == address)
			{
				return item;
			}
		}
		return null;
	}
}
