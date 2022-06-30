using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable;

internal class S65
{
	public static int Invoke5(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[1] switch
		{
			'2' => Invoke52XXXX(code, p, args), 
			'6' => Invoke56XXXX(code, p, args), 
			'3' => Invoke53XXXX(code, p, args), 
			'5' => Invoke55XXXX(code, p, args), 
			'7' => Invoke57XXXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke52XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke522XXX(code, p, args), 
			'6' => Invoke526XXX(code, p, args), 
			'3' => Invoke523XXX(code, p, args), 
			'5' => Invoke525XXX(code, p, args), 
			'7' => Invoke527XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke522XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5222XX(code, p, args), 
			'6' => Invoke5226XX(code, p, args), 
			'3' => Invoke5223XX(code, p, args), 
			'5' => Invoke5225XX(code, p, args), 
			'7' => Invoke5227XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5222XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52222X(code, p, args), 
			'6' => Invoke52226X(code, p, args), 
			'3' => Invoke52223X(code, p, args), 
			'5' => Invoke52225X(code, p, args), 
			'7' => Invoke52227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5226XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52262X(code, p, args), 
			'6' => Invoke52266X(code, p, args), 
			'3' => Invoke52263X(code, p, args), 
			'5' => Invoke52265X(code, p, args), 
			'7' => Invoke52267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5223XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52232X(code, p, args), 
			'6' => Invoke52236X(code, p, args), 
			'3' => Invoke52233X(code, p, args), 
			'5' => Invoke52235X(code, p, args), 
			'7' => Invoke52237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5225XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52252X(code, p, args), 
			'6' => Invoke52256X(code, p, args), 
			'3' => Invoke52253X(code, p, args), 
			'5' => Invoke52255X(code, p, args), 
			'7' => Invoke52257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5227XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52272X(code, p, args), 
			'6' => Invoke52276X(code, p, args), 
			'3' => Invoke52273X(code, p, args), 
			'5' => Invoke52275X(code, p, args), 
			'7' => Invoke52277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke526XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5262XX(code, p, args), 
			'6' => Invoke5266XX(code, p, args), 
			'3' => Invoke5263XX(code, p, args), 
			'5' => Invoke5265XX(code, p, args), 
			'7' => Invoke5267XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5262XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52622X(code, p, args), 
			'6' => Invoke52626X(code, p, args), 
			'3' => Invoke52623X(code, p, args), 
			'5' => Invoke52625X(code, p, args), 
			'7' => Invoke52627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5266XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52662X(code, p, args), 
			'6' => Invoke52666X(code, p, args), 
			'3' => Invoke52663X(code, p, args), 
			'5' => Invoke52665X(code, p, args), 
			'7' => Invoke52667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5263XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52632X(code, p, args), 
			'6' => Invoke52636X(code, p, args), 
			'3' => Invoke52633X(code, p, args), 
			'5' => Invoke52635X(code, p, args), 
			'7' => Invoke52637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5265XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52652X(code, p, args), 
			'6' => Invoke52656X(code, p, args), 
			'3' => Invoke52653X(code, p, args), 
			'5' => Invoke52655X(code, p, args), 
			'7' => Invoke52657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5267XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52672X(code, p, args), 
			'6' => Invoke52676X(code, p, args), 
			'3' => Invoke52673X(code, p, args), 
			'5' => Invoke52675X(code, p, args), 
			'7' => Invoke52677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke523XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5232XX(code, p, args), 
			'6' => Invoke5236XX(code, p, args), 
			'3' => Invoke5233XX(code, p, args), 
			'5' => Invoke5235XX(code, p, args), 
			'7' => Invoke5237XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5232XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52322X(code, p, args), 
			'6' => Invoke52326X(code, p, args), 
			'3' => Invoke52323X(code, p, args), 
			'5' => Invoke52325X(code, p, args), 
			'7' => Invoke52327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5236XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52362X(code, p, args), 
			'6' => Invoke52366X(code, p, args), 
			'3' => Invoke52363X(code, p, args), 
			'5' => Invoke52365X(code, p, args), 
			'7' => Invoke52367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5233XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52332X(code, p, args), 
			'6' => Invoke52336X(code, p, args), 
			'3' => Invoke52333X(code, p, args), 
			'5' => Invoke52335X(code, p, args), 
			'7' => Invoke52337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5235XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52352X(code, p, args), 
			'6' => Invoke52356X(code, p, args), 
			'3' => Invoke52353X(code, p, args), 
			'5' => Invoke52355X(code, p, args), 
			'7' => Invoke52357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5237XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52372X(code, p, args), 
			'6' => Invoke52376X(code, p, args), 
			'3' => Invoke52373X(code, p, args), 
			'5' => Invoke52375X(code, p, args), 
			'7' => Invoke52377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke525XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5252XX(code, p, args), 
			'6' => Invoke5256XX(code, p, args), 
			'3' => Invoke5253XX(code, p, args), 
			'5' => Invoke5255XX(code, p, args), 
			'7' => Invoke5257XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5252XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52522X(code, p, args), 
			'6' => Invoke52526X(code, p, args), 
			'3' => Invoke52523X(code, p, args), 
			'5' => Invoke52525X(code, p, args), 
			'7' => Invoke52527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5256XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52562X(code, p, args), 
			'6' => Invoke52566X(code, p, args), 
			'3' => Invoke52563X(code, p, args), 
			'5' => Invoke52565X(code, p, args), 
			'7' => Invoke52567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5253XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52532X(code, p, args), 
			'6' => Invoke52536X(code, p, args), 
			'3' => Invoke52533X(code, p, args), 
			'5' => Invoke52535X(code, p, args), 
			'7' => Invoke52537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5255XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52552X(code, p, args), 
			'6' => Invoke52556X(code, p, args), 
			'3' => Invoke52553X(code, p, args), 
			'5' => Invoke52555X(code, p, args), 
			'7' => Invoke52557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5257XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52572X(code, p, args), 
			'6' => Invoke52576X(code, p, args), 
			'3' => Invoke52573X(code, p, args), 
			'5' => Invoke52575X(code, p, args), 
			'7' => Invoke52577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke527XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5272XX(code, p, args), 
			'6' => Invoke5276XX(code, p, args), 
			'3' => Invoke5273XX(code, p, args), 
			'5' => Invoke5275XX(code, p, args), 
			'7' => Invoke5277XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5272XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52722X(code, p, args), 
			'6' => Invoke52726X(code, p, args), 
			'3' => Invoke52723X(code, p, args), 
			'5' => Invoke52725X(code, p, args), 
			'7' => Invoke52727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5276XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52762X(code, p, args), 
			'6' => Invoke52766X(code, p, args), 
			'3' => Invoke52763X(code, p, args), 
			'5' => Invoke52765X(code, p, args), 
			'7' => Invoke52767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5273XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52732X(code, p, args), 
			'6' => Invoke52736X(code, p, args), 
			'3' => Invoke52733X(code, p, args), 
			'5' => Invoke52735X(code, p, args), 
			'7' => Invoke52737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5275XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52752X(code, p, args), 
			'6' => Invoke52756X(code, p, args), 
			'3' => Invoke52753X(code, p, args), 
			'5' => Invoke52755X(code, p, args), 
			'7' => Invoke52757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5277XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke52772X(code, p, args), 
			'6' => Invoke52776X(code, p, args), 
			'3' => Invoke52773X(code, p, args), 
			'5' => Invoke52775X(code, p, args), 
			'7' => Invoke52777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke56XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke562XXX(code, p, args), 
			'6' => Invoke566XXX(code, p, args), 
			'3' => Invoke563XXX(code, p, args), 
			'5' => Invoke565XXX(code, p, args), 
			'7' => Invoke567XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke562XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5622XX(code, p, args), 
			'6' => Invoke5626XX(code, p, args), 
			'3' => Invoke5623XX(code, p, args), 
			'5' => Invoke5625XX(code, p, args), 
			'7' => Invoke5627XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5622XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56222X(code, p, args), 
			'6' => Invoke56226X(code, p, args), 
			'3' => Invoke56223X(code, p, args), 
			'5' => Invoke56225X(code, p, args), 
			'7' => Invoke56227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5626XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56262X(code, p, args), 
			'6' => Invoke56266X(code, p, args), 
			'3' => Invoke56263X(code, p, args), 
			'5' => Invoke56265X(code, p, args), 
			'7' => Invoke56267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5623XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56232X(code, p, args), 
			'6' => Invoke56236X(code, p, args), 
			'3' => Invoke56233X(code, p, args), 
			'5' => Invoke56235X(code, p, args), 
			'7' => Invoke56237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5625XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56252X(code, p, args), 
			'6' => Invoke56256X(code, p, args), 
			'3' => Invoke56253X(code, p, args), 
			'5' => Invoke56255X(code, p, args), 
			'7' => Invoke56257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5627XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56272X(code, p, args), 
			'6' => Invoke56276X(code, p, args), 
			'3' => Invoke56273X(code, p, args), 
			'5' => Invoke56275X(code, p, args), 
			'7' => Invoke56277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke566XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5662XX(code, p, args), 
			'6' => Invoke5666XX(code, p, args), 
			'3' => Invoke5663XX(code, p, args), 
			'5' => Invoke5665XX(code, p, args), 
			'7' => Invoke5667XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5662XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56622X(code, p, args), 
			'6' => Invoke56626X(code, p, args), 
			'3' => Invoke56623X(code, p, args), 
			'5' => Invoke56625X(code, p, args), 
			'7' => Invoke56627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5666XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56662X(code, p, args), 
			'6' => Invoke56666X(code, p, args), 
			'3' => Invoke56663X(code, p, args), 
			'5' => Invoke56665X(code, p, args), 
			'7' => Invoke56667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5663XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56632X(code, p, args), 
			'6' => Invoke56636X(code, p, args), 
			'3' => Invoke56633X(code, p, args), 
			'5' => Invoke56635X(code, p, args), 
			'7' => Invoke56637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5665XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56652X(code, p, args), 
			'6' => Invoke56656X(code, p, args), 
			'3' => Invoke56653X(code, p, args), 
			'5' => Invoke56655X(code, p, args), 
			'7' => Invoke56657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5667XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56672X(code, p, args), 
			'6' => Invoke56676X(code, p, args), 
			'3' => Invoke56673X(code, p, args), 
			'5' => Invoke56675X(code, p, args), 
			'7' => Invoke56677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke563XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5632XX(code, p, args), 
			'6' => Invoke5636XX(code, p, args), 
			'3' => Invoke5633XX(code, p, args), 
			'5' => Invoke5635XX(code, p, args), 
			'7' => Invoke5637XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5632XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56322X(code, p, args), 
			'6' => Invoke56326X(code, p, args), 
			'3' => Invoke56323X(code, p, args), 
			'5' => Invoke56325X(code, p, args), 
			'7' => Invoke56327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5636XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56362X(code, p, args), 
			'6' => Invoke56366X(code, p, args), 
			'3' => Invoke56363X(code, p, args), 
			'5' => Invoke56365X(code, p, args), 
			'7' => Invoke56367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5633XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56332X(code, p, args), 
			'6' => Invoke56336X(code, p, args), 
			'3' => Invoke56333X(code, p, args), 
			'5' => Invoke56335X(code, p, args), 
			'7' => Invoke56337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5635XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56352X(code, p, args), 
			'6' => Invoke56356X(code, p, args), 
			'3' => Invoke56353X(code, p, args), 
			'5' => Invoke56355X(code, p, args), 
			'7' => Invoke56357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5637XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56372X(code, p, args), 
			'6' => Invoke56376X(code, p, args), 
			'3' => Invoke56373X(code, p, args), 
			'5' => Invoke56375X(code, p, args), 
			'7' => Invoke56377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke565XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5652XX(code, p, args), 
			'6' => Invoke5656XX(code, p, args), 
			'3' => Invoke5653XX(code, p, args), 
			'5' => Invoke5655XX(code, p, args), 
			'7' => Invoke5657XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5652XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56522X(code, p, args), 
			'6' => Invoke56526X(code, p, args), 
			'3' => Invoke56523X(code, p, args), 
			'5' => Invoke56525X(code, p, args), 
			'7' => Invoke56527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5656XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56562X(code, p, args), 
			'6' => Invoke56566X(code, p, args), 
			'3' => Invoke56563X(code, p, args), 
			'5' => Invoke56565X(code, p, args), 
			'7' => Invoke56567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5653XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56532X(code, p, args), 
			'6' => Invoke56536X(code, p, args), 
			'3' => Invoke56533X(code, p, args), 
			'5' => Invoke56535X(code, p, args), 
			'7' => Invoke56537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5655XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56552X(code, p, args), 
			'6' => Invoke56556X(code, p, args), 
			'3' => Invoke56553X(code, p, args), 
			'5' => Invoke56555X(code, p, args), 
			'7' => Invoke56557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5657XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56572X(code, p, args), 
			'6' => Invoke56576X(code, p, args), 
			'3' => Invoke56573X(code, p, args), 
			'5' => Invoke56575X(code, p, args), 
			'7' => Invoke56577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke567XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5672XX(code, p, args), 
			'6' => Invoke5676XX(code, p, args), 
			'3' => Invoke5673XX(code, p, args), 
			'5' => Invoke5675XX(code, p, args), 
			'7' => Invoke5677XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5672XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56722X(code, p, args), 
			'6' => Invoke56726X(code, p, args), 
			'3' => Invoke56723X(code, p, args), 
			'5' => Invoke56725X(code, p, args), 
			'7' => Invoke56727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5676XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56762X(code, p, args), 
			'6' => Invoke56766X(code, p, args), 
			'3' => Invoke56763X(code, p, args), 
			'5' => Invoke56765X(code, p, args), 
			'7' => Invoke56767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5673XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56732X(code, p, args), 
			'6' => Invoke56736X(code, p, args), 
			'3' => Invoke56733X(code, p, args), 
			'5' => Invoke56735X(code, p, args), 
			'7' => Invoke56737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5675XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56752X(code, p, args), 
			'6' => Invoke56756X(code, p, args), 
			'3' => Invoke56753X(code, p, args), 
			'5' => Invoke56755X(code, p, args), 
			'7' => Invoke56757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5677XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke56772X(code, p, args), 
			'6' => Invoke56776X(code, p, args), 
			'3' => Invoke56773X(code, p, args), 
			'5' => Invoke56775X(code, p, args), 
			'7' => Invoke56777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke53XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke532XXX(code, p, args), 
			'6' => Invoke536XXX(code, p, args), 
			'3' => Invoke533XXX(code, p, args), 
			'5' => Invoke535XXX(code, p, args), 
			'7' => Invoke537XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke532XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5322XX(code, p, args), 
			'6' => Invoke5326XX(code, p, args), 
			'3' => Invoke5323XX(code, p, args), 
			'5' => Invoke5325XX(code, p, args), 
			'7' => Invoke5327XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5322XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53222X(code, p, args), 
			'6' => Invoke53226X(code, p, args), 
			'3' => Invoke53223X(code, p, args), 
			'5' => Invoke53225X(code, p, args), 
			'7' => Invoke53227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5326XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53262X(code, p, args), 
			'6' => Invoke53266X(code, p, args), 
			'3' => Invoke53263X(code, p, args), 
			'5' => Invoke53265X(code, p, args), 
			'7' => Invoke53267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5323XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53232X(code, p, args), 
			'6' => Invoke53236X(code, p, args), 
			'3' => Invoke53233X(code, p, args), 
			'5' => Invoke53235X(code, p, args), 
			'7' => Invoke53237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5325XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53252X(code, p, args), 
			'6' => Invoke53256X(code, p, args), 
			'3' => Invoke53253X(code, p, args), 
			'5' => Invoke53255X(code, p, args), 
			'7' => Invoke53257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5327XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53272X(code, p, args), 
			'6' => Invoke53276X(code, p, args), 
			'3' => Invoke53273X(code, p, args), 
			'5' => Invoke53275X(code, p, args), 
			'7' => Invoke53277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke536XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5362XX(code, p, args), 
			'6' => Invoke5366XX(code, p, args), 
			'3' => Invoke5363XX(code, p, args), 
			'5' => Invoke5365XX(code, p, args), 
			'7' => Invoke5367XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5362XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53622X(code, p, args), 
			'6' => Invoke53626X(code, p, args), 
			'3' => Invoke53623X(code, p, args), 
			'5' => Invoke53625X(code, p, args), 
			'7' => Invoke53627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5366XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53662X(code, p, args), 
			'6' => Invoke53666X(code, p, args), 
			'3' => Invoke53663X(code, p, args), 
			'5' => Invoke53665X(code, p, args), 
			'7' => Invoke53667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5363XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53632X(code, p, args), 
			'6' => Invoke53636X(code, p, args), 
			'3' => Invoke53633X(code, p, args), 
			'5' => Invoke53635X(code, p, args), 
			'7' => Invoke53637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5365XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53652X(code, p, args), 
			'6' => Invoke53656X(code, p, args), 
			'3' => Invoke53653X(code, p, args), 
			'5' => Invoke53655X(code, p, args), 
			'7' => Invoke53657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5367XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53672X(code, p, args), 
			'6' => Invoke53676X(code, p, args), 
			'3' => Invoke53673X(code, p, args), 
			'5' => Invoke53675X(code, p, args), 
			'7' => Invoke53677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke533XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5332XX(code, p, args), 
			'6' => Invoke5336XX(code, p, args), 
			'3' => Invoke5333XX(code, p, args), 
			'5' => Invoke5335XX(code, p, args), 
			'7' => Invoke5337XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5332XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53322X(code, p, args), 
			'6' => Invoke53326X(code, p, args), 
			'3' => Invoke53323X(code, p, args), 
			'5' => Invoke53325X(code, p, args), 
			'7' => Invoke53327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5336XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53362X(code, p, args), 
			'6' => Invoke53366X(code, p, args), 
			'3' => Invoke53363X(code, p, args), 
			'5' => Invoke53365X(code, p, args), 
			'7' => Invoke53367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5333XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53332X(code, p, args), 
			'6' => Invoke53336X(code, p, args), 
			'3' => Invoke53333X(code, p, args), 
			'5' => Invoke53335X(code, p, args), 
			'7' => Invoke53337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5335XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53352X(code, p, args), 
			'6' => Invoke53356X(code, p, args), 
			'3' => Invoke53353X(code, p, args), 
			'5' => Invoke53355X(code, p, args), 
			'7' => Invoke53357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5337XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53372X(code, p, args), 
			'6' => Invoke53376X(code, p, args), 
			'3' => Invoke53373X(code, p, args), 
			'5' => Invoke53375X(code, p, args), 
			'7' => Invoke53377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke535XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5352XX(code, p, args), 
			'6' => Invoke5356XX(code, p, args), 
			'3' => Invoke5353XX(code, p, args), 
			'5' => Invoke5355XX(code, p, args), 
			'7' => Invoke5357XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5352XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53522X(code, p, args), 
			'6' => Invoke53526X(code, p, args), 
			'3' => Invoke53523X(code, p, args), 
			'5' => Invoke53525X(code, p, args), 
			'7' => Invoke53527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5356XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53562X(code, p, args), 
			'6' => Invoke53566X(code, p, args), 
			'3' => Invoke53563X(code, p, args), 
			'5' => Invoke53565X(code, p, args), 
			'7' => Invoke53567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5353XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53532X(code, p, args), 
			'6' => Invoke53536X(code, p, args), 
			'3' => Invoke53533X(code, p, args), 
			'5' => Invoke53535X(code, p, args), 
			'7' => Invoke53537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5355XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53552X(code, p, args), 
			'6' => Invoke53556X(code, p, args), 
			'3' => Invoke53553X(code, p, args), 
			'5' => Invoke53555X(code, p, args), 
			'7' => Invoke53557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5357XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53572X(code, p, args), 
			'6' => Invoke53576X(code, p, args), 
			'3' => Invoke53573X(code, p, args), 
			'5' => Invoke53575X(code, p, args), 
			'7' => Invoke53577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke537XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5372XX(code, p, args), 
			'6' => Invoke5376XX(code, p, args), 
			'3' => Invoke5373XX(code, p, args), 
			'5' => Invoke5375XX(code, p, args), 
			'7' => Invoke5377XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5372XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53722X(code, p, args), 
			'6' => Invoke53726X(code, p, args), 
			'3' => Invoke53723X(code, p, args), 
			'5' => Invoke53725X(code, p, args), 
			'7' => Invoke53727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5376XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53762X(code, p, args), 
			'6' => Invoke53766X(code, p, args), 
			'3' => Invoke53763X(code, p, args), 
			'5' => Invoke53765X(code, p, args), 
			'7' => Invoke53767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5373XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53732X(code, p, args), 
			'6' => Invoke53736X(code, p, args), 
			'3' => Invoke53733X(code, p, args), 
			'5' => Invoke53735X(code, p, args), 
			'7' => Invoke53737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5375XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53752X(code, p, args), 
			'6' => Invoke53756X(code, p, args), 
			'3' => Invoke53753X(code, p, args), 
			'5' => Invoke53755X(code, p, args), 
			'7' => Invoke53757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5377XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke53772X(code, p, args), 
			'6' => Invoke53776X(code, p, args), 
			'3' => Invoke53773X(code, p, args), 
			'5' => Invoke53775X(code, p, args), 
			'7' => Invoke53777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke55XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke552XXX(code, p, args), 
			'6' => Invoke556XXX(code, p, args), 
			'3' => Invoke553XXX(code, p, args), 
			'5' => Invoke555XXX(code, p, args), 
			'7' => Invoke557XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke552XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5522XX(code, p, args), 
			'6' => Invoke5526XX(code, p, args), 
			'3' => Invoke5523XX(code, p, args), 
			'5' => Invoke5525XX(code, p, args), 
			'7' => Invoke5527XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5522XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55222X(code, p, args), 
			'6' => Invoke55226X(code, p, args), 
			'3' => Invoke55223X(code, p, args), 
			'5' => Invoke55225X(code, p, args), 
			'7' => Invoke55227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5526XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55262X(code, p, args), 
			'6' => Invoke55266X(code, p, args), 
			'3' => Invoke55263X(code, p, args), 
			'5' => Invoke55265X(code, p, args), 
			'7' => Invoke55267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5523XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55232X(code, p, args), 
			'6' => Invoke55236X(code, p, args), 
			'3' => Invoke55233X(code, p, args), 
			'5' => Invoke55235X(code, p, args), 
			'7' => Invoke55237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5525XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55252X(code, p, args), 
			'6' => Invoke55256X(code, p, args), 
			'3' => Invoke55253X(code, p, args), 
			'5' => Invoke55255X(code, p, args), 
			'7' => Invoke55257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5527XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55272X(code, p, args), 
			'6' => Invoke55276X(code, p, args), 
			'3' => Invoke55273X(code, p, args), 
			'5' => Invoke55275X(code, p, args), 
			'7' => Invoke55277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke556XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5562XX(code, p, args), 
			'6' => Invoke5566XX(code, p, args), 
			'3' => Invoke5563XX(code, p, args), 
			'5' => Invoke5565XX(code, p, args), 
			'7' => Invoke5567XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5562XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55622X(code, p, args), 
			'6' => Invoke55626X(code, p, args), 
			'3' => Invoke55623X(code, p, args), 
			'5' => Invoke55625X(code, p, args), 
			'7' => Invoke55627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5566XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55662X(code, p, args), 
			'6' => Invoke55666X(code, p, args), 
			'3' => Invoke55663X(code, p, args), 
			'5' => Invoke55665X(code, p, args), 
			'7' => Invoke55667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5563XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55632X(code, p, args), 
			'6' => Invoke55636X(code, p, args), 
			'3' => Invoke55633X(code, p, args), 
			'5' => Invoke55635X(code, p, args), 
			'7' => Invoke55637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5565XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55652X(code, p, args), 
			'6' => Invoke55656X(code, p, args), 
			'3' => Invoke55653X(code, p, args), 
			'5' => Invoke55655X(code, p, args), 
			'7' => Invoke55657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5567XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55672X(code, p, args), 
			'6' => Invoke55676X(code, p, args), 
			'3' => Invoke55673X(code, p, args), 
			'5' => Invoke55675X(code, p, args), 
			'7' => Invoke55677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke553XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5532XX(code, p, args), 
			'6' => Invoke5536XX(code, p, args), 
			'3' => Invoke5533XX(code, p, args), 
			'5' => Invoke5535XX(code, p, args), 
			'7' => Invoke5537XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5532XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55322X(code, p, args), 
			'6' => Invoke55326X(code, p, args), 
			'3' => Invoke55323X(code, p, args), 
			'5' => Invoke55325X(code, p, args), 
			'7' => Invoke55327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5536XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55362X(code, p, args), 
			'6' => Invoke55366X(code, p, args), 
			'3' => Invoke55363X(code, p, args), 
			'5' => Invoke55365X(code, p, args), 
			'7' => Invoke55367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5533XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55332X(code, p, args), 
			'6' => Invoke55336X(code, p, args), 
			'3' => Invoke55333X(code, p, args), 
			'5' => Invoke55335X(code, p, args), 
			'7' => Invoke55337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5535XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55352X(code, p, args), 
			'6' => Invoke55356X(code, p, args), 
			'3' => Invoke55353X(code, p, args), 
			'5' => Invoke55355X(code, p, args), 
			'7' => Invoke55357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5537XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55372X(code, p, args), 
			'6' => Invoke55376X(code, p, args), 
			'3' => Invoke55373X(code, p, args), 
			'5' => Invoke55375X(code, p, args), 
			'7' => Invoke55377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke555XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5552XX(code, p, args), 
			'6' => Invoke5556XX(code, p, args), 
			'3' => Invoke5553XX(code, p, args), 
			'5' => Invoke5555XX(code, p, args), 
			'7' => Invoke5557XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5552XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55522X(code, p, args), 
			'6' => Invoke55526X(code, p, args), 
			'3' => Invoke55523X(code, p, args), 
			'5' => Invoke55525X(code, p, args), 
			'7' => Invoke55527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5556XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55562X(code, p, args), 
			'6' => Invoke55566X(code, p, args), 
			'3' => Invoke55563X(code, p, args), 
			'5' => Invoke55565X(code, p, args), 
			'7' => Invoke55567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5553XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55532X(code, p, args), 
			'6' => Invoke55536X(code, p, args), 
			'3' => Invoke55533X(code, p, args), 
			'5' => Invoke55535X(code, p, args), 
			'7' => Invoke55537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5555XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55552X(code, p, args), 
			'6' => Invoke55556X(code, p, args), 
			'3' => Invoke55553X(code, p, args), 
			'5' => Invoke55555X(code, p, args), 
			'7' => Invoke55557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5557XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55572X(code, p, args), 
			'6' => Invoke55576X(code, p, args), 
			'3' => Invoke55573X(code, p, args), 
			'5' => Invoke55575X(code, p, args), 
			'7' => Invoke55577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke557XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5572XX(code, p, args), 
			'6' => Invoke5576XX(code, p, args), 
			'3' => Invoke5573XX(code, p, args), 
			'5' => Invoke5575XX(code, p, args), 
			'7' => Invoke5577XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5572XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55722X(code, p, args), 
			'6' => Invoke55726X(code, p, args), 
			'3' => Invoke55723X(code, p, args), 
			'5' => Invoke55725X(code, p, args), 
			'7' => Invoke55727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5576XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55762X(code, p, args), 
			'6' => Invoke55766X(code, p, args), 
			'3' => Invoke55763X(code, p, args), 
			'5' => Invoke55765X(code, p, args), 
			'7' => Invoke55767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5573XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55732X(code, p, args), 
			'6' => Invoke55736X(code, p, args), 
			'3' => Invoke55733X(code, p, args), 
			'5' => Invoke55735X(code, p, args), 
			'7' => Invoke55737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5575XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55752X(code, p, args), 
			'6' => Invoke55756X(code, p, args), 
			'3' => Invoke55753X(code, p, args), 
			'5' => Invoke55755X(code, p, args), 
			'7' => Invoke55757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5577XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke55772X(code, p, args), 
			'6' => Invoke55776X(code, p, args), 
			'3' => Invoke55773X(code, p, args), 
			'5' => Invoke55775X(code, p, args), 
			'7' => Invoke55777X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke57XXXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[2] switch
		{
			'2' => Invoke572XXX(code, p, args), 
			'6' => Invoke576XXX(code, p, args), 
			'3' => Invoke573XXX(code, p, args), 
			'5' => Invoke575XXX(code, p, args), 
			'7' => Invoke577XXX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke572XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5722XX(code, p, args), 
			'6' => Invoke5726XX(code, p, args), 
			'3' => Invoke5723XX(code, p, args), 
			'5' => Invoke5725XX(code, p, args), 
			'7' => Invoke5727XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5722XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57222X(code, p, args), 
			'6' => Invoke57226X(code, p, args), 
			'3' => Invoke57223X(code, p, args), 
			'5' => Invoke57225X(code, p, args), 
			'7' => Invoke57227X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5726XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57262X(code, p, args), 
			'6' => Invoke57266X(code, p, args), 
			'3' => Invoke57263X(code, p, args), 
			'5' => Invoke57265X(code, p, args), 
			'7' => Invoke57267X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5723XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57232X(code, p, args), 
			'6' => Invoke57236X(code, p, args), 
			'3' => Invoke57233X(code, p, args), 
			'5' => Invoke57235X(code, p, args), 
			'7' => Invoke57237X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5725XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57252X(code, p, args), 
			'6' => Invoke57256X(code, p, args), 
			'3' => Invoke57253X(code, p, args), 
			'5' => Invoke57255X(code, p, args), 
			'7' => Invoke57257X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5727XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57272X(code, p, args), 
			'6' => Invoke57276X(code, p, args), 
			'3' => Invoke57273X(code, p, args), 
			'5' => Invoke57275X(code, p, args), 
			'7' => Invoke57277X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke576XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5762XX(code, p, args), 
			'6' => Invoke5766XX(code, p, args), 
			'3' => Invoke5763XX(code, p, args), 
			'5' => Invoke5765XX(code, p, args), 
			'7' => Invoke5767XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5762XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57622X(code, p, args), 
			'6' => Invoke57626X(code, p, args), 
			'3' => Invoke57623X(code, p, args), 
			'5' => Invoke57625X(code, p, args), 
			'7' => Invoke57627X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5766XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57662X(code, p, args), 
			'6' => Invoke57666X(code, p, args), 
			'3' => Invoke57663X(code, p, args), 
			'5' => Invoke57665X(code, p, args), 
			'7' => Invoke57667X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5763XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57632X(code, p, args), 
			'6' => Invoke57636X(code, p, args), 
			'3' => Invoke57633X(code, p, args), 
			'5' => Invoke57635X(code, p, args), 
			'7' => Invoke57637X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5765XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57652X(code, p, args), 
			'6' => Invoke57656X(code, p, args), 
			'3' => Invoke57653X(code, p, args), 
			'5' => Invoke57655X(code, p, args), 
			'7' => Invoke57657X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5767XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57672X(code, p, args), 
			'6' => Invoke57676X(code, p, args), 
			'3' => Invoke57673X(code, p, args), 
			'5' => Invoke57675X(code, p, args), 
			'7' => Invoke57677X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke573XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5732XX(code, p, args), 
			'6' => Invoke5736XX(code, p, args), 
			'3' => Invoke5733XX(code, p, args), 
			'5' => Invoke5735XX(code, p, args), 
			'7' => Invoke5737XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5732XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57322X(code, p, args), 
			'6' => Invoke57326X(code, p, args), 
			'3' => Invoke57323X(code, p, args), 
			'5' => Invoke57325X(code, p, args), 
			'7' => Invoke57327X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5736XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57362X(code, p, args), 
			'6' => Invoke57366X(code, p, args), 
			'3' => Invoke57363X(code, p, args), 
			'5' => Invoke57365X(code, p, args), 
			'7' => Invoke57367X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5733XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57332X(code, p, args), 
			'6' => Invoke57336X(code, p, args), 
			'3' => Invoke57333X(code, p, args), 
			'5' => Invoke57335X(code, p, args), 
			'7' => Invoke57337X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5735XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57352X(code, p, args), 
			'6' => Invoke57356X(code, p, args), 
			'3' => Invoke57353X(code, p, args), 
			'5' => Invoke57355X(code, p, args), 
			'7' => Invoke57357X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5737XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57372X(code, p, args), 
			'6' => Invoke57376X(code, p, args), 
			'3' => Invoke57373X(code, p, args), 
			'5' => Invoke57375X(code, p, args), 
			'7' => Invoke57377X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke575XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5752XX(code, p, args), 
			'6' => Invoke5756XX(code, p, args), 
			'3' => Invoke5753XX(code, p, args), 
			'5' => Invoke5755XX(code, p, args), 
			'7' => Invoke5757XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5752XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57522X(code, p, args), 
			'6' => Invoke57526X(code, p, args), 
			'3' => Invoke57523X(code, p, args), 
			'5' => Invoke57525X(code, p, args), 
			'7' => Invoke57527X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5756XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57562X(code, p, args), 
			'6' => Invoke57566X(code, p, args), 
			'3' => Invoke57563X(code, p, args), 
			'5' => Invoke57565X(code, p, args), 
			'7' => Invoke57567X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5753XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57532X(code, p, args), 
			'6' => Invoke57536X(code, p, args), 
			'3' => Invoke57533X(code, p, args), 
			'5' => Invoke57535X(code, p, args), 
			'7' => Invoke57537X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5755XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57552X(code, p, args), 
			'6' => Invoke57556X(code, p, args), 
			'3' => Invoke57553X(code, p, args), 
			'5' => Invoke57555X(code, p, args), 
			'7' => Invoke57557X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5757XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57572X(code, p, args), 
			'6' => Invoke57576X(code, p, args), 
			'3' => Invoke57573X(code, p, args), 
			'5' => Invoke57575X(code, p, args), 
			'7' => Invoke57577X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke577XXX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[3] switch
		{
			'2' => Invoke5772XX(code, p, args), 
			'6' => Invoke5776XX(code, p, args), 
			'3' => Invoke5773XX(code, p, args), 
			'5' => Invoke5775XX(code, p, args), 
			'7' => Invoke5777XX(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5772XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57722X(code, p, args), 
			'6' => Invoke57726X(code, p, args), 
			'3' => Invoke57723X(code, p, args), 
			'5' => Invoke57725X(code, p, args), 
			'7' => Invoke57727X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5776XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57762X(code, p, args), 
			'6' => Invoke57766X(code, p, args), 
			'3' => Invoke57763X(code, p, args), 
			'5' => Invoke57765X(code, p, args), 
			'7' => Invoke57767X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5773XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57732X(code, p, args), 
			'6' => Invoke57736X(code, p, args), 
			'3' => Invoke57733X(code, p, args), 
			'5' => Invoke57735X(code, p, args), 
			'7' => Invoke57737X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5775XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57752X(code, p, args), 
			'6' => Invoke57756X(code, p, args), 
			'3' => Invoke57753X(code, p, args), 
			'5' => Invoke57755X(code, p, args), 
			'7' => Invoke57757X(code, p, args), 
			_ => -1, 
		};
	}

	private static int Invoke5777XX(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[4] switch
		{
			'2' => Invoke57772X(code, p, args), 
			'6' => Invoke57776X(code, p, args), 
			'3' => Invoke57773X(code, p, args), 
			'5' => Invoke57775X(code, p, args), 
			'7' => Invoke57777X(code, p, args), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, int, int, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, int, int, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, int, int, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, int, int, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, int, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, int, float, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, int, float, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, int, float, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, int, float, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, int, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, int, long, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, int, long, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, int, long, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, int, long, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, int, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, int, double, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, int, double, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, int, double, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, int, double, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, int, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, int, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, int, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, int, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, int, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, float, int, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, float, int, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, float, int, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, float, int, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, float, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, float, float, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, float, float, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, float, float, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, float, float, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, float, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, float, long, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, float, long, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, float, long, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, float, long, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, float, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, float, double, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, float, double, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, float, double, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, float, double, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, float, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, float, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, float, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, float, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, float, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, long, int, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, long, int, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, long, int, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, long, int, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, long, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, long, float, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, long, float, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, long, float, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, long, float, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, long, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, long, long, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, long, long, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, long, long, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, long, long, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, long, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, long, double, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, long, double, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, long, double, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, long, double, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, long, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, long, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, long, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, long, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, long, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, double, int, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, double, int, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, double, int, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, double, int, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, double, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, double, float, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, double, float, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, double, float, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, double, float, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, double, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, double, long, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, double, long, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, double, long, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, double, long, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, double, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, double, double, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, double, double, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, double, double, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, double, double, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, double, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, double, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, double, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, double, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, double, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, int, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, int, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, int, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, int, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, float, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, float, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, float, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, float, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, long, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, long, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, long, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, long, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, double, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, double, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, double, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, double, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, int, int, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, int, int, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, int, int, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, int, int, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, int, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, int, float, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, int, float, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, int, float, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, int, float, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, int, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, int, long, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, int, long, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, int, long, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, int, long, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, int, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, int, double, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, int, double, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, int, double, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, int, double, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, int, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, int, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, int, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, int, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, int, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, float, int, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, float, int, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, float, int, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, float, int, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, float, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, float, float, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, float, float, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, float, float, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, float, float, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, float, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, float, long, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, float, long, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, float, long, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, float, long, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, float, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, float, double, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, float, double, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, float, double, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, float, double, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, float, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, float, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, float, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, float, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, float, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, long, int, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, long, int, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, long, int, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, long, int, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, long, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, long, float, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, long, float, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, long, float, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, long, float, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, long, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, long, long, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, long, long, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, long, long, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, long, long, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, long, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, long, double, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, long, double, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, long, double, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, long, double, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, long, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, long, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, long, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, long, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, long, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, double, int, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, double, int, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, double, int, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, double, int, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, double, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, double, float, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, double, float, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, double, float, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, double, float, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, double, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, double, long, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, double, long, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, double, long, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, double, long, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, double, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, double, double, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, double, double, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, double, double, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, double, double, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, double, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, double, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, double, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, double, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, double, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, int, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, int, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, int, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, int, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, float, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, float, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, float, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, float, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, long, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, long, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, long, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, long, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, double, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, double, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, double, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, double, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, int, int, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, int, int, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, int, int, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, int, int, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, int, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, int, float, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, int, float, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, int, float, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, int, float, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, int, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, int, long, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, int, long, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, int, long, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, int, long, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, int, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, int, double, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, int, double, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, int, double, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, int, double, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, int, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, int, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, int, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, int, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, int, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, float, int, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, float, int, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, float, int, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, float, int, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, float, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, float, float, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, float, float, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, float, float, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, float, float, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, float, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, float, long, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, float, long, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, float, long, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, float, long, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, float, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, float, double, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, float, double, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, float, double, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, float, double, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, float, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, float, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, float, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, float, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, float, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, long, int, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, long, int, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, long, int, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, long, int, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, long, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, long, float, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, long, float, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, long, float, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, long, float, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, long, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, long, long, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, long, long, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, long, long, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, long, long, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, long, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, long, double, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, long, double, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, long, double, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, long, double, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, long, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, long, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, long, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, long, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, long, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, double, int, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, double, int, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, double, int, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, double, int, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, double, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, double, float, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, double, float, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, double, float, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, double, float, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, double, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, double, long, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, double, long, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, double, long, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, double, long, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, double, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, double, double, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, double, double, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, double, double, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, double, double, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, double, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, double, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, double, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, double, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, double, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, int, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, int, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, int, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, int, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, float, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, float, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, float, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, float, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, long, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, long, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, long, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, long, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, double, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, double, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, double, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, double, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, int, int, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, int, int, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, int, int, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, int, int, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, int, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, int, float, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, int, float, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, int, float, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, int, float, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, int, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, int, long, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, int, long, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, int, long, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, int, long, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, int, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, int, double, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, int, double, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, int, double, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, int, double, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, int, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, int, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, int, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, int, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, int, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, float, int, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, float, int, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, float, int, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, float, int, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, float, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, float, float, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, float, float, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, float, float, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, float, float, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, float, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, float, long, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, float, long, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, float, long, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, float, long, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, float, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, float, double, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, float, double, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, float, double, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, float, double, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, float, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, float, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, float, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, float, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, float, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, long, int, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, long, int, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, long, int, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, long, int, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, long, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, long, float, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, long, float, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, long, float, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, long, float, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, long, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, long, long, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, long, long, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, long, long, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, long, long, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, long, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, long, double, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, long, double, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, long, double, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, long, double, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, long, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, long, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, long, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, long, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, long, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, double, int, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, double, int, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, double, int, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, double, int, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, double, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, double, float, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, double, float, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, double, float, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, double, float, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, double, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, double, long, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, double, long, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, double, long, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, double, long, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, double, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, double, double, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, double, double, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, double, double, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, double, double, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, double, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, double, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, double, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, double, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, double, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, int, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, int, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, int, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, int, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, float, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, float, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, float, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, float, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, long, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, long, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, long, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, long, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, double, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, double, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, double, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, double, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, int, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, int, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, int, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, int, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, float, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, float, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, float, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, float, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, long, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, long, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, long, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, long, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, double, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, double, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, double, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, double, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, int, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, int, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, int, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, int, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, float, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, float, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, float, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, float, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, long, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, long, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, long, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, long, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, double, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, double, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, double, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, double, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, int, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, int, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, int, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, int, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, float, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, float, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, float, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, float, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, long, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, long, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, long, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, long, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, double, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, double, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, double, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, double, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, int, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, int, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, int, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, int, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, float, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, float, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, float, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, float, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, long, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, long, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, long, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, long, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, double, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, double, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, double, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, double, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, int, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, int, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, int, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, int, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, float, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, float, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, float, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, float, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, long, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, long, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, long, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, long, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, double, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, double, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, double, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, double, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke52777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, int, int, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, int, int, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, int, int, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, int, int, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, int, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, int, float, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, int, float, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, int, float, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, int, float, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, int, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, int, long, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, int, long, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, int, long, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, int, long, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, int, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, int, double, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, int, double, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, int, double, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, int, double, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, int, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, int, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, int, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, int, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, int, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, float, int, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, float, int, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, float, int, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, float, int, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, float, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, float, float, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, float, float, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, float, float, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, float, float, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, float, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, float, long, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, float, long, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, float, long, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, float, long, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, float, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, float, double, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, float, double, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, float, double, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, float, double, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, float, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, float, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, float, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, float, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, float, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, long, int, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, long, int, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, long, int, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, long, int, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, long, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, long, float, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, long, float, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, long, float, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, long, float, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, long, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, long, long, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, long, long, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, long, long, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, long, long, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, long, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, long, double, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, long, double, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, long, double, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, long, double, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, long, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, long, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, long, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, long, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, long, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, double, int, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, double, int, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, double, int, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, double, int, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, double, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, double, float, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, double, float, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, double, float, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, double, float, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, double, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, double, long, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, double, long, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, double, long, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, double, long, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, double, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, double, double, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, double, double, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, double, double, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, double, double, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, double, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, double, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, double, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, double, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, double, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, int, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, int, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, int, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, int, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, float, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, float, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, float, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, float, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, long, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, long, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, long, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, long, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, double, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, double, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, double, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, double, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, int, int, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, int, int, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, int, int, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, int, int, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, int, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, int, float, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, int, float, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, int, float, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, int, float, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, int, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, int, long, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, int, long, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, int, long, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, int, long, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, int, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, int, double, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, int, double, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, int, double, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, int, double, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, int, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, int, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, int, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, int, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, int, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, float, int, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, float, int, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, float, int, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, float, int, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, float, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, float, float, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, float, float, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, float, float, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, float, float, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, float, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, float, long, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, float, long, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, float, long, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, float, long, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, float, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, float, double, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, float, double, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, float, double, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, float, double, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, float, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, float, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, float, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, float, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, float, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, long, int, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, long, int, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, long, int, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, long, int, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, long, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, long, float, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, long, float, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, long, float, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, long, float, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, long, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, long, long, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, long, long, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, long, long, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, long, long, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, long, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, long, double, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, long, double, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, long, double, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, long, double, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, long, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, long, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, long, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, long, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, long, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, double, int, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, double, int, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, double, int, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, double, int, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, double, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, double, float, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, double, float, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, double, float, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, double, float, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, double, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, double, long, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, double, long, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, double, long, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, double, long, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, double, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, double, double, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, double, double, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, double, double, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, double, double, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, double, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, double, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, double, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, double, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, double, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, int, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, int, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, int, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, int, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, float, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, float, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, float, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, float, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, long, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, long, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, long, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, long, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, double, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, double, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, double, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, double, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, int, int, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, int, int, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, int, int, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, int, int, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, int, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, int, float, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, int, float, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, int, float, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, int, float, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, int, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, int, long, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, int, long, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, int, long, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, int, long, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, int, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, int, double, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, int, double, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, int, double, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, int, double, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, int, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, int, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, int, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, int, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, int, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, float, int, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, float, int, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, float, int, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, float, int, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, float, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, float, float, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, float, float, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, float, float, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, float, float, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, float, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, float, long, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, float, long, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, float, long, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, float, long, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, float, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, float, double, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, float, double, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, float, double, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, float, double, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, float, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, float, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, float, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, float, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, float, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, long, int, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, long, int, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, long, int, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, long, int, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, long, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, long, float, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, long, float, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, long, float, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, long, float, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, long, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, long, long, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, long, long, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, long, long, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, long, long, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, long, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, long, double, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, long, double, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, long, double, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, long, double, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, long, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, long, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, long, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, long, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, long, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, double, int, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, double, int, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, double, int, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, double, int, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, double, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, double, float, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, double, float, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, double, float, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, double, float, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, double, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, double, long, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, double, long, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, double, long, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, double, long, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, double, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, double, double, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, double, double, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, double, double, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, double, double, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, double, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, double, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, double, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, double, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, double, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, int, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, int, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, int, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, int, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, float, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, float, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, float, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, float, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, long, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, long, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, long, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, long, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, double, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, double, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, double, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, double, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, int, int, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, int, int, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, int, int, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, int, int, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, int, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, int, float, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, int, float, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, int, float, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, int, float, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, int, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, int, long, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, int, long, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, int, long, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, int, long, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, int, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, int, double, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, int, double, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, int, double, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, int, double, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, int, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, int, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, int, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, int, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, int, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, float, int, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, float, int, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, float, int, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, float, int, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, float, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, float, float, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, float, float, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, float, float, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, float, float, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, float, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, float, long, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, float, long, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, float, long, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, float, long, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, float, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, float, double, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, float, double, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, float, double, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, float, double, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, float, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, float, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, float, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, float, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, float, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, long, int, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, long, int, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, long, int, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, long, int, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, long, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, long, float, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, long, float, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, long, float, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, long, float, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, long, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, long, long, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, long, long, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, long, long, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, long, long, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, long, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, long, double, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, long, double, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, long, double, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, long, double, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, long, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, long, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, long, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, long, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, long, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, double, int, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, double, int, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, double, int, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, double, int, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, double, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, double, float, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, double, float, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, double, float, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, double, float, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, double, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, double, long, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, double, long, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, double, long, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, double, long, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, double, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, double, double, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, double, double, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, double, double, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, double, double, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, double, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, double, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, double, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, double, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, double, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, int, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, int, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, int, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, int, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, float, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, float, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, float, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, float, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, long, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, long, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, long, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, long, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, double, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, double, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, double, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, double, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, int, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, int, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, int, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, int, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, float, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, float, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, float, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, float, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, long, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, long, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, long, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, long, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, double, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, double, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, double, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, double, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, int, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, int, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, int, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, int, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, float, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, float, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, float, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, float, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, long, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, long, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, long, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, long, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, double, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, double, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, double, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, double, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, int, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, int, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, int, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, int, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, float, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, float, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, float, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, float, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, long, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, long, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, long, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, long, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, double, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, double, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, double, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, double, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, int, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, int, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, int, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, int, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, float, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, float, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, float, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, float, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, long, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, long, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, long, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, long, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, double, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, double, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, double, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, double, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, int, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, int, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, int, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, int, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, float, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, float, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, float, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, float, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, long, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, long, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, long, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, long, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, double, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, double, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, double, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, double, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke56777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, int, int, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, int, int, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, int, int, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, int, int, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, int, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, int, float, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, int, float, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, int, float, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, int, float, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, int, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, int, long, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, int, long, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, int, long, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, int, long, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, int, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, int, double, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, int, double, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, int, double, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, int, double, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, int, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, int, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, int, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, int, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, int, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, float, int, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, float, int, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, float, int, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, float, int, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, float, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, float, float, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, float, float, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, float, float, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, float, float, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, float, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, float, long, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, float, long, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, float, long, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, float, long, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, float, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, float, double, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, float, double, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, float, double, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, float, double, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, float, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, float, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, float, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, float, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, float, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, long, int, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, long, int, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, long, int, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, long, int, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, long, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, long, float, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, long, float, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, long, float, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, long, float, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, long, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, long, long, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, long, long, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, long, long, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, long, long, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, long, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, long, double, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, long, double, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, long, double, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, long, double, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, long, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, long, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, long, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, long, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, long, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, double, int, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, double, int, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, double, int, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, double, int, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, double, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, double, float, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, double, float, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, double, float, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, double, float, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, double, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, double, long, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, double, long, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, double, long, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, double, long, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, double, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, double, double, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, double, double, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, double, double, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, double, double, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, double, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, double, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, double, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, double, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, double, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, int, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, int, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, int, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, int, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, float, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, float, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, float, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, float, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, long, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, long, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, long, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, long, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, double, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, double, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, double, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, double, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, int, int, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, int, int, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, int, int, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, int, int, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, int, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, int, float, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, int, float, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, int, float, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, int, float, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, int, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, int, long, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, int, long, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, int, long, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, int, long, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, int, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, int, double, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, int, double, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, int, double, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, int, double, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, int, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, int, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, int, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, int, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, int, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, float, int, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, float, int, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, float, int, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, float, int, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, float, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, float, float, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, float, float, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, float, float, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, float, float, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, float, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, float, long, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, float, long, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, float, long, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, float, long, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, float, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, float, double, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, float, double, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, float, double, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, float, double, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, float, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, float, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, float, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, float, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, float, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, long, int, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, long, int, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, long, int, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, long, int, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, long, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, long, float, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, long, float, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, long, float, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, long, float, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, long, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, long, long, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, long, long, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, long, long, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, long, long, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, long, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, long, double, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, long, double, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, long, double, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, long, double, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, long, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, long, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, long, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, long, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, long, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, double, int, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, double, int, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, double, int, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, double, int, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, double, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, double, float, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, double, float, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, double, float, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, double, float, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, double, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, double, long, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, double, long, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, double, long, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, double, long, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, double, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, double, double, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, double, double, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, double, double, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, double, double, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, double, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, double, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, double, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, double, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, double, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, int, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, int, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, int, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, int, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, float, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, float, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, float, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, float, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, long, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, long, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, long, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, long, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, double, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, double, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, double, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, double, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, int, int, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, int, int, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, int, int, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, int, int, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, int, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, int, float, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, int, float, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, int, float, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, int, float, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, int, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, int, long, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, int, long, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, int, long, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, int, long, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, int, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, int, double, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, int, double, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, int, double, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, int, double, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, int, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, int, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, int, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, int, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, int, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, float, int, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, float, int, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, float, int, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, float, int, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, float, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, float, float, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, float, float, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, float, float, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, float, float, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, float, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, float, long, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, float, long, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, float, long, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, float, long, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, float, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, float, double, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, float, double, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, float, double, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, float, double, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, float, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, float, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, float, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, float, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, float, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, long, int, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, long, int, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, long, int, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, long, int, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, long, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, long, float, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, long, float, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, long, float, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, long, float, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, long, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, long, long, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, long, long, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, long, long, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, long, long, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, long, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, long, double, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, long, double, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, long, double, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, long, double, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, long, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, long, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, long, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, long, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, long, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, double, int, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, double, int, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, double, int, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, double, int, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, double, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, double, float, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, double, float, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, double, float, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, double, float, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, double, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, double, long, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, double, long, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, double, long, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, double, long, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, double, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, double, double, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, double, double, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, double, double, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, double, double, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, double, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, double, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, double, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, double, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, double, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, int, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, int, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, int, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, int, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, float, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, float, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, float, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, float, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, long, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, long, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, long, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, long, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, double, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, double, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, double, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, double, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, int, int, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, int, int, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, int, int, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, int, int, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, int, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, int, float, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, int, float, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, int, float, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, int, float, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, int, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, int, long, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, int, long, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, int, long, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, int, long, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, int, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, int, double, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, int, double, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, int, double, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, int, double, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, int, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, int, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, int, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, int, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, int, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, float, int, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, float, int, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, float, int, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, float, int, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, float, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, float, float, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, float, float, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, float, float, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, float, float, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, float, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, float, long, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, float, long, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, float, long, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, float, long, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, float, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, float, double, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, float, double, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, float, double, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, float, double, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, float, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, float, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, float, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, float, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, float, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, long, int, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, long, int, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, long, int, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, long, int, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, long, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, long, float, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, long, float, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, long, float, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, long, float, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, long, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, long, long, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, long, long, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, long, long, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, long, long, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, long, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, long, double, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, long, double, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, long, double, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, long, double, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, long, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, long, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, long, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, long, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, long, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, double, int, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, double, int, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, double, int, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, double, int, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, double, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, double, float, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, double, float, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, double, float, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, double, float, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, double, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, double, long, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, double, long, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, double, long, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, double, long, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, double, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, double, double, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, double, double, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, double, double, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, double, double, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, double, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, double, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, double, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, double, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, double, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, int, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, int, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, int, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, int, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, float, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, float, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, float, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, float, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, long, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, long, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, long, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, long, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, double, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, double, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, double, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, double, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, int, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, int, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, int, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, int, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, float, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, float, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, float, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, float, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, long, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, long, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, long, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, long, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, double, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, double, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, double, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, double, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, int, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, int, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, int, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, int, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, float, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, float, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, float, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, float, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, long, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, long, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, long, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, long, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, double, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, double, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, double, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, double, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, int, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, int, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, int, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, int, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, float, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, float, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, float, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, float, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, long, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, long, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, long, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, long, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, double, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, double, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, double, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, double, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, int, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, int, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, int, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, int, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, float, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, float, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, float, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, float, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, long, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, long, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, long, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, long, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, double, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, double, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, double, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, double, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, int, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, int, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, int, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, int, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, float, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, float, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, float, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, float, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, long, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, long, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, long, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, long, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, double, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, double, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, double, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, double, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke53777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, int, int, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, int, int, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, int, int, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, int, int, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, int, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, int, float, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, int, float, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, int, float, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, int, float, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, int, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, int, long, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, int, long, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, int, long, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, int, long, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, int, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, int, double, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, int, double, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, int, double, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, int, double, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, int, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, int, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, int, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, int, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, int, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, float, int, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, float, int, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, float, int, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, float, int, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, float, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, float, float, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, float, float, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, float, float, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, float, float, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, float, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, float, long, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, float, long, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, float, long, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, float, long, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, float, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, float, double, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, float, double, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, float, double, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, float, double, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, float, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, float, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, float, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, float, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, float, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, long, int, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, long, int, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, long, int, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, long, int, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, long, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, long, float, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, long, float, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, long, float, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, long, float, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, long, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, long, long, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, long, long, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, long, long, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, long, long, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, long, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, long, double, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, long, double, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, long, double, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, long, double, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, long, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, long, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, long, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, long, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, long, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, double, int, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, double, int, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, double, int, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, double, int, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, double, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, double, float, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, double, float, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, double, float, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, double, float, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, double, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, double, long, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, double, long, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, double, long, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, double, long, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, double, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, double, double, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, double, double, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, double, double, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, double, double, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, double, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, double, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, double, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, double, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, double, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, int, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, int, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, int, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, int, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, float, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, float, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, float, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, float, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, long, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, long, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, long, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, long, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, double, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, double, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, double, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, double, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, int, int, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, int, int, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, int, int, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, int, int, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, int, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, int, float, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, int, float, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, int, float, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, int, float, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, int, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, int, long, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, int, long, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, int, long, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, int, long, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, int, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, int, double, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, int, double, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, int, double, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, int, double, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, int, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, int, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, int, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, int, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, int, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, float, int, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, float, int, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, float, int, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, float, int, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, float, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, float, float, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, float, float, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, float, float, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, float, float, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, float, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, float, long, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, float, long, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, float, long, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, float, long, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, float, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, float, double, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, float, double, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, float, double, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, float, double, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, float, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, float, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, float, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, float, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, float, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, long, int, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, long, int, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, long, int, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, long, int, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, long, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, long, float, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, long, float, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, long, float, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, long, float, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, long, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, long, long, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, long, long, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, long, long, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, long, long, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, long, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, long, double, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, long, double, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, long, double, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, long, double, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, long, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, long, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, long, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, long, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, long, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, double, int, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, double, int, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, double, int, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, double, int, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, double, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, double, float, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, double, float, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, double, float, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, double, float, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, double, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, double, long, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, double, long, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, double, long, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, double, long, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, double, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, double, double, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, double, double, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, double, double, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, double, double, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, double, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, double, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, double, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, double, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, double, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, int, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, int, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, int, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, int, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, float, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, float, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, float, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, float, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, long, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, long, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, long, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, long, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, double, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, double, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, double, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, double, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, int, int, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, int, int, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, int, int, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, int, int, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, int, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, int, float, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, int, float, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, int, float, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, int, float, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, int, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, int, long, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, int, long, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, int, long, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, int, long, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, int, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, int, double, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, int, double, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, int, double, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, int, double, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, int, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, int, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, int, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, int, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, int, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, float, int, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, float, int, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, float, int, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, float, int, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, float, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, float, float, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, float, float, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, float, float, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, float, float, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, float, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, float, long, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, float, long, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, float, long, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, float, long, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, float, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, float, double, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, float, double, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, float, double, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, float, double, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, float, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, float, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, float, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, float, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, float, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, long, int, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, long, int, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, long, int, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, long, int, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, long, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, long, float, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, long, float, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, long, float, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, long, float, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, long, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, long, long, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, long, long, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, long, long, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, long, long, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, long, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, long, double, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, long, double, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, long, double, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, long, double, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, long, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, long, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, long, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, long, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, long, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, double, int, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, double, int, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, double, int, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, double, int, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, double, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, double, float, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, double, float, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, double, float, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, double, float, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, double, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, double, long, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, double, long, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, double, long, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, double, long, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, double, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, double, double, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, double, double, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, double, double, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, double, double, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, double, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, double, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, double, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, double, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, double, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, int, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, int, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, int, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, int, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, float, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, float, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, float, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, float, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, long, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, long, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, long, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, long, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, double, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, double, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, double, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, double, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, int, int, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, int, int, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, int, int, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, int, int, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, int, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, int, float, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, int, float, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, int, float, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, int, float, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, int, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, int, long, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, int, long, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, int, long, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, int, long, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, int, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, int, double, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, int, double, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, int, double, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, int, double, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, int, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, int, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, int, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, int, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, int, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, float, int, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, float, int, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, float, int, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, float, int, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, float, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, float, float, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, float, float, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, float, float, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, float, float, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, float, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, float, long, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, float, long, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, float, long, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, float, long, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, float, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, float, double, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, float, double, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, float, double, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, float, double, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, float, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, float, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, float, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, float, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, float, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, long, int, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, long, int, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, long, int, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, long, int, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, long, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, long, float, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, long, float, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, long, float, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, long, float, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, long, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, long, long, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, long, long, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, long, long, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, long, long, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, long, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, long, double, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, long, double, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, long, double, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, long, double, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, long, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, long, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, long, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, long, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, long, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, double, int, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, double, int, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, double, int, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, double, int, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, double, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, double, float, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, double, float, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, double, float, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, double, float, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, double, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, double, long, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, double, long, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, double, long, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, double, long, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, double, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, double, double, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, double, double, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, double, double, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, double, double, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, double, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, double, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, double, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, double, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, double, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, int, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, int, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, int, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, int, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, float, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, float, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, float, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, float, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, long, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, long, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, long, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, long, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, double, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, double, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, double, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, double, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, int, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, int, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, int, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, int, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, float, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, float, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, float, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, float, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, long, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, long, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, long, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, long, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, double, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, double, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, double, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, double, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, int, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, int, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, int, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, int, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, float, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, float, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, float, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, float, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, long, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, long, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, long, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, long, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, double, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, double, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, double, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, double, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, int, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, int, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, int, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, int, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, float, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, float, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, float, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, float, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, long, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, long, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, long, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, long, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, double, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, double, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, double, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, double, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, int, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, int, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, int, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, int, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, float, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, float, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, float, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, float, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, long, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, long, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, long, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, long, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, double, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, double, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, double, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, double, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, int, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, int, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, int, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, int, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, float, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, float, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, float, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, float, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, long, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, long, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, long, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, long, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, double, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, double, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, double, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, double, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke55777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57222X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57226X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57223X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57225X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57227X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57262X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57266X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57263X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57265X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57267X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57232X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57236X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57233X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57235X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57237X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57252X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57256X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57253X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57255X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57257X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57272X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57276X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57273X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57275X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57277X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57622X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57626X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57623X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57625X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57627X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57662X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57666X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57663X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57665X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57667X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57632X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57636X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57633X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57635X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57637X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57652X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57656X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57653X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57655X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57657X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57672X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57676X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57673X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57675X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57677X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57322X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57326X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57323X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57325X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57327X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57362X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57366X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57363X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57365X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57367X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57332X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57336X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57333X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57335X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57337X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57352X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57356X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57353X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57355X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57357X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57372X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57376X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57373X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57375X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57377X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57522X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57526X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57523X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57525X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57527X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57562X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57566X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57563X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57565X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57567X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57532X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57536X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57533X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57535X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57537X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57552X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57556X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57553X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57555X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57557X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57572X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57576X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57573X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57575X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57577X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57722X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57726X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57723X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57725X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57727X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (int)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57762X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57766X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57763X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57765X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57767X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, float, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (float)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57732X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57736X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57733X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57735X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57737X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, long, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (long)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57752X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57756X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57753X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57755X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57757X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (double)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57772X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, int, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, int, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, int, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, int, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, int, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (int)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57776X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, float, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, float, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, float, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, float, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, float, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (float)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57773X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, long, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, long, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, long, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, long, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, long, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (long)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57775X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, double, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, double, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, double, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, double, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, double, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (double)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}

	private unsafe static int Invoke57777X(string code, IntPtr p, List<object?>? args)
	{
		if (args == null)
		{
			return -1;
		}
		return code[5] switch
		{
			'2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (int)args![5]), 
			'6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (float)args![5]), 
			'3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (long)args![5]), 
			'5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (double)args![5]), 
			'7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2], (IntPtr)args![3], (IntPtr)args![4], (IntPtr)args![5]), 
			_ => -1, 
		};
	}
}
