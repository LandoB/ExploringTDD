using System;

namespace ExploringTDD
{
	public interface IDog
	{
		string Bark ();
		string Whine ();
		string Scratch();

	}

	public class Yorkie : IDog
	{
		public virtual string Bark ()
		{
			return "Yip";
		}

		public virtual string Whine ()
		{
			return "Ugh";
		}

		public virtual string Scratch ()
		{
			return "Itch";
		}
	}
}

